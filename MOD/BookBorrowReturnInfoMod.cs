using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class BookBorrowReturnInfoMod
    {
        /// <summary>
        /// id
        /// </summary>
        private int iD;
        public int ID
        {
            set { iD = value; }
            get { return iD; }
        }
        /// <summary>
        /// 图书编号
        /// </summary>
        private string bookID;
        public string BookID
        {
            set { bookID = value; }
            get { return bookID; }
        }
        /// <summary>
        /// 图书编号
        /// </summary>
        private string readerID;
        public string ReaderID
        {
            set { readerID = value; }
            get { return readerID; }
        }
        /// <summary>
        /// 借书时间
        /// </summary>
        private DateTime borrowTime;
        public DateTime BorrowTime
        {
            set { borrowTime = value; }
            get { return borrowTime; }
        }
        /// <summary>
        /// 还书时间
        /// </summary>
        private DateTime returnTime;
        public DateTime ReturnTime
        {
            set { returnTime = value; }
            get { return returnTime; }
        }
        /// <summary>
        ///  借还书记录模型构造函数
        /// </summary>
        public BookBorrowReturnInfoMod()
        {

        }
    }
}
