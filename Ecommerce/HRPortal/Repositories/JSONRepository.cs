using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace HRPortal.Repositories
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


            string jsonData = File.ReadAllText(filename);
            List<T> items = JsonConvert.DeserializeObject<List<T>>(jsonData);

            return items;
        }
    }
}