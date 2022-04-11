using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Abstract;

namespace Proxy.Concrete
{
    public class Database : IDatabase
    {
        private bool HasConnect { get; set; }

        private List<object> Items { get; set; }


        public Database()
        {
            Items = new();
        }


        public void Append(object item)
        {
            if (HasConnect) Items.Add(item);
        }

        public void Connect() => HasConnect = true;

        public void Disconnect() => HasConnect = false;
    }
}
