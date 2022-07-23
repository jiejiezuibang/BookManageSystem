using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class BookCategoryMod
    {
        // ID
        private int iD;
        public int ID
        {
            set { iD = value; }
            get { return iD; }
        }
        // 类别编号
        private int categoryID;
        public int CategoryID
        {
            set{ categoryID = value; }
            get { return categoryID; }
        }
        // 类型名称
        private string categoryName;
        public string CategoryName
        {
            set { categoryName = value; }
            get { return categoryName; }
        }
        // 父类ID
        private int parentID;
        public int ParentID
        {
            set { parentID = value; }
            get { return parentID; }
        }
        // BookCategoryMod模型的构造函数
        public BookCategoryMod()
        {

        }
    }
}
