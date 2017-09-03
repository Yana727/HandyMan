using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandyMan.Models;

namespace HandyMan.Models
{
    public class PriceModel : Controller
    {
        public string Service { get; set;}
        public string  Info { get; set;}
    }
}