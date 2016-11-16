using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSMQClient.MSMQServiceReference;
namespace MSMQClient
{
    class Program
    {
        static void Main(string[] args)
        {

            MSMQServiceClient proxy = new MSMQServiceClient();
            for(int i = 0; i < 100; i++) {
                proxy.GetData("hello"+i);
                Console.WriteLine(i+ " Message sent.");
            }
            

            Console.ReadLine();
        }
    }
}
