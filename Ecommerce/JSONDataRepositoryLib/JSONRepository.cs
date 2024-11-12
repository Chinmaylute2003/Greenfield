using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Specification;
using System.Text.Json;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace JSONDataRepositoryLib
{
    public class JSONRepository<T> : IDataRepository<T>
    {
        public bool Serialize(string filename, List<T> items)
        {
            
            string jsonData = JsonConvert.SerializeObject(items);
            File.WriteAllText(filename, jsonData);
            return true;

        }

        public List<T> Deserialize(string filename)
        {
            List<T> items = null;
           
            string jsonData = File.ReadAllText(filename);
            items = JsonConvert.DeserializeObject<List<T>>(jsonData);
       
            return items;
        }
    }
}
