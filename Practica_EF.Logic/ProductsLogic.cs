using Practica_EF.Data;
using Practica_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF.Logic
{
    public class ProductsLogic:BaseLogic,IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.Where(p => p.CategoryID == 1).ToList();
        }
        public int add(Products nuevoProducto)
        {
            context.Products.Add(nuevoProducto);

            context.SaveChanges();
            return nuevoProducto.ProductID;
        }
        public void Delete(int id)
        {
            var eliminarProducto = context.Products.Find(id);

            context.Products.Remove(eliminarProducto);

            context.SaveChanges();
        }

        public void Update(Products producto)
        {
            var ActualizarProducto = context.Products.Find(producto.ProductID);

            ActualizarProducto.ProductName = producto.ProductName;

            context.SaveChanges();
        }
    }
}
