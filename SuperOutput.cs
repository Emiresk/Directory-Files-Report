using System;

namespace DirectoryFiles
{
    public class SuperOutput
    {
        public void HelloMessage()
        {
            Console.WriteLine("Hello. Press button ENTER to start scan directory.");
            Console.ReadLine();
        }

        public void EndMessages( int t, int a, int i )
        {
            Console.WriteLine($"\n\n\nFinished. Total files: {t} | Added: {a} | Ignored: {i}");
        }

        public string Header()
        {
            return "#;File Name;Created;Last Modified";
        }

        public void Added ( string fileName, ref int i )
        {
            Console.WriteLine($"[+] Added new file ==> {fileName}");
            i++;
        }

        public void Ignored ( string fileName, ref int i )
        {
            Console.WriteLine($"[ ] Ignore by ignore list ==> {fileName}");
            i++;
        }
    }
}