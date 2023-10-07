using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FileIOOperations;

namespace FileIOOpertions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IOOperations.FileExists();
            //IOOperations.ReadAllLines();

            StreamReaderOperations.WriteUsingStreamWriter();
            StreamReaderOperations.ReadFromStreamReader();

        }
    }
}
