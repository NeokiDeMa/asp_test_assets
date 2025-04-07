using Microsoft.AspNetCore.Mvc;

namespace AssetServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly string IconsPath = "https://avatars-backend-production.up.railway.app/static/iconss/";
        private readonly string AssetsPath = "https://avatars-backend-production.up.railway.app/static/assetss/";

        //private readonly string IconsPath = "http://localhost:9000/iconss/";
        //private readonly string AssetsPath = "http://localhost:9000/assetss/";

        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Book1.xlsx");

        private Database database = new Database();

        [HttpGet("find-all")]
        public IActionResult GetAssetsByCategoryId([FromQuery] string categoryId)
        {
            var category = database.categories.FirstOrDefault(c => c.id == categoryId);

            if (category == null)
                return NotFound("Category not found.");

            category.icon = IconsPath + category.icon;

            var categoryAssets = database.assets.Where(a => a.categoryId == categoryId).ToList();

            category.Assets = categoryAssets;

            category.Assets.ForEach(c =>
            {
                c.icon = IconsPath + c.icon;
                if (!string.IsNullOrEmpty(c.file))
                {
                    string[] files = c.file.Split(',');
                    for(int i = 0; i < files.Length; i++)
                    {
                        files[i] = AssetsPath + files[i];
                    }
                    c.file = string.Join(',',files);
                }
            });

            return Ok(new[] { category });
        }

        [HttpGet("parents")]
        public IActionResult GetParentCategories()
        {
            var parentCategories = database.categories.Where(c => string.IsNullOrEmpty(c.parentCategoryId)).ToList();
            parentCategories.ForEach(c =>
            {
                c.icon = IconsPath + c.icon;
            });
            return Ok(parentCategories);
        }

        [HttpGet("find-category")]
        public IActionResult GetSubCategories([FromQuery] string categoryId)
        {
            var parentCategory = database.categories.FirstOrDefault(c => c.id == categoryId);
            parentCategory.icon = IconsPath + parentCategory.icon;
            if (parentCategory == null)
                return NotFound("Category not found.");
            
            var subCategories = database.categories
                .Where(c => c.parentCategoryId == categoryId)
                .ToList();

            subCategories.ForEach(c =>
            {
                c.icon = IconsPath + c.icon;
            });

            parentCategory.SubCategory = subCategories;

            return Ok(new[] { parentCategory });
        }
    }
}
