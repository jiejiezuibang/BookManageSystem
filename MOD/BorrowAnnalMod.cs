using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class BorrowAnnalMod
    {
        // 图书编号
        private string bookID;
        public string BookID
        {
            set { bookID = value; }
            get { return bookID; }
        }
        // 读者编号
        private string readerID;
        public string ReaderID
        {
            set { readerID = value; }
            get { return readerID; }
        }
        // 借书时间
        private DateTime borrowTime;
        public DateTime BorrowTime
        {
            set { borrowTime = value; }
            get { return borrowTime; }
        }
        // 还书时间
        private DateTime returnTime;
        public DateTime ReturnTime
        {
            set { returnTime = value; }
            get { return returnTime; }
        }
    }
}
