using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD
{
    public partial class LoginMod
    {
        #region 字段
        //ID
        private int _Id;
        //管理员编号 
        private string _adminID;
        //管理员密码
        private string _adminPWD;
        #endregion

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public LoginMod()
        {

        }
        /// <summary>
        /// 重载的构造函数
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="adminID"></param>
        /// <param name="adminPWD"></param>
        public LoginMod(int Id, string adminID, string adminPWD)
        {
            ID = Id;
            AdminID = adminID;
            AdminPWD = adminPWD;
        }
        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            set { _Id = value; }
            get { return _Id; }
        }
        /// <summary>
        /// 管理员编号 
        /// </summary>
        public string AdminID
        {
            set { _adminID = value; }
            get { return _adminID; }
        }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPWD
        {
            set { _adminPWD = value; }
            get { return _adminPWD; }
        }
    }
}
