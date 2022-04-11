using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Abstract
{
    public interface IDatabase
    {
        void Append(object item);
        void Connect();
        void Disconnect();
    }
}
