using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable warnings
namespace tuan2
{
    internal class SinhVien
    {
        private int maSV;
        private string name;
        private double diemLT;
        private double diemTH;
        public int MaSV { get => maSV; set => maSV = value; }
        public string Name { get => name; set => name = value; }
        public double DiemLT
        {
            get => diemLT;
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("DiemLT nên giữa 0 và 10");
                }
                diemLT = value;
            }
        }

        public double DiemTH { 
            get => diemTH;
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("DiemLT nên giữa 0 và 10.");
                }
                diemTH = value;
            }

        }
        public SinhVien() {
        }
        public SinhVien(int id, string ten, double diemlt, double diemth)
        {
            this.MaSV = id;
            this.Name = ten;
            this.DiemLT = diemlt;
            this.DiemTH = diemth;
        }
        public double diemTB()
        {
            return (DiemLT + DiemTH) / 2;
        }
        public void nhap1sv()
        {
            Console.Write("Id: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("diemLT: ");
            DiemLT = double.Parse(Console.ReadLine());
            Console.Write("diemTH: ");
            DiemTH = double.Parse(Console.ReadLine());
        }
        public void xuat1sv()
        {
            //làm tròn giá trị tới 3 số thập phân sau dấu phẩy
            Console.Write("\n{0}\t{1}\t{2}\t{3}\t{4}",MaSV,Name,DiemLT,DiemTH,Math.Round(diemTB(),3));
        }
    }
}
