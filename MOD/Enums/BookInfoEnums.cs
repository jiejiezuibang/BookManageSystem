using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD.Enums
{
    public enum BookInfoEnums
    {
        AddBookInfoSuccess,     // 添加图书成功
        AddBookInfoError,       // 添加图书失败
        DelBookInfoSuccess,     // 删除图书成功
        DelBookInfoError,       // 删除图书失败
        UpdateBookInfoSuccess,  // 修改图书成功
        UpdateBookInfoError,    // 修改图书失败
        BookInfoError,          // 操作失败
    }
}
