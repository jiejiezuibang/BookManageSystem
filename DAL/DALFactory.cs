using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 数据访问层的简单工厂设计模式创建对象
    /// </summary>
    public class DALFactory
    {
        //static 内存被分配后，直到程序结束才会被释放...

        // 静态对象字段
        private static LoginDal _GetLoginDal;
        /// <summary>
        /// 只读，通过属性方式返回对象
        /// </summary>
        public static LoginDal GetLoginDal
        {
            get
            {
                if(_GetLoginDal == null)
                {
                    _GetLoginDal = new LoginDal();
                }
                return _GetLoginDal;
            }
        }
    }
}
