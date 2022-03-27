using System.IO;

namespace DirectoryFiles
{
    public class SuperDirectory
    {
        public string ReportFile = "Report.csv";
        
        public string currentDirectory
        {
            get
            {
                return Directory.GetCurrentDirectory();
            }
            private set { }
        }

        public string[] filesInCurrentDirecoty
        {
            get
            {
                return Directory.GetFiles(currentDirectory);
            }

            private set { }
        }

        public int GetCountOfFilesInDirectory()
        {
            return filesInCurrentDirecoty.Length;
        }

        public string DirectorySeparator()
        {
            return Path.DirectorySeparatorChar.ToString();
        }

        public string ReportPath()
        {
            return currentDirectory + DirectorySeparator() + ReportFile;
        }
    }
}