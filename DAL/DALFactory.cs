using DAL.BookDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 数据访问层的简单工厂设计模式创建对象
    /// </summary>
    public class DALFactory
    {
        //static 内存被分配后，直到程序结束才会被释放...

        // 静态对象字段
        private static LoginDal _GetLoginDal;
        /// <summary>
        /// 只读，通过属性方式返回对象
        /// </summary>
        public static LoginDal GetLoginDal
        {
            get
            {
                if(_GetLoginDal == null)
                {
                    _GetLoginDal = new LoginDal();
                }
                return _GetLoginDal;
            }
        }
        // 静态对象字段
        private static RanderManageDal _ReaderManageDal;
        /// <summary>
        /// 只读，通过属性方式返回对象
        /// </summary>
        public static RanderManageDal GetRanderManageDal
        {
            get
            {
                if(_ReaderManageDal == null)
                {
                    _ReaderManageDal = new RanderManageDal();
                }
                return _ReaderManageDal;
            }
        }
        // 存储操作图书类别信息对象
        private static BookCategoryDal bookCategoryDal;
        public static BookCategoryDal GetBookCategoryDal
        {
            get
            {
                if(bookCategoryDal == null)
                {
                    bookCategoryDal = new BookCategoryDal();
                }
                return bookCategoryDal;
            }
        }
        // 存储操作图书信息对象
        private static BookInfoDal bookInfoDal;
        public static BookInfoDal GetBookInfoDal
        {
            get
            {
                if(bookInfoDal == null)
                {
                    bookInfoDal = new BookInfoDal();
                }
                return bookInfoDal;
            }
        }
    }
}
