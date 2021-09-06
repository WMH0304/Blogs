using System;

namespace Blogs.Tool
{
    static class Tools
    {
        /// <summary>
        /// 获取随机数
        /// </summary>
        /// <returns></returns>
        public static int randomNum()
        {
            Random r = new Random();
           return r.Next(10000, 10000);
        }
    }
}
