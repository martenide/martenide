using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        private int cachedNeedWidth = 0;
        private int minCachedNeedWidth = 0;
        public SolutionWindow()
        {
            InitializeComponent();
            // Check closing mainform
            if (MainForm.instance == null)
            {
                Close();
                return;
            }
            tree.Build(new FileNode(App.solutionPath, true).ToList());
            tree.PaintNode += tree_PaintNode;
            tree.NodeExpandedStateChanged += tree_NodeExpandedStateChanged;
            tree.Width = this.Width;
            minCachedNeedWidth = Int32.MaxValue;
        }

        void tree_NodeExpandedStateChanged(object sender, NodeExpandedStateChangedEventArgs e)
        {
            if (minCachedNeedWidth < tree.Width)
            {
                tree.Width = minCachedNeedWidth;
            }
        }
        
        void tree_PaintNode(object sender, FastTreeNS.PaintNodeContentEventArgs e)
        {
            cachedNeedWidth = e.Info.X_Text + (int)e.Graphics.MeasureString(e.Info.Text, tree.Font).Width+5;
            if (minCachedNeedWidth > cachedNeedWidth)
            {
                minCachedNeedWidth = cachedNeedWidth;
            }
            if (tree.Width < cachedNeedWidth)
            {
                tree.Width = cachedNeedWidth;
            }
            tree.DrawItemWhole(e.Graphics,e.Info);
        }

        
    }
}