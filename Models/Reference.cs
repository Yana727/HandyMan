using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandyMan.Models;

namespace HandyMan.Models
{
    public class Reference : Controller
    {
        public string Message { get; set;}
        public string  Website { get; set;}
        
        public string Email {get; set;}

        public string Name {get; set;}
    }
}