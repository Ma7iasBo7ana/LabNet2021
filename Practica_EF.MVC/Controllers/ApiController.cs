using Newtonsoft.Json;
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
        // GET: Api
        //public ActionResult Index()
        //{
            
        //    return View();
        //}

        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://www.cultura.gob.ar/api/v2.0/");

            //var ListaNumeros = JsonConvert.DeserializeObject<List<Cultura>>(json);
            //var cultura = JsonConvert.DeserializeObject<Cultura>(json);
            var lista = new List<Cultura>();



            return View(lista);
        }
    }
}