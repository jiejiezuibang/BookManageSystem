using DAL.ReaderManageDal;
using MOD;
using MOD.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ReaderMangeBLL
{
    public class ReaderMangeBll
    {
        RanderManageDal randerManageDal = new RanderManageDal();
        /// <summary>
        /// 获取读者信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetReaderInfo()
        {
            DataTable dt = randerManageDal.GetReaderInfo();
            return dt;
        }
        /// <summary>
        /// 添加读者信息业务
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public ReaderInfoEnums AddReaderInfo(ReaderInfoMod readerInfoMod)
        {
            // 执行添加操作
            int result = randerManageDal.AddReader(readerInfoMod);
            if (result > 0)
            {
                return ReaderInfoEnums.AddSuccess;
            }
            return ReaderInfoEnums.AddSuccess;
        }
        /// <summary>
        /// 修改学生信息业务
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public ReaderInfoEnums UpdateReaderInfo(ReaderInfoMod readerInfoMod)
        {
            // 执行修改操作
            int result = randerManageDal.UpdateReader(readerInfoMod);
            if(result > 0)
            {
                return ReaderInfoEnums.UpdateSuccess;
            }
            return ReaderInfoEnums.UpdateError;
        }
        /// <summary>
        /// 删除读者信息业务
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public ReaderInfoEnums DelReaderInfo(ReaderInfoMod readerInfoMod)
        {
            int result = randerManageDal.DelReader(readerInfoMod);
            if (result > 0)
            {
                return ReaderInfoEnums.DelSucess;
            }
            return ReaderInfoEnums.DelError;
        }
        /// <summary>
        /// 查询读者信息业务
        /// </summary>
        /// <param name="readerInfoMod"></param>
        /// <returns></returns>
        public DataTable FindReaderInfo(ReaderInfoMod readerInfoMod)
        {
            DataTable dt = randerManageDal.FindReader(readerInfoMod);
            return dt;
        }
    }
}
