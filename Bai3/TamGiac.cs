using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable warnings
namespace Bai3
{
    internal class TamGiac
    {
        private double ma, mb, mc;

        public double Ma { get => ma; set => ma = value; }
        public double Mb { get => mb; set => mb = value; }
        public double Mc { get => mc; set => mc = value; }
        public TamGiac() { }
        // 3canh >0 va 2canh > canhconlai
        public TamGiac(double a,double b,double c)
        {
            if(a<0 || b <0 || c<0 || a+b<=c ||a+c<=b ||b+c<=a) {
                Ma = Mb = Mc = 0;
            }
            else
            {
                this.Ma = a; this.Mb = b; this.Mc = c;
            }
        }
        //public void nhap3canh()
        //{
        //    Console.WriteLine("nhập cạnh a: ");
        //    Ma=double.Parse(Console.ReadLine());
        //    Console.WriteLine("nhập cạnh b: ");
        //    Mb = double.Parse(Console.ReadLine());
        //    Console.WriteLine("nhập cạnh c: ");
        //    Mc = double.Parse(Console.ReadLine());
        //}
        public void xuatTamgiac()
        {
            Console.WriteLine("a: "+Ma);
            Console.WriteLine("b: " +Mb);
            Console.WriteLine("c: " +Mc);
            Console.WriteLine("loại tam giác: "+KTra());
            double S1 = Stamgiac();
            Console.WriteLine("Diện tích: "+S1.ToString("0.0000"));
        }
        //Chuvi tamgiac
        public double Ptamgiac()
        {
            return Ma + Mb + Mc;
        }
        public double nuaP()
        {
            return (Ma+Mb+Mc)/2;
        }
        public double Stamgiac()
        {
            return (Math.Sqrt(nuaP()*(nuaP()-Ma)*(nuaP()-Mb)*(nuaP()-Mc)));
        }
        //kiem rta tam giac thuoc loai nao
        public string KTra() {
            if (Ma == 0 )
            {
                return "không tạo được tam giác";
            }
            else if (Ma == Mb && Mb==Mc &&Ma !=0)
            {
                return "tam giác đều";
            }
            else if (Ma==Mb || Ma==Mc || Mb==Mc)
            {
                return "tam giác cân";
            }
            else if ( (Ma*Ma == Mb*Mb + Mc*Mc) || Mb * Mb == Ma * Ma + Mc * Mc ||Mc* Mc == Mb * Mb + Ma * Ma)
            {
                return "tam giác vuông";
            }
            else if ((Ma * Ma == Mb * Mb + Mc * Mc) && Mb == Mc 
                    ||Mb * Mb == Ma * Ma + Mc * Mc && Ma == Mc 
                    ||Mc * Mc == Ma * Ma + Mb * Mb && Ma == Mb)
            {
                return "tam giác vuông cân";
            }
            else { return "tam giác thường"; }
        }
    }
}
