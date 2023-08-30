using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
#nullable disable warnings
namespace Bai1
{
    internal class ToaDo
    {
        private double x;
        private double y;
        private string tenToaDo ;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public string TenToaDo { get => tenToaDo; set => tenToaDo = value; }
        public ToaDo() { }
        public ToaDo(double x, double y, string tenToaDo) 
        {
            this.x = x;
            this.y = y;
            this.tenToaDo = tenToaDo;
        }
        public override string ToString()
        {
            return $"{TenToaDo} ({X}, {Y})";
        }
    }
}
