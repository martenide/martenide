namespace marten
{
    partial class EditorWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWindow));
            this.codeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.codeEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // codeEditor
            // 
            this.codeEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeEditor.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.codeEditor.BackBrush = null;
            this.codeEditor.CharHeight = 14;
            this.codeEditor.CharWidth = 8;
            this.codeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.codeEditor.IsReplaceMode = false;
            this.codeEditor.Location = new System.Drawing.Point(0, 0);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.codeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeEditor.ServiceColors")));
            this.codeEditor.Size = new System.Drawing.Size(370, 293);
            this.codeEditor.TabIndex = 0;
            this.codeEditor.Text = "fastColoredTextBox1";
            this.codeEditor.Zoom = 100;
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(370, 293);
            this.Controls.Add(this.codeEditor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EditorWindow";
            this.Text = "EditorWindow";
            ((System.ComponentModel.ISupportInitialize)(this.codeEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox codeEditor;
    }
}