using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MOD;

namespace DAL
{
    // 借还记录帮助类
    public class BorrowAnnalDal
    {
        SqlHelp sqlHelp = new SqlHelp();
        /// <summary>
        /// 获取全部借还记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetBorrowAnnalInfo()
        {
            string sql = "select ID,BookID 图书编号,ReaderID 读者编号,BorrowTime 借书时间,ReturnTIme 还书时间 from BookBorrowReturnInfo";
            DataTable dt = sqlHelp.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        ///  查询读者的借还书记录
        /// </summary>
        /// <param name="borrowAnnalMod"></param>
        /// <returns></returns>
        public DataTable FindBorrowAnnalInfo(BorrowAnnalMod borrowAnnalMod)
        {
            string sql = "select ID,BookID 图书编号,ReaderID 读者编号,BorrowTime 借书时间,ReturnTIme 还书时间 from BookBorrowReturnInfo where ReaderID like '%'+ @ReaderID + '%'";
            SqlParameter[] sqlpar =
            {
                new SqlParameter("@ReaderID",borrowAnnalMod.ReaderID)
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpar);
            return dt;
        }
    }
}
