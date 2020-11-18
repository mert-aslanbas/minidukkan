using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDukkan.Models
{
    public class Urun
    {
        public long UrunID { get; set; }
        public string UrunAd { get; set; }
        public string Aciklama { get; set; }

        [Column (TypeName ="decimal (6,2)")]
        public decimal Fiyat { get; set; }
        public string Kategori { get; set; }

    }
}
