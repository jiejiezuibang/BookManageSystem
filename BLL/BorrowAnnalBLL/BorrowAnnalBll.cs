using DAL;
using MOD;
using MOD.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BorrowAnnalBLL
{
    public class BorrowAnnalBll
    {
        BorrowAnnalDal borrowAnnalDal = new BorrowAnnalDal();
        /// <summary>
        /// 获取全部借还记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetBorrowAnnalInfo()
        {
            DataTable dt = borrowAnnalDal.GetBorrowAnnalInfo();
            return dt;
        }
        /// <summary>
        /// 查询读者借书还书业务
        /// </summary>
        /// <param name="borrowAnnalMod"></param>
        /// <returns></returns>
        public DataTable FindBorrowAnnalInfo(BorrowAnnalMod borrowAnnalMod)
        {
            DataTable dt = borrowAnnalDal.FindBorrowAnnalInfo(borrowAnnalMod);
            return dt;
        }
    }
}
