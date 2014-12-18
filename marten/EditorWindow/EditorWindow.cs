using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;


namespace marten
{
    public partial class EditorWindow : DockContent
    {
        /// <summary>
        /// Filepath opened in editor
        /// </summary>
        public string filepath;

        public EditorWindow()
        {
            InitializeComponent();
        }


        public bool OpenFile()
        {
            if (!File.Exists(filepath))
                return false;
            codeEditor.OpenFile(filepath);
            return true;
        }

        /// <summary>
        /// Used for save docking layout with some settings.
        /// </summary>
        /// <returns></returns>
        protected override string GetPersistString()
        {
            // ToDo: maybe replace separateFile with settings?
            // Add extra information into the persist string for this document
            // so that it is available when deserialized docking solution layout.
            return String.Concat(GetType().ToString(), App.PersistentStringSeparator, filepath);
        }

    }
}
