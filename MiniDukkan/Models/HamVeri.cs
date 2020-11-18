using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDukkan.Models
{
    public static  class HamVeri
    {
        public static void  VeriDoldur(IApplicationBuilder app )
        {
            MiniDukkanContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MiniDukkanContext>();
               if(context.Database.GetPendingMigrations().Any())
               {
                  context.Database.Migrate();
               }
                    if (!context.Urunler.Any())
                    {
                context.Urunler.AddRange(
                    new Urun
                    {
                        UrunAd = "Çıngırak",
                        Aciklama = "Çıngırak bebek oyuncagı ",
                        Kategori = "Bebek oyuncagı",
                        Fiyat = 15

                    },


                             new Urun
                             {
                                 UrunAd = "Oyunhalısı ",
                                 Aciklama = "Renkli desenli halı",
                                 Kategori = "Bebek oyuncagı",
                                 Fiyat = 150

                             },

                                      new Urun
                                      {
                                          UrunAd = "Barbibebek",
                                          Aciklama = "oyuncak",
                                          Kategori = "kız oyuncagı",
                                          Fiyat = 78

                                      },

                                               new Urun
                                               {
                                                   UrunAd = "Mutfakseti",
                                                   Aciklama = "İçinde mutfak seti bulunan oyuncak",
                                                   Kategori = "Kız oyuncagı",
                                                   Fiyat = 100

                                               },
                                                                 new Urun
                                                                 {
                                                                     UrunAd = "BarbiEvi",
                                                                     Aciklama = "Barbinin oyun evi  ",
                                                                     Kategori = "Kız oyuncagı",
                                                                     Fiyat = 250

                                                                 },
                                                                          new Urun
                                                                          {
                                                                              UrunAd = "Boncuklu tabcanca",
                                                                              Aciklama = "Silah",
                                                                              Kategori = "Erkek oyuncagı",
                                                                              Fiyat = 25

                                                                          },
                                                                                   new Urun
                                                                                   {
                                                                                       UrunAd = "Fottbool topu",
                                                                                       Aciklama = " mikasa fotbool top ",
                                                                                       Kategori = "Erkek oyuncagı",
                                                                                       Fiyat = 75
                                                                                   },
                                                                                            new Urun
                                                                                            {
                                                                                                UrunAd = "Pung oyun seti",
                                                                                                Aciklama = "savaş oyunu seti ",
                                                                                                Kategori = "Erkek oyuncagı",
                                                                                                Fiyat = 170

                                                                                            },
                                                                                            new Urun
                                                                                            {
                                                                                                UrunAd = "Araba oyun seti ",
                                                                                                Aciklama = "Arabalar ",
                                                                                                Kategori = "Erkek oyuncagı",
                                                                                                Fiyat = 170

                                                                                            },
                                                                                                     new Urun
                                                                                                     {
                                                                                                         UrunAd = "Akülüjip ",
                                                                                                         Aciklama = "Akülü araba ",
                                                                                                         Kategori = "Genel oyuncakları",
                                                                                                         Fiyat = 3500

                                                                                                     }
                    );
                context.SaveChanges();
                    }
        }
    }
}
