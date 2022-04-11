using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Abstract;

namespace Proxy.Concrete
{
    public class DatabaseProxy : IDatabase
    {
        private IDatabase Database { get; set; }
        private List<object> CacheItems { get; set; }


        public DatabaseProxy()
        {
            Database = new Database();
            CacheItems = new List<object>();
        }


        public void Append(object item)
        {
            CacheItems.Add(item);
            Console.WriteLine("Item added to database!");

            if (CacheItems.Count > 100)
            {
                Connect();

                foreach (var localItem in CacheItems) Database.Append(localItem);

                CacheItems.Clear();

                Disconnect();
            }
        }

        public void Connect() => Database.Connect();

        public void Disconnect() => Database.Disconnect();
    }
}
