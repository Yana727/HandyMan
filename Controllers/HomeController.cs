using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandyMan.Models;

namespace HandyMan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {  
            ViewData ["picture"] = "picture here"; 
            ViewData ["Message"] = "Home message"; 
            ViewData ["Article-1-Heading"] = "Hire a Professional Handyman - Call 12345";
            ViewData ["Article-1-Body"] = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.At eam doctus oportere, eam feugait delectus ne. Quo cu vulputate persecuti. Eum ut natum possim comprehensam, habeo dicta scaevola eu nec. Ea adhuc reformidans eam. Pri dolore epicuri eu, ne cum tantas fierent instructior. Pro ridens intellegam ut, sea at graecis scriptorem eloquentiam.";
            ViewData ["Article-2-Heading"] = "Furniture Assembly";
            ViewData ["Arcitle-2-Body"] = "This guy is really good at assmebling"; 
            return View();
        }

        public IActionResult Price()
        {
            ViewData["Message"] = "Your application description page.";
            
            var prices  = new List<PriceModel>(); 

            var service1 = new PriceModel
            {
               Service = "doing stuff" , 
               Info = "something else"
            
            };

            prices.Add(service1); 

            return View(prices);
        }

        public IActionResult Reference()
        {
            ViewData["Message"] = "Your contact page.";
            ViewData["ref"] = "Reference here"; 

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
