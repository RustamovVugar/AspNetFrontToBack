using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> services= GetAllServices();
            return View(services);
        }

        private List<Service> GetAllServices()
        {
            Service s1 = new()
            {
                Id = 1,
                Title = "Resul",
                Description = "Resul description",
                Icon = "icon-1.png"
            };

            Service s2 = new()
            {
                Id = 2,
                Title = "Musa",
                Description = "Musa description",
                Icon = "icon-2.png"
            };
            Service s3 = new()
            {
                Id = 3,
                Title = "Nicat",
                Description = "Nicat description",
                Icon = "icon-3.png"
            };
            Service s4 = new()
            {
                Id = 4,
                Title = "Ramil",
                Description = "Ramil description",
                Icon = "icon-4.png"
            };
            Service s5 = new()
            {
                Id = 5,
                Title = "Mahir",
                Description = "Mahir description",
                Icon = "icon-5.png"
            };
            Service s6 = new()
            {
                Id = 6,
                Title = "Anar",
                Description = "Anar description",
                Icon = "icon-6.png"
            };

            List<Service> services = new List<Service>() { s1, s2, s3, s4, s5, s6 };
            return services;
        }
    }
}