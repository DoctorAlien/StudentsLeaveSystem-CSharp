using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace AskForLeave
{
    class common
    {
        public static string number;//登陆窗口传值 txtNum 变量
        //changepass.cs login.cs student.cs teacher.cs

        public static string password;//窗口传递 password 变量 
        //changepass.cs login.cs student.cs

        public static string oldMd5Pass;
        public static string newMd5Pass;

        public static int uid;//全局uid变量  
        //changepass.cs   leaveHistory.cs student.cs

        public static string teacher_leave_id;//全局teacher_leave_id变量
        //teacher.cs

        /// <summary>
        /// 生成MD5码
        /// </summary>
        /// <param name="md5A"></param>
        /// <returns></returns>
        public static string md5Create(string md5A)
        {
            byte[] beforeMd5 = Encoding.Default.GetBytes(md5A.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(beforeMd5);
            string md5Result = BitConverter.ToString(output).Replace("-", "");
            return md5Result;
        }
    }
}
