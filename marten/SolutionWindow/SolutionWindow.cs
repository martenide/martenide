using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastTreeNS;
using WeifenLuo.WinFormsUI.Docking;

namespace marten
{
    public partial class SolutionWindow : DockContent
    {
        public SolutionWindow()
        {
            InitializeComponent();
            // Check closing mainform
            if (MainForm.instance == null)
            {
                Close();
                return;
            }
            fileTree.Build(new FileNode(App.solutionPath, true).ToList());
            Width = 150;
            fileTree.Width = this.Width;
        }

        private void fileTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fileTree.Nodes == null || !fileTree.Nodes.Any() || !fileTree.SelectedItemIndex.Any())
                return;
            FileNode node = fileTree.Nodes.ElementAt(fileTree.SelectedItemIndex.First()) as FileNode;
            if (node == null || node.isDir 
                || MainForm.instance == null || MainForm.instance.dockPanel == null
                || MainForm.instance.editorWindows == null )
                return;
            var newEditor = new EditorWindow { filepath = node.path, Text = node.name};
            newEditor.Show(MainForm.instance.dockPanel);
            MainForm.instance.editorWindows.Add(newEditor);
            newEditor.OpenFile();
        }



     

        
    }
}