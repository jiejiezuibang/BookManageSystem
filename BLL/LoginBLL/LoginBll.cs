using DAL;
using DAL.Tools;
using MOD;
using MOD.Enums;
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
        // 创建登录信息的数据访问层对象
        LoginDal loginDal = DALFactory.GetLoginDal;
        /// <summary>
        /// 根据账号查找对象
        /// </summary>
        /// <param name="Name">账号</param>
        /// <param name="Pwd">密码</param>
        /// <returns></returns>
        public LoginStateEnms LoginCheck(string Name,string Pwd)
        {
            try
            {
                // 根据用户名进行对象的查询
                LoginMod loginMod = loginDal.getAnminInfo(Name);
                if(loginMod == null)
                {
                    // 账号错误
                    return LoginStateEnms.LoginIDError;
                }
                MD5Encrypt mD5Encrypt = new MD5Encrypt();
                // 账号正确，判断密码
                if (loginMod.AdminPWD.Equals(mD5Encrypt.GetStr(Pwd)))
                {
                    // 密码正确，登录成功
                    return LoginStateEnms.Ok;
                }
                else
                {
                    // 密码错误
                    return LoginStateEnms.LoginPwdError;
                }
            }
            catch
            {
                // 发生异常
                return LoginStateEnms.LoginError;
            }
        }
    }
}
