using BLL.BookInfoBLL;
using BLL.LoginBLL;
using BLL.ReaderMangeBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 业务逻辑层的简单工厂设计模式创建对象
    /// </summary>
    public class BLLFactory
    {
        // static 内存被分配后，直到程序结束才会释放。。。

        // 静态对象字段
        private static LoginBll _GetLoginBll;
        /// <summary>
        /// 只读
        /// </summary>
        public LoginBll GetLoginBll
        {
            get
            {
                if(_GetLoginBll == null)
                {
                    _GetLoginBll = new LoginBll();
                }
                return _GetLoginBll;
            }
        }
        // 存储读者信息业务对象
        private static ReaderMangeBll readerMangeBll;
        public static ReaderMangeBll GetReaderMangeB
        {
            get
            {
                if(readerMangeBll == null)
                {
                    readerMangeBll = new ReaderMangeBll();
                }
                return readerMangeBll;
            }
        }
        // 存储图书信息业务对象
        private static BookInfoBll bookInfoBll;
        public static BookInfoBll GetBookInfoBll
        {
            get
            {
                if(bookInfoBll == null)
                {
                    bookInfoBll = new BookInfoBll();
                }
                return bookInfoBll;
            }
        }
    }
}
