using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogs.Controllers;


namespace Blogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        Blogs.Server.Login lg = new Blogs.Server.Login();

        /// <summary>
        /// 验证码登录
        /// </summary>
        /// <param name="test_model"></param>
        /// <returns></returns>
        [HttpPost]
        public string Ligin(string test_model)
        {
            //逻辑处理
            lg.Logins(test_model);

            return string.Empty;
        }

        /// <summary>
        /// 账号登录
        /// </summary>
        /// <param name="user_mun"></param>
        /// <param name="passwrod"></param>
        /// <returns></returns>
        [HttpPost]
        public string Ligin(string user_mun, string passwrod)
        {
            return string.Empty;
        }

        /// <summary>
        /// 验证码发送
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string Send()
        {
          return lg.Send();
        }

        
    }
}
