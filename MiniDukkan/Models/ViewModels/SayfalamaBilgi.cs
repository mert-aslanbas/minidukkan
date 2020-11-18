using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDukkan.Models.ViewModels
{
    public class SayfalamaBilgi
    {
        public int ToplamUrunSayisi { get; set; }

        public int SayfaBasiGosterilcekUrun { get; set; }

        public int GuncelSayfa { get; set; }

        public int ToplamSayfalar => (int)Math.Ceiling((decimal)ToplamUrunSayisi / SayfaBasiGosterilcekUrun);
    }
}
