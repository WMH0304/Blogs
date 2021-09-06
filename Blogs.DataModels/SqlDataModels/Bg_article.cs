using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Blogs.DataModels.SqlDataModels
{

    /// <summary>
    /// 文章类型
    /// </summary>
    [SqlSugar.SugarTable("Bg_article")]
    class Bg_article
    {
        /// <summary>
        /// id
        /// </summary>
        [SqlSugar.SugarColumn(IsIdentity =true,IsPrimaryKey =true)]
        public int id_article { get; set; }

        /// <summary>
        /// 文章类型 id
        /// </summary>
        public string  id_article_type { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string article_title { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        public string article_content { get; set; }

        /// <summary>
        /// 文章图片路径
        /// </summary>
        public  string article_imgurl { get; set; }

        /// <summary>
        /// 文章修改日期
        /// </summary>
        public int article_up_date { get; set; }
    }
}
