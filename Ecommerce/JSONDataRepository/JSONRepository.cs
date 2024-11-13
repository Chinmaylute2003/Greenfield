using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Specification;
using System.Text.Json;

namespace JSONDataRepository
{
    public class JSONRepository<T> : IDataRepository<T>
    {
        public bool Serialize(string filename, List<T> items)
        {
            bool status = false;
            
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            JsonSerializer.Serialize<List<T>>(fs, items);
            fs.Close();
            status = true;
            return status;

        }

        public List<T> Deserialize(string filename)
        {
            List<T> items = null;
          
            FileStream fs = new FileStream(filename, FileMode.Open);
            if (fs != null)
            {
                items = (List<T>)JsonSerializer.Deserialize<List<T>>(fs);
            }
            fs.Close();
            return items;
        }
    }
}
