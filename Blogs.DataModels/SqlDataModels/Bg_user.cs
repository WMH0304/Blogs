using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.DataModels.SqlDataModels
{
    /// <summary>
    /// 用户
    /// </summary>
    class Bg_user
    {
        /// <summary>
        /// 名字
        /// </summary>
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
