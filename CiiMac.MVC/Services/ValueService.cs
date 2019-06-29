using CiiMac.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CiiMac.MVC.Services.Base;

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

        public async Task<List<Value>> GetValuesAsync()
        {
            HttpResponseMessage response = await _client.GetAsync(_client.BaseAddress + "/api/values");
            if (response.IsSuccessStatusCode)
            {
                var value = response.Content.ReadAsStringAsync().Result;

            }

            return value;
        }
    }
}
