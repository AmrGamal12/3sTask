using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Text.RegularExpressions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddLocalization(options => options.ResourcesPath="Resources");
builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var SupportedCulture = new[]
    {  new CultureInfo("en"),
    new CultureInfo("ar")
    };
    options.DefaultRequestCulture= new RequestCulture(culture: "en", uiCulture: "en");
    options.SupportedCultures=SupportedCulture;
    options.SupportedUICultures=SupportedCulture;
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
var SupportedCultures = new[] { "en", "ar" };
var LoclizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("en")
    .AddSupportedCultures(SupportedCultures)
    .AddSupportedUICultures(SupportedCultures);



app.UseRequestLocalization(LoclizationOptions);
app.UseCors(c => c.AllowAnyMethod().AllowAnyOrigin());


app.UseAuthorization();

app.MapControllers();

app.Run();
