using Practica_EF.Data;
using Practica_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF.Logic
{
    public class EmployeesLogic:BaseLogic, IABMLogic<Employees>
    {
        public void add(Employees nuevoTerritorio)
        {
            context.Employees.Add(nuevoTerritorio);

            context.SaveChanges();
        }

        public void delete(int id)
        {
            var eliminarEmpleado = context.Employees.Find(id);

            context.Employees.Remove(eliminarEmpleado);

            context.SaveChanges();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Update(Employees empleado)
        {
            var ActualizarEmpleado = context.Employees.Find(empleado.EmployeeID);

            ActualizarEmpleado.FirstName = empleado.FirstName;
            ActualizarEmpleado.LastName = empleado.LastName;

            context.SaveChanges();
        }
    }
}
