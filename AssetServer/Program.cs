var builder = WebApplication.CreateBuilder(args);

// 🚀 حذف تمام محدودیت‌های CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// اضافه کردن سرویس‌های موردنیاز
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🚀 فعال کردن CORS بدون محدودیت
app.UseCors("AllowAll");

// 🚀 مدیریت درخواست‌های OPTIONS بدون محدودیت
app.Use(async (context, next) =>
{
    if (context.Request.Method == "OPTIONS")
    {
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.Headers.Add("Access-Control-Allow-Methods", "*");
        context.Response.Headers.Add("Access-Control-Allow-Headers", "*");
        context.Response.StatusCode = 200;
        return;
    }
    await next();
});

// 🚀 فعال‌سازی Swagger بدون محدودیت
app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection(); // ❌ در صورت نیاز، این را کامنت کنید تا HTTP هم کار کند

//app.UseAuthorization();
app.MapControllers();
app.Run();
