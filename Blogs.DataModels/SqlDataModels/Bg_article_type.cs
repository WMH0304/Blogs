using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.DataModels.SqlDataModels
{
    /// <summary>
    /// 文章类型
    /// </summary>
    [SqlSugar.SugarTable("Bg_article_type")]
    class Bg_article_type
    {
        /// <summary>
        /// id
        /// </summary>
        [SqlSugar.SugarColumn(IsIdentity =true,IsPrimaryKey =true)]
        public int id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string  type_name { get; set; }
    }
}
