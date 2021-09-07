using Blogs.DataModels.SqlDataModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using SqlSugar;
using System;

namespace Blogs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region 从实体创建数据库
            AddDataContext context = new AddDataContext();
            context.CreateTable(false, 50, typeof(Bg_article), typeof(Bg_article_comment), typeof(Bg_article_type),typeof(Bg_user));
            #endregion

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });




    }

    public class AddDataContext
    {
        public SqlSugar.SqlSugarClient ssc;
        public AddDataContext()
        {
            ssc = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "",//数据库连接字段
                DbType = DbType.MySql,//指定数据库
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
        }

        /// <summary>
        /// 见表
        /// </summary>
        /// <param name="Backup"></param>
        /// <param name="StringDefaultLength"></param>
        /// <param name="types"></param>
        public void CreateTable(bool Backup = false, int StringDefaultLength = 50, params Type[] types)
        {
            ssc.CodeFirst.SetStringDefaultLength(StringDefaultLength);
            ssc.DbMaintenance.CreateDatabase();//建库
            if (Backup)
            {
                ssc.CodeFirst.BackupTable().InitTables(types);
            }
            else
            {
                ssc.CodeFirst.InitTables(types);
            }
        }
        public SimpleClient<Blogs.DataModels.SqlDataModels.Bg_article> Bg_article { get { return new SimpleClient<Blogs.DataModels.SqlDataModels.Bg_article>(ssc); } }
       
        public SimpleClient<Blogs.DataModels.SqlDataModels.Bg_article_comment> Bg_article_comment { get { return new SimpleClient<Blogs.DataModels.SqlDataModels.Bg_article_comment>(ssc); } }
       
        public SimpleClient<Blogs.DataModels.SqlDataModels.Bg_article_type> Bg_article_type { get { return new SimpleClient<Blogs.DataModels.SqlDataModels.Bg_article_type>(ssc); } }
       
        public SimpleClient<Blogs.DataModels.SqlDataModels.Bg_user> Bg_user { get { return new SimpleClient<Blogs.DataModels.SqlDataModels.Bg_user>(ssc); } }








    }

}
