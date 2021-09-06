using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogs.Tool;

namespace Blogs.Server
{
    /// <summary>
    /// 登录页面处理
    /// </summary>
   public class Login
    {
        /// <summary>
        /// 验证码登录
        /// </summary>
        /// <param name="test_model"></param>
        /// <returns></returns>
        public string Logins(string test_model)
        {
            if (test_model !=string.Empty)
            {
                return c_hint.chint(hint.fail);
            }
            return c_hint.chint(hint.succeed);
        }

        /// <summary>
        /// 账号密码登录
        /// </summary>
        /// <param name="user_num"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Logins(string user_num, string password)
        {
            return string.Empty;
        }

        /// <summary>
        /// 验证码发送
        /// </summary>
        /// <returns></returns>
        public string Send()
        {
            Blogs.Tool.SendMessage send = new SendMessage();
            return send.Send();
        }

    }
}
