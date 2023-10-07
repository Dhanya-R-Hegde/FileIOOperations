using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public static class StreamReaderOperations
    {
        public static void ReadFromStreamReader()
        {
            String path = @"C:/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIO.txt"; 

            using(StreamReader sr = File.OpenText(path))
            {
                String s = "";

                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey(); 
        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"C:/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIO.txt";

            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("\nHello World - .Net is awesome");
                sw.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey(); 
        }
    }
}
