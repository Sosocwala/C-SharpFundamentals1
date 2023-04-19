﻿using System;
using System.IO;

namespace TryCatchFinallyStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            loadFile();
        }
        private static void loadFile()
        {
            StreamReader infile = null;
            try
            {
                infile = File.OpenText("../../info.text");
                Console.WriteLine(infile.ReadToEnd);
            }
            catch (FileNotFoundException notFound)
            {
                Console.WriteLine("Oops! {0}", notFound.Message);
            }
        }
    }
}