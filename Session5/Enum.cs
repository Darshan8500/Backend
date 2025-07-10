using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Session5
{
    enum OrderStatus
    {
        Pending = 1,
        Processing,
        Completed,
        Cancelled
    }

    public class Enum
    {
        public static void Run()
        {
            Console.WriteLine("6. Enums:");
            OrderStatus status = OrderStatus.Processing;
            Console.WriteLine($"Status: {status}, Value: {(int)status}\n");
        }
    }
}
