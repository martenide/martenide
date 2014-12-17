using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marten
{
    public class FileNode : IEnumerable<FileNode>
    {
        public string path { get; private set; }
        public bool isDir { get; private set; }

        public FileNode(string path, bool isDir)
        {
            this.path = path;
            this.isDir = isDir;
        }

        public string name
        {
            get 
            { 
                var nodeName = Path.GetFileName(path);
                return string.IsNullOrEmpty(nodeName) ? path : nodeName;
            }
        }

        public bool HasChildren
        {
            get { return true; }
        }

        public IEnumerator<FileNode> GetEnumerator()
        {
            if (!isDir)
                yield break;
            var cachedConfigDir = App.configDir;
            foreach (var dir in Directory.EnumerateDirectories(path))
            {
                if (dir == cachedConfigDir)
                    continue;
                yield return new FileNode(dir, true);
            }
            foreach (var file in Directory.EnumerateFiles(path))
                yield return new FileNode(file, false);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Return view name of FileNode;
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
        /// <summary>
        /// Type Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return path.Equals((obj as FileNode).path);
        }
        /// <summary>
        /// Some optimize
        /// </summary>
        /// <returns>HashCode for collections</returns>
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
