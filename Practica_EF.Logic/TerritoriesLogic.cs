using Practica_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF.Logic
{
    public class TerritoriesLogic:BaseLogic,IABMLogic<Territories>
    {
        public List<Territories> GetAll()
        {
            return context.Territories.Where(t =>t.RegionID==3).ToList();
        }

        public void add(Territories nuevoTerritorio)
        {
            context.Territories.Add(nuevoTerritorio);

            context.SaveChanges();
        }

        public void delete(string id)
        {
            var eliminarTerritorio = context.Territories.Find(id);

            context.Territories.Remove(eliminarTerritorio);

            context.SaveChanges();
        }
        public void Update(Territories territorio)
        {
            var ActualizarTerritorio = context.Territories.Find(territorio.TerritoryID);

            ActualizarTerritorio.TerritoryDescription = territorio.TerritoryDescription;

            context.SaveChanges();
        }
    }
}
