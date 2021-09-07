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
        [HttpPost("test_model")]
        public string Ligin(string test_model)
        {
            //逻辑处理
            lg.Logins(test_model);

            return "asdf";
        }

        /// <summary>
        /// 账号登录
        /// </summary>
        /// <param name="user_mun"></param>
        /// <param name="passwrod"></param>
        /// <returns></returns>
        [HttpPost("code")]
        public string Ligin(string user_mun, string passwrod)
        {
            return "asdfsad";
        }

        /// <summary>
        /// 验证码发送
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string Send()
        {
            //return lg.Send();
            return "asdfa";
        }

        #region 入参模型

        class Ligindata
        {
            public string code1 { get; set; }
            public string code2 { get; set; }
        }


        #endregion


    }
}
