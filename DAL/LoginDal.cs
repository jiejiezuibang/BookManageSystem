using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MOD;

namespace DAL
{
    /// <summary>
    /// 登录信息的数据库访问类
    /// 作用：访问数据库，得到管理员账号密码等基本信息，用于登录
    /// </summary>
    public class LoginDal
    {
        SqlHelp sqlHelp = new SqlHelp();
        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="Name">账号</param>
        /// <returns></returns>
        public LoginMod getAnminInfo(string Name)
        {
            // 定义一个对象
            LoginMod loginMod = null;
            // 构造sql语句
            string sql = "select * from AdminInfo where AdminID = @Name";
            // 为语句构造参数
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@Name",Name)
            };
            // 执行查询得到结果
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpars);
            if(dt.Rows.Count > 0)
            {
                loginMod = new LoginMod()
                {
                    ID = Convert.ToInt32(dt.Rows[0][0]),
                    AdminID = dt.Rows[0][1].ToString(),
                    AdminPWD = dt.Rows[0][2].ToString(),
                };
            }
            return loginMod;
        }
    }
}
