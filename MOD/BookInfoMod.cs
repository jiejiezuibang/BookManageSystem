using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class BookInfoMod
    {
        // id
        private int iD;
        // 图书名称
        private string name;
        // 图书类别编号
        private int categoryType;
        // 图书作者
        private string author;
        // 图书价格
        private double money;
        // 图书编号
        private string bookID;
        // 图书状态
        private int state;
        // 图书信息构造函数
        public BookInfoMod()
        {

        }
        public int ID
        {
            set { iD = value; }
            get { return iD; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int CategoryType
        {
            set { categoryType = value; }
            get { return categoryType; }
        }
        public string Author
        {
            set { author = value; }
            get { return author; }
        }
        public double Money
        {
            set { money = value; }
            get { return money; }
        }
        public string BookID
        {
            set { bookID = value; }
            get { return bookID; }
        }
        public int State
        {
            set { state = value; }
            get { return state; }
        }
    }
}
