using System;
using System.Collections.Generic;
using System.IO;
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
        /// private path to solution
        /// </summary>
        private static string _solutionPath;
        /// <summary>
        /// Solution path, with reloading config
        /// </summary>
        public static string solutionPath
        {
            get { return _solutionPath; }
            set
            {
                // ToDo: implement reload settings
                _solutionPath = value;
            }
        }
        /// <summary>
        /// Configuration dir for opened solution
        /// </summary>
        public static string configDir
        {
            get { return Path.Combine(_solutionPath, @".marten"); }
        }

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
