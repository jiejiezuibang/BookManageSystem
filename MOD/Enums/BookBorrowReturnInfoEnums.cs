using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD.Enums
{
    public enum BookBorrowReturnInfoEnums
    {
        BookBorrowSuccess,      // 借书成功
        BookBorrowError,        // 借书失败
        BookReturnSuccess,      // 还书成功
        BookReturnError,        // 还书失败
        BookBorrowReturnInfoError, //发生错误
    }
}
