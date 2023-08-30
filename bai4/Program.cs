using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args) { 
            Console.OutputEncoding = Encoding.UTF8;
            Xe xe = new Xe();
            DS_XE dsxe = new DS_XE();
            int chon;
            do
            {
                Console.WriteLine("\n==========MENU==========");
                Console.WriteLine("1.xem 3 đối tượng Vehicle xe1, xe2, xe3: ");
                Console.WriteLine("2.nhập DS xe: ");
                Console.WriteLine("3.xuất DS xe: ");
                Console.WriteLine("chọn 1 lựa chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Thông tin xe");
                        Console.WriteLine("{0,-20}{1,-15}{2,-15}{3,-20}{4}", "Tên chủ xe", "Loại xe", "Dung tích", "Trị giá", "Thuế phải nộp");
                        Console.WriteLine("=================================================================================================");
                        Xe xe1 = new Xe("Nguyễn Thu Loan", "Future Neo", 100, 35000000.00);
                        xe1.xuat();
                        Xe xe2 = new Xe("Lê Minh Tín", "Ford Ranger", 3000, 250000000.00);
                        xe2.xuat();
                        Xe xe3 = new Xe("Nguyễn Minh Triết", "landscape", 1500, 100000000.00);
                        xe3.xuat();
                        break;
                    case 2:
                        int n;
                        Console.WriteLine("Nhập số lượng xe: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            xe.nhap();
                            dsxe.nhapDSxe(xe);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thông tin xe");
                        Console.WriteLine("{0,-20}{1,-15}{2,-15}{3,-20}{4}", "Tên chủ xe", "Loại xe", "Dung tích", "Trị giá", "Thuế phải nộp");
                        Console.WriteLine("=================================================================================================");
                        dsxe.xuatDSxe();
                        break;
                }
            } while (chon != 3);

            Console.ReadLine();
        }
    }
}
