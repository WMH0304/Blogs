using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blogs.DataModels.SqlDataModels
{
    /// <summary>
    /// 文章评论
    /// </summary>
   [SqlSugar.SugarTable("Bg_article_comment")]
    class Bg_article_comment
    {
       [SqlSugar.SugarColumn(IsIdentity =true,IsPrimaryKey =true)]
        public int id { get; set; }
       
        /// <summary>
        /// 评论内容
        /// </summary>
        public string ac_control { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime ac_date { get; set; }


    }
}
