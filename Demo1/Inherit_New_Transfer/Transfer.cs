using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_New_Transfer
{
    /// <summary>
    /// 转来后
    /// 1.在Inherit_New_Transfer项目的引用中——添加引用——浏览——将之前的Inherit_New.dll文件选中——打开
    /// 2.此时，之前生成的类库文件Inherit_New.dll 被成功引用
    /// </summary>
    class Transfer : Inherit_New.ClassUtil
    {
        public new void ShowClassMessage() //ShowClassMessage在Inherit_New中已经存在
                                           //所以这里的ShowClassMessage要在类型前面加new
        {
            Console.WriteLine("Transfer 的类");
        }
    }
}
