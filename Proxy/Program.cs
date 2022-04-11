using Proxy.Concrete;

namespace Proxy
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var proxyDatabase = new DatabaseProxy();

            for (int i = 0; i < 101; i++)
                proxyDatabase.Append(i);
        }
    }
}
