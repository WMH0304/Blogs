namespace Blogs.DataModels.SqlDataModels
{
    /// <summary>
    /// 用户
    /// </summary>
    [SqlSugar.SugarTable("Bg_user")]
    class Bg_user
    {
        /// <summary>
        /// 名字
        /// </summary>
        [SqlSugar.SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public string name { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string passwordd { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string test_model { get; set; }


    }
}
