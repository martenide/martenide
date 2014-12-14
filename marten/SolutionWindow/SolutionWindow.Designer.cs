namespace marten
{
    partial class SolutionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionWindow));
            this.tree = new FastTreeNS.FastTree();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.AutoScroll = true;
            this.tree.AutoScrollMinSize = new System.Drawing.Size(0, 59);
            this.tree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tree.BackColor = System.Drawing.SystemColors.Window;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.ImageCheckBoxOff = ((System.Drawing.Image)(resources.GetObject("tree.ImageCheckBoxOff")));
            this.tree.ImageCheckBoxOn = ((System.Drawing.Image)(resources.GetObject("tree.ImageCheckBoxOn")));
            this.tree.ImageCollapse = ((System.Drawing.Image)(resources.GetObject("tree.ImageCollapse")));
            this.tree.ImageDefaultIcon = ((System.Drawing.Image)(resources.GetObject("tree.ImageDefaultIcon")));
            this.tree.ImageExpand = ((System.Drawing.Image)(resources.GetObject("tree.ImageExpand")));
            this.tree.IsEditMode = false;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.ShowExpandBoxes = true;
            this.tree.ShowIcons = true;
            this.tree.Size = new System.Drawing.Size(284, 261);
            this.tree.TabIndex = 0;
            // 
            // SolutionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tree);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SolutionWindow";
            this.Text = "Solution";
            this.ResumeLayout(false);

        }

        #endregion

        internal FastTreeNS.FastTree tree;

    }
}