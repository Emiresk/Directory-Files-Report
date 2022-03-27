using System;
using System.IO;

namespace DirectoryFiles
{
    public class SuperTarget
    {
        private string path;

        private string name;

        private string ext;
        
        public SuperTarget ( string _Path )
        {
            _initClass( _Path );
        }

        private void _initClass(string s)
        {
            this.path = s;

            string[] file = s
                .Replace(new SuperDirectory().currentDirectory, String.Empty)
                .Replace(new SuperDirectory().DirectorySeparator(), String.Empty)
                .Split(".");

            this.name = file[0];

            this.ext = file[ file.Length - 1 ];
        }
        
        public string GetFileName()
        {
            return this.name;
        }

        public string GetExtension()
        {
            return this.ext;
        }

        public string GetCreationTime()
        {
            return File.GetCreationTime( path ).ToString();
        }
        
        public string GetLastModifyTime()
        {
            return File.GetLastWriteTime( path ).ToString();
        }
    }
}