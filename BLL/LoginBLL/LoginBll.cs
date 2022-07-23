using DAL.LoginDal;
using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LoginBLL
{
    public class LoginBll
    {
        /// <summary>
        /// 校验登录是否成功
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        public string LoginCheck(string Name,string Pwd)
        {
            try
            {
                LoginDal loginDal = new LoginDal();
                MD5Encrypt mD5Encrypt = new MD5Encrypt();
                // 对用户输入的字符串进行加密
                Pwd = mD5Encrypt.GetStr(Pwd);
                DataTable dt = loginDal.getAnminInfo(Name, Pwd);
                if (dt.Rows.Count == 0)
                {
                    return "400";
                }
                return "200";
            }catch(Exception ex)
            {
                return "404" + ex.ToString();
            }
        }
    }
}
