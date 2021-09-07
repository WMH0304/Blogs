namespace Blogs.DataModels.SqlDataModels
{
    /// <summary>
    /// 文章类型
    /// </summary>
    [SqlSugar.SugarTable("Bg_article_type")]
    public class Bg_article_type
    {
        /// <summary>
        /// id
        /// </summary>
        [SqlSugar.SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string type_name { get; set; }

        /// <summary>
        /// 可能会存在类型内存在类型的情况 
        /// </summary>
        public int type { get; set; }
    }
}
