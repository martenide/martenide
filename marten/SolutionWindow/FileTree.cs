using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FastTreeNS;

namespace marten
{
    public class FileTree : FastTreeNS.FastTree
    {
        protected Int32 minNeededWidth;
        protected Int32 neededWidth;
        
        public new event EventHandler<PaintNodeContentEventArgs> PaintNode;
        public new event EventHandler<NodeExpandedStateChangedEventArgs> NodeExpandedStateChanged;

        public FileTree() : base()
        {
            minNeededWidth = Int32.MaxValue;
            SelectionColor = Color.FromArgb(51, 153, 255);
        }


        protected override void DrawItem(Graphics gr, VisibleItemInfo info)
        {
            #region Horizontal Autoscroll 
            // expand width if needed
            neededWidth = info.X_Text + (Int32)gr.MeasureString(info.Text, Font).Width + Padding.Right;
            if (minNeededWidth > neededWidth)
                minNeededWidth = neededWidth;
            if (Width < neededWidth)
                Width = neededWidth;
            #endregion
            if (PaintNode != null)
                PaintNode(this, new PaintNodeContentEventArgs { Graphics = gr, Info = info, Node = nodes[info.ItemIndex] });
            else
                base.DrawItemWhole(gr, info);
        }

        protected override void OnItemCollapsed(int itemIndex)
        {
            #region Horizontal Autoscroll
            // autoset minWidth
            if (minNeededWidth < Width)
                Width = minNeededWidth;
            #endregion

            if (NodeExpandedStateChanged != null)
                NodeExpandedStateChanged(this, new NodeExpandedStateChangedEventArgs { Node = nodes[itemIndex], Expanded = false });

            base.OnItemCollapsed(itemIndex);
        }

        public override void DrawSelection(Graphics gr, VisibleItemInfo info)
        {
            var rect = info.TextAndIconRect;
            if (FullItemSelect)
            {
                var cr = ClientRectMinusPaddings;
                rect = new Rectangle(cr.Left, rect.Top, cr.Width - 1, rect.Height);
            }
            if (rect.Width <= 0 || rect.Height <= 0) 
                return;
            using(var brush = new SolidBrush(SelectionColor))
            using (var pen = new Pen(SelectionColor))
            {
                gr.FillRectangle(brush, Rectangle.FromLTRB(rect.Left, rect.Top, rect.Right + 1, rect.Bottom + 1));
                gr.DrawRectangle(pen, rect);
            }
        }

    }
}
