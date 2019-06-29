using CiiMac.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CiiMac.MVC.Services
{
    public class ValueService
    {
        public static async Task<Values> GetValuesAsync(string path)
        {
            HttpClient client = new HttpClient();
            Values value = new Values();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                value = await response.Content.ReadAsAsync<Values>();
            }
            return value;
        }
    }
}
