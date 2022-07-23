using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MOD;

namespace DAL.BookBorrowDal
{
    public class BookBorrowDal
    {
        SqlHelp sqlHelp = new SqlHelp();
        /// <summary>
        /// 查询读者借还书记录
        /// </summary>
        /// <param name="bookBorrowReturnInfoMod"></param>
        /// <returns></returns>
        public DataTable GetReaderBookBorrow(BookBorrowReturnInfoMod bookBorrowReturnInfoMod)
        {
            // 根据读者编号查询读者借还书记录
            string sql = @"select ID,BookID 图书编号,ReaderID 读者编号,BorrowTime 借书时间 from BookBorrowReturnInfo where ReaderID = @ReaderID";
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@ReaderID",bookBorrowReturnInfoMod.ReaderID)
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpars);
            return dt;
        }
        /// <summary>
        /// 读者借书操作
        /// </summary>
        /// <param name="bookBorrowReturnInfoMod"></param>
        /// <returns></returns>
        public bool BorrowBook(BookBorrowReturnInfoMod bookBorrowReturnInfoMod)
        {

            // 要执行的sql语句
            string[] sqls =
            {
                "update BookInfo set State = 1 where BookID = @BookID",// 修改图书的状态
                "insert into BookBorrowReturnInfo values(@IDBook,@ReaderID,@BorrowTime,null)", // 添加一条借书记录
            };
            SqlParameter[] BookInfoSqlpar =
            {
                new SqlParameter("@BookID",bookBorrowReturnInfoMod.BookID)
            };
            SqlParameter[] BookBorrowSqlpars =
            {
                new SqlParameter("@IDBook",bookBorrowReturnInfoMod.BookID),
                new SqlParameter("@ReaderID",bookBorrowReturnInfoMod.ReaderID),
                new SqlParameter("@BorrowTime",bookBorrowReturnInfoMod.BorrowTime.ToString()),
            };
            // 要追加的参数集
            List<SqlParameter[]> sqlparList = new List<SqlParameter[]>();
            sqlparList.Add(BookInfoSqlpar);
            sqlparList.Add(BookBorrowSqlpars);
            // 操作数据库
            bool result = sqlHelp.UW(sqls, sqlparList);
            return result;
        }
        /// <summary>
        /// 读者还书操作
        /// </summary>
        /// <returns></returns>
        public bool ReturnBook(BookBorrowReturnInfoMod bookBorrowReturnInfoMod)
        {
            // 要执行的sql语句
            string[] sqls =
            {
                "update BookInfo set State = 0 where BookID = @BookID",// 修改图书的状态
                "update BookBorrowReturnInfo set ReturnTime = @ReturnBookTime where ReaderID=@ReaderID and BookID=@IDBook", // 添加一条借书记录
            };
            SqlParameter[] BookInfoSqlpar =
            {
                new SqlParameter("@BookID",bookBorrowReturnInfoMod.BookID)
            };
            SqlParameter[] BookBorrowSqlpars =
            {
                new SqlParameter("@IDBook",bookBorrowReturnInfoMod.BookID),
                new SqlParameter("@ReaderID",bookBorrowReturnInfoMod.ReaderID),
                new SqlParameter("@ReturnBookTime",bookBorrowReturnInfoMod.ReturnTime.ToString()),
            };
            // 要追加的参数集
            List<SqlParameter[]> sqlparList = new List<SqlParameter[]>();
            sqlparList.Add(BookInfoSqlpar);
            sqlparList.Add(BookBorrowSqlpars);
            // 操作数据库
            bool result = sqlHelp.UW(sqls, sqlparList);
            return result;
        }
        /// <summary>
        /// 查询没有还书的借还书记录
        /// </summary>
        /// <returns></returns>
        public DataTable FindBorrowBookNotReturn(BookBorrowReturnInfoMod bookBorrowReturnInfoMod)
        {
            string sql = "select ID,BookID 图书编号,ReaderID 读者编号,BorrowTime 借书时间 from BookBorrowReturnInfo where ReturnTime is null and ReaderID=@ReaderID";
            SqlParameter[] sqlpar =
            {
                new SqlParameter("@ReaderID",bookBorrowReturnInfoMod.ReaderID),
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpar);
            return dt;
        }
    }
}
