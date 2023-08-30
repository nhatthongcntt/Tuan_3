using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //2 vi phạm ràng buộc -> cố tình nhập sai nên a,b,c mac dinh la 0.
            TamGiac tg1 = new TamGiac(2, 2, 5);
            Console.WriteLine("Thông tin tam giác");
            tg1.xuatTamgiac();
            TamGiac tg2 = new TamGiac(-10, 2, 4);
            Console.WriteLine("Thông tin tam giác");
            tg2.xuatTamgiac();
            //3 hình tam giác thường - cân - đều
            TamGiac tg01 = new TamGiac(2, 3, 4);
            Console.WriteLine("Thông tin tam giác");
            tg01.xuatTamgiac();
            TamGiac tg02 = new TamGiac(3, 3, 5);
            Console.WriteLine("Thông tin tam giác");
            tg02.xuatTamgiac();
            TamGiac tg03 = new TamGiac(2, 2, 2);
            Console.WriteLine("Thông tin tam giác");
            tg03.xuatTamgiac();

            Console.ReadLine();
        }
    }
}
