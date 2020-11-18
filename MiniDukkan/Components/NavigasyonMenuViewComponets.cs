using Microsoft.AspNetCore.Mvc;
using MiniDukkan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDukkan.Components
{
    public class NavigasyonMenuViewComponent : ViewComponent
    {
        private IDukkanRepository repository;

        public NavigasyonMenuViewComponent(IDukkanRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SecilenKategori = RouteData?.Values["kategori"];
            return View(repository.Urunler.Select(x => x.Kategori).Distinct().OrderBy(x => x));
        }
    }
}