using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tools
{
    public class MD5Encrypt
    {
        /// <summary>
        /// 获取加密后字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetStr(string str)
        {
            MD5 mD5 = MD5.Create();
            // 将字符串转换为字节数组
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteArray = mD5.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            foreach(byte item in byteArray)
            {
                //将字节数组转成16进制的字符串。X表示16进制，2表示每个16字符占2位
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
