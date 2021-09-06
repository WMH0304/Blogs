namespace Blogs.Tool
{

    /// <summary>
    /// 操作状态
    /// </summary>
    public enum hint
    {
        /// <summary>
        /// 成功
        /// </summary>
        succeed,
        /// <summary>
        /// 失败
        /// </summary>
        fail,
        /// <summary>
        /// 异常
        /// </summary>
        abnormal,
        /// <summary>
        /// 其他
        /// </summary>
        rests,
    }

    /// <summary>
    /// 状态标志
    /// </summary>
   public static  class  c_hint
    {
        static  public string chint(hint o)
        {
            var hinstr = string.Empty;
            switch (o)
            {
                case hint.succeed:
                    hinstr = "操作成功！";
                    break;
                case hint.fail:
                    hinstr = "操作失败！";
                    break;
                case hint.abnormal:
                    hinstr = "操作异常！";
                    break;
                case hint.rests:
                    hinstr = "其他！";
                    break;
                default:
                    break;
            }

            return hinstr;
        }
    }

    /// <summary>
    /// 一些静态字段的配置
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// 发送邮件地址
        /// </summary>
        public readonly static string send = "2100500390@qq.com";

        /// <summary>
        /// 接受地址
        /// </summary>
        public readonly static string receive = "948370689@qq.com";

        /// <summary>
        /// 验证码
        /// </summary>
        public static string code_verification { get; set; }

    }
}
