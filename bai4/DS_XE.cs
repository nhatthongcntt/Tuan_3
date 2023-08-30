using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class DS_XE
    {
        List<Xe> dsxe = new List<Xe>();
        public void nhapDSxe(Xe xe)
        {
            dsxe.Add(xe);
        }
        public void xuatDSxe()
        {
            foreach (Xe xe in dsxe)
            {
                xe.xuat();
            }
        }
    }
}
