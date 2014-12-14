using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastColoredTextBoxNS;
using FastTreeNS;
using WeifenLuo.WinFormsUI.Docking;

namespace marten
{
    public partial class MainForm : Form
    {
        internal List<EditorWindow> editorWindows;
        internal SolutionWindow solutionWindow;

        public MainForm()
        {
            InitializeComponent();
            editorWindows = new List<EditorWindow>(10);
            solutionWindow = new SolutionWindow();
            deserializeDockContent = LoadLayoutHelper;
            CloseAllDockWindowsAndDocuments();
            if (!LoadLayout(GetConfigDir()))
            {
                editorWindows.Add(new EditorWindow());
                editorWindows[0].Show(dockPanel);
                solutionWindow.Show(dockPanel);
            }
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLayout();
        }




    }
}
