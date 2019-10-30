using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Utils
{
    public class DefaultClient
    {
        public static async Task<string> GetAsync(string URI)
        {
            HttpClient _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await _client.GetAsync(URI);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception();
            }

        }
        public static async Task<string> PutAsync(string URI, object content)
        {
            var _client = new HttpClient();
            var json = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            _client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = await _client.PutAsJsonAsync(URI, stringContent);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
