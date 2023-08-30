using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuan2;

//tui tat tam di
#nullable disable warnings

namespace bai_2
{
    internal class DSSV
    {
        List<SinhVien> dssv = new List<SinhVien>();
         public void nhapdanhsachSV(SinhVien sv)
        {
            dssv.Add(sv);
        }
        public void xuatDSSV()
        {
            foreach (SinhVien sv in dssv)
            {
                sv.xuat1sv();
            }
        }
    }
}
