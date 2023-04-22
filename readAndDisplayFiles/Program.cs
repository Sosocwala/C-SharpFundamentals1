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
        public static void loadFile()
        {
            string textToAdd = "The big fat pig jumed over the gate";
            StreamWriter outFile = new StreamWriter("../../newfile.text");
            outFile.WriteLine(textToAdd);
           

        }
    }
}
