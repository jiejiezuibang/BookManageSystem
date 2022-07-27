using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MOD;
using MOD.Enums;
using DAL.BookDal;
using DAL;

namespace BLL.BookInfoBLL
{
    public class BookInfoBll
    {
        BookInfoDal bookInfoDal = DALFactory.GetBookInfoDal;
        BookCategoryDal bookCategoryDal = DALFactory.GetBookCategoryDal;
        /// <summary>
        /// 获取图书信息业务
        /// </summary>
        /// <returns></returns>
        public DataTable GetBookInfo()
        {
            DataTable dt = bookInfoDal.GetBookInfo();
            return dt;
        }
        /// <summary>
        /// 查询图书信息业务
        /// </summary>
        /// <param name="bookInfoMod"></param>
        /// <returns></returns>
        public DataTable FindBookInfo(BookInfoMod bookInfoMod)
        {
            DataTable dt = bookInfoDal.FindBookInfo(bookInfoMod);
            return dt;
        }
        /// <summary>
        /// 查询未出借的图书业务
        /// </summary>
        /// <returns></returns>
        public DataTable FindNotBorrowBookInfo()
        {
            DataTable dt = bookInfoDal.FindNotBorrowBookInfo();
            return dt;
        }
        /// <summary>
        /// 添加图书业务
        /// </summary>
        /// <returns></returns>
        public BookInfoEnums AddBookInfo(BookInfoMod bookInfoMod)
        {
            int result = bookInfoDal.AddBookInfo(bookInfoMod);
            // 判断添加是否成功
            if(result > 0)
            {
                return BookInfoEnums.AddBookInfoSuccess;
            }
            return BookInfoEnums.AddBookInfoError;
        }
        /// <summary>
        /// 获取图书类型业务(子类)
        /// </summary>
        /// <returns></returns>
        public DataTable GetBookCreategory()
        {
            BookCategoryDal bookCategoryDal = new BookCategoryDal();
            DataTable dt = bookCategoryDal.GetBookCategory();
            return dt;
        }
        /// <summary>
        /// 获取图书信息(用类别获取)
        /// </summary>
        /// <returns></returns>
        public DataTable BookShow(BookCategoryMod bookCategoryMod)
        {
            BookCategoryDal bookCategoryDal = new BookCategoryDal();
            DataTable dt = bookCategoryDal.FindBookParentID(bookCategoryMod);
            if(dt.Rows[0]["ParentID"].ToString() == "0")
            {
                return bookCategoryDal.FindBookInfo_Father(bookCategoryMod);
            }
            return bookCategoryDal.FindBookInfo_Son(bookCategoryMod);
        }
        /// <summary>
        /// 获取全部图书类别业务
        /// </summary>
        /// <returns></returns>
        public List<BookCategoryMod> GetAllBookType()
        {
            return bookCategoryDal.GetAllBookType();
        }
        /// <summary>
        /// 删除图书业务
        /// </summary>
        /// <returns></returns>
        public BookInfoEnums DelBookInfo(BookInfoMod bookInfoMod)
        {
            BookInfoDal bookInfoDal = new BookInfoDal();
            int result = bookInfoDal.DelBookInfo(bookInfoMod);
            // 判断是否删除成功
            if(result > 0)
            {
                return BookInfoEnums.DelBookInfoSuccess;
            }
            return BookInfoEnums.DelBookInfoError;
        }
        /// <summary>
        /// 修改图书信息业务
        /// </summary>
        /// <param name="bookInfoMod"></param>
        /// <returns></returns>
        public BookInfoEnums UpdateBookInfo(BookInfoMod bookInfoMod)
        {
            BookInfoDal bookInfoDal = new BookInfoDal();
            int result = bookInfoDal.UpdateBookInfo(bookInfoMod);
            // 判断修改图书是否成功
            if(result > 0)
            {
                return BookInfoEnums.UpdateBookInfoSuccess;
            }
            return BookInfoEnums.UpdateBookInfoError;
        }
    }
}
