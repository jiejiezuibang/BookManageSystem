using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MOD;

namespace DAL.BookDal
{
    public class BookInfoDal
    {
        SqlHelp sqlHelp = new SqlHelp();
        // 获取图书信息
        public DataTable GetBookInfo()
        {
            // 要执行的sql语句
            string sql = @"select a.ID,a.BookID 图书编号,a.Name 图书名称,b.CategoryName 图书类型,a.Author 图书作者,a.Money 图书价格,c.Description 状态 from BookInfo a
left join BookCategory b
on a.CategoryType = b.CategoryID
left join BookState c
on a.State = c.BookState";
            // 获得一张数据表
            DataTable dt = sqlHelp.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="bookInfoMod"></param>
        /// <returns></returns>
        public int AddBookInfo(BookInfoMod bookInfoMod)
        {
            // 要执行的sql语句
            string sql = "insert into BookInfo(BookID,Name,Author,Money,CategoryType) values(@BookID,@Name,@Author,@Money,@CategoryType)";
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@BookID",bookInfoMod.BookID),
                new SqlParameter("@Name",bookInfoMod.Name),
                new SqlParameter("@Author",bookInfoMod.Author),
                new SqlParameter("@Money",bookInfoMod.Money),
                new SqlParameter("@CategoryType",bookInfoMod.CategoryType)
            };
            // 返回受影响行数
            int result = sqlHelp.SqlOperate(sql, sqlpars);
            return result;
        }
        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <param name="bookInfoMod"></param>
        /// <returns></returns>
        public int UpdateBookInfo(BookInfoMod bookInfoMod)
        {
            // 要执行的sql语句
            string sql = "update BookInfo set Name=@name,Author=@Author,Money=@Money,CategoryType=@CategoryType where BookID=@BookID";
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@ID",bookInfoMod.ID),
                new SqlParameter("@BookID",bookInfoMod.BookID),
                new SqlParameter("@Name",bookInfoMod.Name),
                new SqlParameter("@Author",bookInfoMod.Author),
                new SqlParameter("@Money",bookInfoMod.Money),
                new SqlParameter("@CategoryType",bookInfoMod.CategoryType)
            };
            // 返回受影响行数
            int result = sqlHelp.SqlOperate(sql, sqlpars);
            return result;
        }
        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="bookInfoMod"></param>
        /// <returns></returns>
        public int DelBookInfo(BookInfoMod bookInfoMod)
        {
            // 要执行的sql语句
            string sql = "delete from BookInfo where BookID=@BookID";
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@BookID",bookInfoMod.BookID)
            };
            // 返回受影响行数
            int result = sqlHelp.SqlOperate(sql, sqlpars);
            return result;
        }
        /// <summary>
        /// 根据图书编号查询图书数据
        /// </summary>
        /// <param name="bookInfoMod"></param>
        /// <returns></returns>
        public DataTable FindBookInfo(BookInfoMod bookInfoMod)
        {
            // 要执行的sql语句
            string sql = @"select a.ID,a.BookID 图书编号,a.Name 图书名称,b.CategoryName 图书类型,a.Author 图书作者,a.Money 图书价格,c.Description 状态 from BookInfo a
left join BookCategory b
on a.CategoryType = b.CategoryID
left join BookState c
on a.State = c.BookState where a.BookID like '%' + @BookID + '%'";
            SqlParameter[] sqlpar =
            {
                new SqlParameter("@BookID",bookInfoMod.BookID)
            };
            // 返回查询到的数据
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpar);
            return dt;
        }
        /// <summary>
        /// 查询未借出的图书
        /// </summary>
        /// <returns></returns>
        public DataTable FindNotBorrowBookInfo()
        {
            // 要执行的sql语句
            string sql = @"select a.ID,a.BookID 图书编号,a.Name 图书名称,b.CategoryName 图书类型,a.Author 图书作者,a.Money 图书价格,c.Description 状态 from BookInfo a
left join BookCategory b
on a.CategoryType = b.CategoryID
left join BookState c
on a.State = c.BookState where a.State = 0";
            // 获得一张数据表
            DataTable dt = sqlHelp.GetDataTable(sql);
            return dt;
        }
    }
}
