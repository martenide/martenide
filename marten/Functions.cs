using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace marten
{
    [System.ComponentModel.DesignerCategory("code")]
    public partial class MainForm
    {
        /// <summary>
        /// For loading dock settings
        /// </summary>
        private readonly DeserializeDockContent deserializeDockContent;

        

        void SaveLayout()
        {
            try
            {
                if (!Directory.Exists(App.configDir))
                    Directory.CreateDirectory(App.configDir);
                dockPanel.SaveAsXml(Path.Combine(App.configDir, @"layoutDockPanel.xml"));
            }
            catch (Exception e)
            {
                // ToDo: implement error logging NLog
                MessageBox.Show(e.ToString());
                throw;
            }
        }




        private bool LoadLayout(string configDir)
        {
            bool result;
            try
            {
                dockPanel.SuspendLayout(true);
                string configFile = Path.Combine(configDir, @"layoutDockPanel.xml");
                if (!Directory.Exists(configDir) || !File.Exists(configFile))
                {
                    result = false;
                }
                else
                {
                    dockPanel.LoadFromXml(configFile, deserializeDockContent);
                    result = true;
                }
            }
            catch (Exception e)
            {
                // ToDo: implement error logging NLog
                MessageBox.Show(e.ToString());
                result = false;
            }
            finally
            {
                dockPanel.ResumeLayout(true, true);    
            }
            return result;
            
        }
        private IDockContent LoadLayoutHelper(string persistString)
        {
            if (persistString == typeof(SolutionWindow).ToString())
                return solutionWindow;
            if (persistString == typeof(OutputWindow).ToString())
                return outputWindow;
            else
            {
                // EditorWindow overrides GetPersistString to add extra information into persistString.
                string[] parsedStrings = persistString.Split(new[] { App.PersistentStringSeparator },StringSplitOptions.None);
                if (parsedStrings.Length != 2)
                    return null;

                if (parsedStrings[0] != typeof(EditorWindow).ToString())
                    return null;
                var savedEditor = new EditorWindow();
                if(!String.IsNullOrWhiteSpace(parsedStrings[1]))
                    savedEditor.filepath = parsedStrings[1];
                if(editorWindows != null)
                    editorWindows.Add(savedEditor);
                return savedEditor;
            }
        }
        /// <summary>
        /// Used for closing all dock/document windows
        /// </summary>
        private void CloseAllDockWindowsAndDocuments()
        {
            // we don't want to create another instance of tool window, set DockPanel to null
            solutionWindow.DockPanel = null;
            // Close all other document windows
            CloseAllDocuments();
        }
        /// <summary>
        /// Close all documents 
        /// </summary>
        private void CloseAllDocuments()
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    document.DockHandler.Close();
                }
            }
        }
    }
}
