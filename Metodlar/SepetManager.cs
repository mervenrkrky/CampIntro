﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        //nameing convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);



          
        }
        public void Ekle2(string urunAdi, string acıklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);

        }
    }
}
