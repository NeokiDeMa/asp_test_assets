using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.ComponentModel;

namespace AssetServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //private readonly string IconsPath = "https://net8-web-api-test.up.railway.app/file/iconss/";
        //private readonly string AssetsPath = "https://net8-web-api-test.up.railway.app/file/assetss/";

        private readonly string IconsPath = "http://localhost/iconss/";
        private readonly string AssetsPath = "http://localhost/assetss/";

        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Book1.xlsx");

        [HttpGet("find-all")]
        public IActionResult GetAssetsByCategoryId([FromQuery] string categoryId)
        {
            var categories = ReadCategoriesFromExcel();
            var assets = ReadAssetsFromExcel();

            // پیدا کردن دسته‌بندی با همان categoryId
            var category = categories.FirstOrDefault(c => c.Id == categoryId);

            if (category == null)
            {
                return NotFound("Category not found.");
            }

            // فیلتر کردن assets مربوط به categoryId
            var categoryAssets = assets.Where(a => a.CategoryId == categoryId).ToList();

            // اضافه کردن assets به دسته‌بندی
            category.Assets = categoryAssets;

            return Ok(new[] { category });
        }

        [HttpGet("parents")]
        public IActionResult GetParentCategories()
        {
            var categories = ReadCategoriesFromExcel();
            var parentCategories = categories.Where(c => c.ParentCategoryId == null).ToList();
            return Ok(parentCategories);
        }

        [HttpGet("find-category")]
        public IActionResult GetSubCategories([FromQuery] string categoryId)
        {
            var categories = ReadCategoriesFromExcel();

            // پیدا کردن دسته‌بندی که parentCategoryId برابر با categoryId است
            var parentCategory = categories.FirstOrDefault(c => c.Id == categoryId);

            if (parentCategory == null)
            {
                return NotFound("Category not found.");
            }

            // پیدا کردن تمامی زیرمجموعه‌های این دسته‌بندی
            var subCategories = categories
                .Where(c => c.ParentCategoryId == categoryId)
                .ToList();

            // اضافه کردن زیرمجموعه‌ها به parentCategory
            parentCategory.SubCategory = subCategories;

            // بازگشت پاسخ با parentCategory و زیرمجموعه‌ها
            return Ok(new[] { parentCategory });
        }

        private List<Category> ReadCategoriesFromExcel()
        {
            var categories = new List<Category>();

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(_filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // فرض می‌کنیم داده‌ها در شیت اول هستند
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // فرض بر این که سطر اول هدر است
                {
                    categories.Add(new Category
                    {
                        Id = worksheet.Cells[row, 1].Text,
                        Icon = IconsPath + worksheet.Cells[row, 2].Text,
                        Gender = worksheet.Cells[row, 3].Text,
                        Name = worksheet.Cells[row, 4].Text,
                        Username = worksheet.Cells[row, 5].Text,
                        ParentCategoryId = string.IsNullOrEmpty(worksheet.Cells[row, 6].Text) ? null : worksheet.Cells[row, 6].Text
                    });
                }
            }
            return categories;
        }

        private List<Asset> ReadAssetsFromExcel()
        {
            var assets = new List<Asset>();

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(_filePath)))
            {
                var worksheet = package.Workbook.Worksheets[1]; // فرض می‌کنیم داده‌ها در شیت دوم هستند
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // فرض بر این که سطر اول هدر است
                {
                    string file = "";
                    if (!string.IsNullOrEmpty( worksheet.Cells[row, 2].Text))
                    {
                        var stArr = worksheet.Cells[row, 2].Text.Split(',');
                        for (int i = 0; i < stArr.Count(); i++)
                            stArr[i] = AssetsPath + stArr[i];
                        file = string.Join(',',stArr);
                    }

                    assets.Add(new Asset
                    {
                        Id = new Guid().ToString(),
                        Icon = IconsPath + worksheet.Cells[row, 1].Text,
                        File = file,
                        Gender = worksheet.Cells[row, 3].Text,
                        Name = worksheet.Cells[row, 4].Text,
                        Username = worksheet.Cells[row, 5].Text,
                        Type = worksheet.Cells[row, 6].Text,
                        Data = worksheet.Cells[row, 7].Text,
                        CategoryId = worksheet.Cells[row, 8].Text,
                    });
                }
            }
            return assets;
        }
    }



    public class Asset
    {
        public string Id { get; set; }
        public string Icon { get; set; }
        public string File { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public string CategoryId { get; set; }
    }

    public class Category
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Gender { get; set; }
        public string ParentCategoryId { get; set; }
        public List<Category> SubCategory { get; set; }
        public List<Asset> Assets { get; set; }
    }
}
