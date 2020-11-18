using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniDukkan.Models;
using MiniDukkan.Models.ViewModels;

namespace MiniDukkan.Controllers
{
    public class HomeController : Controller
    {   
        IDukkanRepository repository;
        public  int SayfaBoyutu = 3;

        public HomeController(IDukkanRepository repo)
        {
            repository = repo; 
        }



        public ViewResult Index(string Kategori, int urunsayfa = 1)
          => View(new UrunlerListesiViewModel { Urunler = repository.Urunler.Where(u => Kategori == null || u.Kategori == Kategori).OrderBy(u => u.UrunID)
              .Skip((urunsayfa - 1) * SayfaBoyutu).Take(SayfaBoyutu), SayfalamaBilgi =
               new SayfalamaBilgi { GuncelSayfa = urunsayfa, SayfaBasiGosterilcekUrun =
                   SayfaBoyutu, ToplamUrunSayisi = Kategori == null ? repository.Urunler.Count() :
                   repository.Urunler.Where(e => e.Kategori == Kategori).Count()


               }, GuncelKategori = Kategori
          }
          );

    }
}
