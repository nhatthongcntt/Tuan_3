using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Xe
    {
        private string loaixe ="";
        private string tenchuxe ="";
        private double dungtich;
        private double trigia;

        public string Loaixe { get => loaixe; set => loaixe = value; }
        public string Tenchuxe { get => tenchuxe; set => tenchuxe = value; }
        public double Dungtich
        { 
            get => dungtich;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("không dược bé hơn 0");
                }
                dungtich = value;
            }
        }
        public double Trigia { get => trigia; set => trigia = value; }
        public Xe()
        {

        }
        public Xe(string tenchuxe1, string loaixe1, double dungtich1, double trigia1)
        {
            this.Loaixe = loaixe1;
            this.Tenchuxe = tenchuxe1;
            this.Dungtich  = dungtich1;
            this.Trigia = trigia1;
        }
        public double tinhthue()
        {
            if (Dungtich < 100)
            {
                return 0.1*Trigia;
            }
            else if (Trigia >=100 && Trigia <200 )
            {
                return 1.3 * Trigia;
            }
            else { return 0.5 * Trigia; }
        }
        public void nhap()
        {
            Console.WriteLine("tên chủ xe: ");
            Tenchuxe = Console.ReadLine();
            Console.WriteLine("loại xe: ");
            Loaixe = Console.ReadLine();
            Console.WriteLine("Dung tích: ");
            Dungtich = double.Parse(Console.ReadLine());
            Console.WriteLine("trị giá: ");
            Trigia = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write("\n{0,-20}{1,-15}{2,-15}{3,-20}{4}",Tenchuxe,Loaixe,Dungtich,Trigia,Math.Round(tinhthue(),3));
        }
    }
}
