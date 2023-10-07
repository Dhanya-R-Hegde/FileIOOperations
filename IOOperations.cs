using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public static class IOOperations
    {
        public static void FileExists()
        {
            String path = @"C:/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIO.txt";

            if(File.Exists(path)) 
            {
                Console.WriteLine("File exists");
            }
            
            Console.ReadKey();
        }

        public static void ReadAllLines()
        {
            String path = @"C:/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIO.txt";

            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            //foreach(String line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            Console.ReadKey();
        }

        public static void ReadAllText()
        {
            String path = @"/c/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIO.txt";

            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

            Console.ReadKey();
        }

        public static void FileCopy()
        {
            String path = @"/c/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIO.txt";

            String copypath = @"/c/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIONew.txt";

            File.Copy(path, copypath);

            Console.ReadKey();
        }

        public static void DeleteFile()
        {
            string path = @"/c/Users/DHANYA R HEGDE/Desktop/dotNetBridgeLabs/FileIOOperations/FileIONew.txt";

            File.Delete(path);

            Console.ReadKey();
        }
    }
}
