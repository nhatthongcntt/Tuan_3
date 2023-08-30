using bai_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable warnings
namespace tuan2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv = new SinhVien();
            DSSV dssv = new DSSV();
            int chon;
            do
            {
                Console.WriteLine("\n==========MENU==========");
                Console.WriteLine("1.nhập 1 sinh viên: ");
                Console.WriteLine("2.xuất 1 sinh viên: ");
                Console.WriteLine("3.xuất thông tin bản thân: ");
                Console.WriteLine("4.xuất thông tin bạn thân: ");
                Console.WriteLine("5.nhập DS sinh viên: ");
                Console.WriteLine("6.xuất DS sinh viên: ");
                Console.WriteLine("chọn 1 lựa chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("nhap thong tin 1 sv\n");
                        sv.nhap1sv();
                        break;
                    case 2:
                        Console.Write("ID:\tNAME\tDiemLT\tDiemTH\tDiemTB\t");
                        sv.xuat1sv();
                        break;
                    case 3:
                        SinhVien sv1 = new SinhVien(111,"Thống",8,9);
                        sv1.xuat1sv();
                        break;
                    case 4:
                        SinhVien sv2 = new SinhVien(365, "Nhất", 8,7);
                        sv2.xuat1sv();
                        break;
                    case 5:
                        int n;
                        Console.WriteLine("nhập số lượng sinh viên: ");
                        n=int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            sv.nhap1sv();
                            dssv.nhapdanhsachSV(sv);
                        }
                        break;
                    case 6:
                        Console.WriteLine("DANH SÁCH SINH VIÊN");
                        Console.Write("ID:\tNAME\tDiemLT\tDiemTH\tDiemTB\t");
                        dssv.xuatDSSV();
                        break;
                    default:
                        Console.WriteLine("Vui lòng chọn đúng");
                        break;
                }
            } while (chon != 6);
            Console.ReadLine();
        }
    }
}
