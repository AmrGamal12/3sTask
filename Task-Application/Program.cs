using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.Threading;
using System.Xml.Serialization;

namespace Task_Application
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            //    //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

            //    //var y = CultureInfo.CurrentCulture;

            //    //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");

            //    //var x = CultureInfo.CurrentCulture;
            //    //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            //    //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar");
            //}
            //public static IServiceCollection AddApplication(this IServiceCollection services)
            //{
            //    services.AddLocalization(o => { o.ResourcesPath = "Resources"; });
            //    //services.Configure<RequestLocalizationOptions>(options =>
            //    //{
            //    //    options.SetDefaultCulture("en");
            //    //    options.AddSupportedUICultures("en", "ar");
            //    //    options.FallBackToParentUICultures = true;
            //    //    options.RequestCultureProviders.Clear();
            //    //});
            //    services.Configure<RequestLocalizationOptions>(options =>

            //    {

            //        var SupportedCulture = new[]
            //        {  new CultureInfo("en"),
            //            new CultureInfo("ar")
            //        };
            //        options.DefaultRequestCulture= new RequestCulture(culture: "en", uiCulture: "en");
            //        options.SupportedCultures=SupportedCulture;
            //        options.SupportedUICultures=SupportedCulture;


            //    });


            //    return services;

            //}
        }

    }
}