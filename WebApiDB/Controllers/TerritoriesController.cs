using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiDB.Models;
using System.Web.Http.Cors;

namespace WebApiDB.Controllers
{
    public class TerritoriesController : ApiController
    {
        private DB1Entities db = new DB1Entities();
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        // GET: api/Territories
        public IQueryable<Territories> GetTerritories()
        {
            return db.Territories;
        }

        // GET: api/Territories/5
        [ResponseType(typeof(Territories))]
        public IHttpActionResult GetTerritories(string id)
        {
            Territories territories = db.Territories.Find(id);
            if (territories == null)
            {
                return NotFound();
            }

            return Ok(territories);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        // PUT: api/Territories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTerritories(string id, Territories territories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != territories.TerritoryID)
            {
                return BadRequest();
            }

            db.Entry(territories).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TerritoriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        // POST: api/Territories
        [ResponseType(typeof(Territories))]
        public IHttpActionResult PostTerritories(Territories territories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Territories.Add(territories);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TerritoriesExists(territories.TerritoryID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = territories.TerritoryID }, territories);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]

        // DELETE: api/Territories/5
        [ResponseType(typeof(Territories))]
        public IHttpActionResult DeleteTerritories(string id)
        {
            Territories territories = db.Territories.Find(id);
            if (territories == null)
            {
                return NotFound();
            }

            db.Territories.Remove(territories);
            db.SaveChanges();

            return Ok(territories);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TerritoriesExists(string id)
        {
            return db.Territories.Count(e => e.TerritoryID == id) > 0;
        }
    }
}