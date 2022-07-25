using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD.Enums
{
    public enum LoginStateEnms
    {
        Ok,                 // 成功登录
        LoginIDError,       // 账号错误
        LoginPwdError,      // 密码错误
        LoginError,         // 登录发生异常
    }
}
