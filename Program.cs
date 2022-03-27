using System;
using System.IO;
using System.Linq;

namespace DirectoryFiles
{
    class Program
    {
        private static SuperDirectory _sd = new SuperDirectory();
        private static SuperOutput _so = new SuperOutput();

        private static int _Total = 0;
        private static int _Added = 0;
        private static int _Ignor = 0;

        private static string[] _ignored = 
        {
            "DirectoryFiles", "Report"
        };
        
        static void Main()
        {
            _so.HelloMessage();

            StreamWriter Sw = new StreamWriter(_sd.ReportPath());
            
            Sw.WriteLine( _so.Header() );

            _Total = _sd.GetCountOfFilesInDirectory();

            foreach ( string fileName in _sd.filesInCurrentDirecoty )
            {
                SuperTarget Star = new SuperTarget(fileName);

                if ( _ignored.Contains( Star.GetFileName()) == false )
                {
                    Sw.WriteLine( $"1;{Star.GetFileName()};{Star.GetCreationTime()};{Star.GetLastModifyTime()}" );
                    
                    _so.Added( Star.GetFileName(), ref _Added );
                    
                    continue;
                }
                
                _so.Ignored( Star.GetFileName(), ref _Ignor );
            }
            
            Sw.Close();
            
            _so.EndMessages(_Total,_Added, _Ignor);
        }
    }
}