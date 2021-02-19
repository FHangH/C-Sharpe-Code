using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_New
{
    public class ClassUtil
    {
        /// <summary>
        /// 该类库将作为第三方类库，被Inherit_New_Transfer引用
        /// 
        /// 生成方法：
        ///     1.在解决方案中，添加一个项目——类库（Net.Framwork）——添加一个类文件
        ///     2.鼠标右击该项目，选择——生成
        ///     3.再次右击，选择）——在文件资源管理器中打开文件夹——bin——Debug—— .dll 文件
        ///     4. .dll 文件为新生成可引用的类库文件
        ///     5.在解决方案中，添加一个项目——控制台（Net.Framwork）——添加一个类文件
        ///     现在转到 项目Inherit_New_Transfer中看操作步骤
        /// </summary>
        public void ShowClassMessage()
        {
            Console.WriteLine("这是一个类库");
        }
    }
}
