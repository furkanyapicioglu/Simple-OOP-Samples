using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Ornek
{
    //miras alma
    //tuzel musteri bir musteridir demek
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
