using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Specification;
using POCO;
using System.IO;
namespace BinaryDataRepositoryLib
{
    //Workflow: Services --> Specification --> SerializationRepository
    //SERIALIZATION IS LIKE SYNCING DIFFERENT OBJECT TOGETHER TO PERFORM CERTAIN OPERATION.
    public class BinaryRepository : IDataRepository
    {
        public bool Serialize(string filename, List<Product> products)
        {
            bool status = false;
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(fs, products);
            fs.Close();
            status = true;
            return status;

        }

        public List<Product> Deserialize(string filename)
        {
            List<Product> products = new List<Product>();
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(filename, FileMode.Open);
            if (fs != null)
            {
                products = (List<Product>)formatter.Deserialize(fs);
            }
            fs.Close();
            return products;
        }

    }
}
