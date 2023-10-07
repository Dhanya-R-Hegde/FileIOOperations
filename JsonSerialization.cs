using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Json.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FileIOOperations
{
    internal class JsonSerialization
    {
        public void jsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Dhanya",
                Description = "Welcome"
            };
            string jsonData = JsonConverter.SerializeObject(bsObj);

            Console.WriteLine(jsonData);
        }

        public void jsonDeserialize()
        {
            string json = @"{
                'Name' : 'Dhanya',
                'Description' : 'Welcome'
            }";
            BlogSites bsObj = JsonConverter.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
        }
    }

    [DataContract]
    class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
