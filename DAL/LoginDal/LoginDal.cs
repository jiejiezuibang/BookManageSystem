using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.LoginDal
{
    public class LoginDal
    {
        SqlHelp sqlHelp = new SqlHelp();
        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        public DataTable getAnminInfo(string Name,string Pwd)
        {
            // 在数据库查找该用户是否存在却密码是否正确
            string sql = "select * from AdminInfo where AdminID = @Name and AdminPwd = @Pwd";
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@Name",Name),
                new SqlParameter("@Pwd",Pwd)
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpars);
            return dt;
        }
    }
}
