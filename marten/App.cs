using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marten
{
    static class App
    {
        /// <summary>
        /// This string used in dockPanel layout xml file.
        /// </summary>
        internal const string PersistentStringSeparator = "::__::marten::__::";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
