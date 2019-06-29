using CiiMac.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CiiMac.MVC.Services.Base;
using Newtonsoft.Json;

namespace CiiMac.MVC.Services
{
    public class ValueService
    {
        private HttpClient _client;

        public ValueService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:51948")
            };
        }

        public List<string> GetValues()
        {
            List<string> values = new List<string>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "api/values").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                values = JsonConvert.DeserializeObject<List<string>>(result);
            }

            return values;
        }
    }
}
