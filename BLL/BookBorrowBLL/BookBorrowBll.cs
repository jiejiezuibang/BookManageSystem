using DAL;
using DAL.BookBorrowDal;
using MOD;
using MOD.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BookBorrowBLL
{
    public class BookBorrowBll
    {
        /// <summary>
        /// 查询该读者是否存在
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public DataTable FindRederInfo(ReaderInfoMod readerInfoMod)
        {
            RanderManageDal randerManageDal = DALFactory.GetRanderManageDal;
            DataTable dt = randerManageDal.FindReader(readerInfoMod);
            return dt;
        }
        /// <summary>
        /// 查询读者借还书记录
        /// </summary>
        /// <param name="bookBorrowReturnInfo"></param>
        /// <returns></returns>
        public DataTable FindBookBorrowInfo(BookBorrowReturnInfoMod bookBorrowReturnInfo)
        {
            BookBorrowDal bookBorrowDal = new BookBorrowDal();
            DataTable dt = bookBorrowDal.GetReaderBookBorrow(bookBorrowReturnInfo);
            return dt;
        }
        /// <summary>
        /// 查询读者没还图书记录
        /// </summary>
        /// <returns></returns>
        public DataTable FindBorrowBookNotReturnInfo(BookBorrowReturnInfoMod bookBorrowReturnInfoMod)
        {
            BookBorrowDal bookBorrowDal = new BookBorrowDal();
            DataTable dt = bookBorrowDal.FindBorrowBookNotReturn(bookBorrowReturnInfoMod);
            return dt;
        }
        /// <summary>
        /// 借书业务
        /// </summary>
        /// <param name="bookBorrowReturnInfoMod"></param>
        /// <returns></returns>
        public BookBorrowReturnInfoEnums BookBorrow(BookBorrowReturnInfoMod bookBorrowReturnInfoMod)
        {
            BookBorrowDal bookBorrowDal = new BookBorrowDal();
            bool result = bookBorrowDal.BorrowBook(bookBorrowReturnInfoMod);
            // 判断借书是否成功
            if (result)
            {
                return BookBorrowReturnInfoEnums.BookBorrowSuccess;
            }
            return BookBorrowReturnInfoEnums.BookBorrowError;
        }
        /// <summary>
        /// 还书业务
        /// </summary>
        /// <param name="bookBorrowReturnInfoMod"></param>
        /// <returns></returns>
        public BookBorrowReturnInfoEnums BookReturn(BookBorrowReturnInfoMod bookBorrowReturnInfoMod)
        {
            BookBorrowDal bookBorrowDal = new BookBorrowDal();
            bool result = bookBorrowDal.ReturnBook(bookBorrowReturnInfoMod);
            // 判断还书是否成功
            if (result)
            {
                return BookBorrowReturnInfoEnums.BookReturnSuccess;
            }
            return BookBorrowReturnInfoEnums.BookReturnError;
        }
    }
}
