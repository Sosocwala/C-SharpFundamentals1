using System;
using System.Text;
using System.IO;

namespace createFileWriteData
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToAdd = "";
            StreamReader outfile = new StreamReader("../../NewFile.text");
            outfile.WriteLine(textToAdd);
            outfile.Close;
            
        }
    }
}
