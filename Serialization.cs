using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public static class Serialization
    {
        public static void serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }

        public static void deSerialization()
        {
            FileStream fileStream = new FileStream(@"", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserialisedSampleDemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName {deserialisedSampleDemo.ApplicationName} --- ApplicationId{deserialisedSampleDemo.ApplicationId}");
            Console.ReadKey();
        }
    }


    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";

        public int ApplicationId { get; set; } = 1001;
    }
}
