using System;
using System.Net.Mail;
using System.Text;

namespace Blogs.Tool
{
    public class SendMessage
    {
        /// <summary>
        /// 设置邮箱发送
        /// </summary>
        /// <returns></returns>
        public string Send()
        {
            //邮件发送类
            MailMessage mail = new MailMessage();
            //发送地址
            mail.From = new MailAddress(Messages.send);
            //接收地址
            mail.To.Add(Messages.receive);
            //邮件标题
            mail.Subject = "登录验证码";
            Tool.Messages.code_verification = Tool.Tools.randomNum().ToString();
            if (Tool.Messages.code_verification == string.Empty)
            {
                Send();
            }
            //邮件内容
            mail.Body = $"{Tool.Messages.code_verification}";
            //设置为html
            mail.IsBodyHtml = true;
            //smtp 连接
            SmtpClient smtp = new SmtpClient();
            // SMTP 事务的端口。
            smtp.Port = 465;
            //设置qq 邮箱
            smtp.Host = "smtp.qq.com";
            //使用安全加密连接（是否启用SSL）
            smtp.EnableSsl = true;
            //设置超时时间
            //smtp.Timeout = 10000;
            //不和请求一块发送。
            smtp.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            smtp.Credentials = new System.Net.NetworkCredential(Messages.send, "qq邮箱授权码");
            try
            {
                //发送
                smtp.Send(mail);
            }
            catch (Exception e)//发送异常
            {
                //发送失败
                System.IO.File.WriteAllText(@"C:\test.txt", e.ToString(), Encoding.UTF8);
                return Tool.c_hint.chint(hint.fail);
            }
            //发送成功
            return Tool.c_hint.chint(hint.succeed);





        }



    }
}
