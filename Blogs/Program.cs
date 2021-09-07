using Blogs.DataModels.SqlDataModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using SqlSugar;
using System;
using System.Linq;
using System.Reflection;

namespace Blogs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

   

}
