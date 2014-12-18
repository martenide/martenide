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
            this.fileTree = new marten.FileTree();
            this.SuspendLayout();
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fileTree.AutoScroll = true;
            this.fileTree.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.fileTree.AutoScrollMinSize = new System.Drawing.Size(20, 59);
            this.fileTree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileTree.BackColor = System.Drawing.SystemColors.Window;
            this.fileTree.ImageCheckBoxOff = ((System.Drawing.Image)(resources.GetObject("fileTree.ImageCheckBoxOff")));
            this.fileTree.ImageCheckBoxOn = ((System.Drawing.Image)(resources.GetObject("fileTree.ImageCheckBoxOn")));
            this.fileTree.ImageCollapse = ((System.Drawing.Image)(resources.GetObject("fileTree.ImageCollapse")));
            this.fileTree.ImageDefaultIcon = ((System.Drawing.Image)(resources.GetObject("fileTree.ImageDefaultIcon")));
            this.fileTree.ImageExpand = ((System.Drawing.Image)(resources.GetObject("fileTree.ImageExpand")));
            this.fileTree.IsEditMode = false;
            this.fileTree.Location = new System.Drawing.Point(0, 0);
            this.fileTree.MinimumSize = new System.Drawing.Size(30, 30);
            this.fileTree.Name = "fileTree";
            this.fileTree.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.fileTree.ShowExpandBoxes = true;
            this.fileTree.ShowIcons = true;
            this.fileTree.Size = new System.Drawing.Size(115, 605);
            this.fileTree.TabIndex = 0;
            this.fileTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileTree_MouseDoubleClick);
            // 
            // SolutionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(252, 606);
            this.Controls.Add(this.fileTree);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SolutionWindow";
            this.Text = "Solution";
            this.ResumeLayout(false);

        }

        #endregion

        internal FileTree fileTree;


    }
}