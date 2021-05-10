using Newtonsoft.Json.Linq;
using Practica_EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Practica_EF.MVC.Controllers
{
    public class ApiController : Controller
    {
        

        public async Task<ActionResult> ApiView()
        {
            Numbers numero = new Numbers();
            List<Numbers> lista = new List<Numbers>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://numbersapi.p.rapidapi.com/1492/year?json=true&fragment=true"),
                Headers =
                {
                    { "x-rapidapi-key", "9d965bc278msh1229257d346fedcp18043fjsn32a68b92685b" },
                    { "x-rapidapi-host", "numbersapi.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                JObject jObject = JObject.Parse(body);


                numero.number = int.Parse(jObject["number"].ToString());                
                numero.found = bool.Parse(jObject["found"].ToString());
                numero.text = jObject["text"].ToString();
                numero.type = jObject["type"].ToString();

                
                    
            }
            lista.Add(numero);

            return View(lista);
        }
    }
}