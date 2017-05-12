using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient.ServiceEngineClient c = new ServiceClient.ServiceEngineClient();
            c.ClientCredentials.UserName.UserName = "biswajit";
            c.ClientCredentials.UserName.Password = "123";

           Console.WriteLine( c.YourName("Bisu"));
        }
    }
}
