using Practica_EF.Entities;
using Practica_EF.Logic;
using Practica_EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_EF.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriesLogic logic = new TerritoriesLogic();
        

        // GET: Territories
        public ActionResult Index()
        {
            
            List <Territories> territories = logic.GetAll();
            List<TerritoriesView> territoriesViews = territories.Select(s => new TerritoriesView
            {
                Id = s.TerritoryID,
                Descripcion = s.TerritoryDescription,

            }).ToList();
            return View(territoriesViews);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(TerritoriesView territoriesView)
        {
            try
            {
                var territoriesEntity = new Territories
                {
                    TerritoryID = territoriesView.Id,
                    TerritoryDescription = territoriesView.Descripcion,
                    RegionID=3
                    
                };
                logic.add(territoriesEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error");
            }
            
        }
        public ActionResult Deletes(string id)
        {
            try
            {
                logic.delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error");
            }
            
        }
        [HttpGet]
        public ActionResult Update(string id, string descripcion)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(TerritoriesView territoriesView)
        {

            try
            {
                var territoriesEntity = new Territories
                {
                    TerritoryID = territoriesView.Id,
                    TerritoryDescription = territoriesView.Descripcion,
                    

                };
                logic.Update(territoriesEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult enviarvista()
        {
            Response.Redirect("https://localhost:44303/Api/ApiView");
            return View();
        }

       
    }

}
