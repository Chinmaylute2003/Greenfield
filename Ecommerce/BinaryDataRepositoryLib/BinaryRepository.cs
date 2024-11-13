using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Specification;
using EcommerceEntities;
using System.IO;
namespace BinaryDataRepositoryLib
{
    //Workflow: Services --> Specification --> SerializationRepository
    //SERIALIZATION IS LIKE SYNCING DIFFERENT OBJECT TOGETHER TO PERFORM CERTAIN OPERATION.
    public class BinaryRepository<T>: IDataRepository<T>
    {
        public bool Serialize(string filename, List<T> items)
        {
            bool status = false;
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(fs, items);
            fs.Close();
            status = true;
            return status;

        }

        public List<T> Deserialize(string filename)
        {
            List<T> items = null;
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(filename, FileMode.Open);
            if (fs != null)
            {
                items = (List<T>)formatter.Deserialize(fs);
            }
            fs.Close();
            return items;
        }

    }
}
