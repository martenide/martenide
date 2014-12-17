using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastColoredTextBoxNS;
using FastTreeNS;
using WeifenLuo.WinFormsUI.Docking;

namespace marten
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        internal List<EditorWindow> editorWindows;
        internal SolutionWindow solutionWindow;
        internal OutputWindow outputWindow;
        

        public MainForm()
        {
            // 4test
            App.solutionPath = @"e:\marten\test";
            // 
            instance = this;
            InitializeComponent();
            editorWindows = new List<EditorWindow>(10);
            solutionWindow = new SolutionWindow();
            outputWindow = new OutputWindow();
            deserializeDockContent = LoadLayoutHelper;
            CloseAllDockWindowsAndDocuments();
            if (!LoadLayout(App.configDir))
            {
                editorWindows.Add(new EditorWindow());
                editorWindows[0].Show(dockPanel);
                solutionWindow.Show(dockPanel,DockState.DockRight);
                outputWindow.Show(dockPanel,DockState.DockBottomAutoHide);
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
            SaveLayout();
        }




    }
}
