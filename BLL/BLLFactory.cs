using BLL.LoginBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 业务逻辑层的简单工厂设计模式创建对象
    /// </summary>
    public class BLLFactory
    {
        // static 内存被分配后，直到程序结束才会释放。。。

        // 静态对象字段
        private static LoginBll _GetLoginBll;
        public LoginBll GetLoginBll
        {
            get
            {
                if(_GetLoginBll == null)
                {
                    _GetLoginBll = new LoginBll();
                }
                return _GetLoginBll;
            }
        }
    }
}
