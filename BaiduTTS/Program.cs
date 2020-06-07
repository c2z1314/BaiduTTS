using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace BaiduTTS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //添加程序集解析事件

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            //... 启动应用窗体



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BeginRun();
            
        }
        static void BeginRun()
        {

            var _form1 = new Chooser();
            Application.Run(_form1);

        }

        //加载资源转为Assembly程序集
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
        {
            //项目的命名空间为myapp, 嵌入dll资源在libs文件夹下，所以这里用的命名空间为： myapp.libs.
            string _resName = "BaiduTTS.Resources." + new AssemblyName(e.Name).Name + ".dll";
            using (var _stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_resName))
            {
                byte[] _data = new byte[_stream.Length];
                _stream.Read(_data, 0, _data.Length);
                return Assembly.Load(_data);
            }
        }
    }
}
