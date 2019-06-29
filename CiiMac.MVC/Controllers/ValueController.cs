using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiiMac.MVC.Models;
using CiiMac.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CiiMac.MVC.Controllers
{
    [Route("api/[controller]")]
    public class ValueController : Controller
    {
        public IActionResult Index()
        {           
            return View();
        }

        [HttpGet]
        public List<Value> GetValues()
        {
            ValueService valueService = new ValueService();
            return valueService.GetValuesAsync().Result;            
        }

    }
}