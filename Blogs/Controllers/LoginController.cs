using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

       /// <summary>
       /// 验证码登录
       /// </summary>
       /// <param name="test_model"></param>
       /// <returns></returns>
        [HttpPost]
        public string Ligin(string test_model)
        {
            return string.Empty;
        }

        /// <summary>
        /// 账号登录
        /// </summary>
        /// <param name="user_mun"></param>
        /// <param name="passwrod"></param>
        /// <returns></returns>
        [HttpPost]
        public string Ligin(string user_mun,string passwrod)
        {
            return string.Empty;
        }
    }
}
