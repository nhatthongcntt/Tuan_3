using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ToaDo td1 = new ToaDo(5,10,"tọa độ A");
            Console.WriteLine("{0}({1},{2})",td1.TenToaDo,td1.X,td1.Y);
            Console.ReadLine();
        }
    }
}
