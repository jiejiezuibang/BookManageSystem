using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public class ReaderInfoMod
    {
        // id
        private int iD;
        public int ID
        {
            set { iD = value; }
            get { return iD; }
        }
        // 读者编号
        private string readerID;
        public string ReaderID
        {
            set { readerID = value; }
            get { return readerID; }
        }
        // 读者姓名
        private string readName;
        public string ReadName
        {
            set { readName = value; }
            get { return readName; }
        }
        // 读者邮箱
        private string eMail;
        public string EMail
        {
            set { eMail = value; }
            get { return eMail; }
        }
        // 读者住址
        private string address;
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        // 读者手机号码
        private string mobile;
        public string Mobile
        {
            set { mobile = value; }
            get { return mobile; }
        }
        // 读者信息构造函数
        public ReaderInfoMod()
        {

        }
    }
}
