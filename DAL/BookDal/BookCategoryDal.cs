using MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BookDal
{
    public class BookCategoryDal
    {
        SqlHelp sqlHelp = new SqlHelp();
        /// <summary>
        /// 获取图书类型(子类)
        /// </summary>
        /// <returns></returns>
        public DataTable GetBookCategory()
        {
            string sql = "select * from BookCategory where ParentID <> 0";
            DataTable dt = sqlHelp.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 获取全部图书类型
        /// </summary>
        /// <returns></returns>
        public List<BookCategoryMod> GetAllBookType()
        {
            string sql = "select * from BookCategory";
            DataTable dt = sqlHelp.GetDataTable(sql);
            
            List<BookCategoryMod> list = null;
            if(dt.Rows.Count > 0)
            {
                list = new List<BookCategoryMod>();
                // 这里类型要DataRow，不然无法tostring
                foreach(DataRow row in dt.Rows)
                {
                    // 创建图书类型对象并赋值，然后添加到list集合中
                    list.Add(new BookCategoryMod()
                    {
                        ID = int.Parse(row["ID"].ToString()),
                        CategoryID = int.Parse(row["CategoryID"].ToString()),
                        CategoryName = row["CategoryName"].ToString(),
                        ParentID = int.Parse(row["ParentID"].ToString())
                    });
                }
            }
            return list;
        }
        /// <summary>
        /// 根据图书类别查找图书信息(子类)
        /// </summary>
        /// <returns></returns>
        public DataTable FindBookInfo_Son(BookCategoryMod bookCategoryMod)
        {
            string sql = @"select a.ID,a.BookID 图书编号,a.Name 图书名称,b.CategoryName 图书类型,a.Author 图书作者,a.Money 图书价格,c.Description 状态 from BookInfo a
left join BookCategory b
on a.CategoryType = b.CategoryID
left join BookState c
on a.State = c.BookState where b.CategoryName = @CategoryName";
            SqlParameter[] sqlpar =
            {
                new SqlParameter("@CategoryName",bookCategoryMod.CategoryName)
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpar);
            return dt;
        }
        /// <summary>
        /// 根据图书类别查找图书信息(父类)
        /// </summary>
        /// <param name="bookCategoryMod"></param>
        /// <returns></returns>
        public DataTable FindBookInfo_Father(BookCategoryMod bookCategoryMod)
        {
            string sql = @"select a.ID,a.BookID 图书编号,a.Name 图书名称,b.CategoryName 图书类型,a.Author 图书作者,a.Money 图书价格,c.Description 状态 from BookInfo a
inner join (select * from BookCategory where ParentID = (select CategoryID from BookCategory where CategoryName = @CategoryName)) b
on a.CategoryType = b.CategoryID
left join BookState c
on a.State = c.BookState";
            SqlParameter[] sqlpar =
            {
            new SqlParameter("@CategoryName",bookCategoryMod.CategoryName)
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpar);
            return dt;
        }
        /// <summary>
        /// 根据图书类别名获取PID
        /// </summary>
        /// <param name="bookCategoryMod"></param>
        /// <returns></returns>
        public DataTable FindBookParentID(BookCategoryMod bookCategoryMod)
        {
            string sql = @"select ParentID from BookCategory where CategoryName=@CategoryName";
            SqlParameter[] sqlpar =
            {
                new SqlParameter("@CategoryName",bookCategoryMod.CategoryName)
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpar);
            return dt;
        }
    }
}
