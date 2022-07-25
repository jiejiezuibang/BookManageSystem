using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MOD;

namespace DAL
{
    public class RanderManageDal
    {
        SqlHelp sqlHelp = new SqlHelp();
        /// <summary>
        /// 获取全部读者信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetReaderInfo()
        {
            string sql = "select ID,ReaderID 读者编号,ReadName 读者姓名,EMail 读者邮箱,Address 读者地址,Mobile 读者手机号码 from ReaderInfo";
            DataTable dt = sqlHelp.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 添加读者信息
        /// </summary>
        /// <returns></returns>
        public int AddReader(ReaderInfoMod readerInfoMod)
        {
            // 添加读者信息的sql语句
            string sql = "insert into ReaderInfo values(@ReaderID,@ReadName,@Email,@Address,@Mobile)";
            // 防止SQL注入攻击
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@ReaderID",readerInfoMod.ReaderID),
                new SqlParameter("@ReadName",readerInfoMod.ReadName),
                new SqlParameter("@Email",readerInfoMod.EMail),
                new SqlParameter("@Address",readerInfoMod.Address),
                new SqlParameter("@Mobile",readerInfoMod.Mobile)
            };
            int result = sqlHelp.SqlOperate(sql, sqlpars);
            return result;
        }
        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public int UpdateReader(ReaderInfoMod readerInfoMod)
        {
            string sql = @"update ReaderInfo set ReaderID=@ReaderID,ReadName=@ReadName,
EMail=@EMail,Address=@Address,Mobile=@Mobile where ReaderID=@ReaderID";
            SqlParameter[] sqlpars =
            {
                new SqlParameter("@ID",readerInfoMod.ID),
                new SqlParameter("@ReadName",readerInfoMod.ReadName),
                new SqlParameter("@ReaderID",readerInfoMod.ReaderID),
                new SqlParameter("@EMail",readerInfoMod.EMail),
                new SqlParameter("@Address",readerInfoMod.Address),
                new SqlParameter("@Mobile",readerInfoMod.Mobile)
            };
            int result = sqlHelp.SqlOperate(sql, sqlpars);
            return result;
        }
        /// <summary>
        /// 删除读者信息
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public int DelReader(ReaderInfoMod readerInfoMod)
        {
            string sql = "delete from ReaderInfo where ID=@ID";
            SqlParameter[] sqlpar =
            {
                new SqlParameter("@ID",readerInfoMod.ID),
            };
            int result = sqlHelp.SqlOperate(sql, sqlpar);
            return result;
        }
        /// <summary>
        /// 查询读者信息
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public DataTable FindReader(ReaderInfoMod readerInfoMod)
        {
            string sql = "select ID,ReaderID 读者编号,ReadName 读者姓名,EMail 读者邮箱,Address 读者地址,Mobile 读者手机号码 from ReaderInfo where ReaderID like '%'+ @ReaderID + '%'";
            SqlParameter[] sqlpar =
            {
                new SqlParameter("@ReaderID",readerInfoMod.ReaderID),
            };
            DataTable dt = sqlHelp.GetDataTable(sql, sqlpar);
            return dt;
        }
    }
}
