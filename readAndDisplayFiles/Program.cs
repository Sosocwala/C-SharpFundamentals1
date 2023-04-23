using System;
using System.IO;

namespace readAndDisplayFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            loadFile();
        }
        
        private static void loadFile()
        {
            StreamReader inFile = null;
            inFile = File.OpenText("../../info.text"); 
            Console.WriteLine(inFile.ReadToEnd());  
        }
    }
}
