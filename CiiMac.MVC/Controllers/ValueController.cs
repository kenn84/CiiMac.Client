using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiiMac.MVC.Models;
using CiiMac.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CiiMac.MVC.Controllers
{
    public class ValueController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ValueService valueService = new ValueService();
            List<string> stringvalues = valueService.GetValues();

            List<Value> values = new List<Value>();
            for (int i = 0; i < stringvalues.Count; i++)
            {
                Value value = new Value();                
                string variable = stringvalues.ElementAt<string>(i);
                value.StringValue = variable;
                values.Add(value);
            }

            return View(values);
        }
    }
}