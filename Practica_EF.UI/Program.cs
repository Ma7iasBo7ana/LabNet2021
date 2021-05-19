using Practica_EF.Entities;
using Practica_EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();
            EmployeesLogic employeesLogic = new EmployeesLogic();
            ProductsLogic productsLogic = new ProductsLogic();

            int opcion;
            Console.WriteLine("Seleccione una Tabla para mostrar,después se procedera a hacer un insert luego un update y por último un delete:");
            Console.WriteLine("1. Productos");
            Console.WriteLine("2. Territorios");
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error, seleccione la tabla deseada");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Productos");
                Console.WriteLine("2. Territorio");
                
            }
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("A continuación se mostrara el listada de la tabla Products, filtrado por Category ID=1, para visualizar mejor la tabla");
                    Console.ReadKey();
                    MostrarTablaProductos();
                    Console.WriteLine("A continuación se volvera a mostrar el listada de la tabla Products, pero con un nuevo registro agregado");
                    Console.ReadKey();
                    int nuevoid = productsLogic.add(new Products
                    {

                        ProductName = "Cerveza",
                        CategoryID = 1
                    });

                    MostrarTablaProductos();
                    Console.WriteLine("A continuación se volvera a mostrar el listada de la tabla Product, pero modificando la descripción del registro agregado");
                    Console.ReadKey();
                    productsLogic.Update(new Products
                    {
                        ProductID = nuevoid,
                        ProductName = "Pizza"

                    });
                    MostrarTablaProductos();
                    Console.WriteLine("Por último se volvera a mostrar el listada de la tabla Territories, pero eliminando el registro anteriormente creado");
                    Console.ReadKey();
                    productsLogic.Delete(nuevoid);
                    MostrarTablaProductos();
                    break;
                case 2:
                    Console.WriteLine("A continuación se mostrara el listada de la tabla Territories, filtrado por region ID =3, para visualizar mejor la tabla");
                    Console.ReadKey();
                    MostrarTablaTerritorio();

                    Console.WriteLine("A continuación se volvera a mostrar el listada de la tabla Territories, pero con un nuevo registro agregado");
                    Console.ReadKey();



                    territoriesLogic.add(new Territories
                    {
                        TerritoryID = "10007",
                        TerritoryDescription = "Buenos Aires",
                        RegionID = 3

                    });




                    MostrarTablaTerritorio();
                    Console.WriteLine("A continuación se volvera a mostrar el listada de la tabla Territories, pero modificando la descripción del registro agregado");
                    Console.ReadKey();
                    territoriesLogic.Update(new Territories
                    {
                        TerritoryID = "10007",
                        TerritoryDescription = "Nueva Descripción"

                    });
                    MostrarTablaTerritorio();

                    Console.WriteLine("Por último se volvera a mostrar el listada de la tabla Territories, pero eliminando el registro anteriormente creado");
                    Console.ReadKey();
                    territoriesLogic.delete("10007");
                    MostrarTablaTerritorio();
                    break;
                default:
                    break;
            }
            
            Console.ReadLine();

        }

        static void MostrarTablaTerritorio()
        {
            Console.Clear();
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();
            int contador = 0;

            foreach (Territories territorio in territoriesLogic.GetAll())
            {
                if (contador == 0)
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("|  Id  |Region ID|                 Descripción                      |");
                    Console.WriteLine("------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine((string.Format("|{0,-6}|{1,-9}|{2,-22}|", territorio.TerritoryID, territorio.RegionID, territorio.TerritoryDescription)));
                    Console.WriteLine("------------------------------------------------------------------------");
                }
                contador++;

            }
        }
        static void MostrarTablaProductos()
        {
            Console.Clear();
            ProductsLogic productslogic = new ProductsLogic();
            int contador = 0;

            foreach (Products producto in productslogic.GetAll())
            {

                if (contador == 0)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.WriteLine("|Id|              Nombre               |   Cantidad por unidad   | P/unidad | Stock |Orden|");
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                }
                else
                {

                    Console.WriteLine((string.Format("|{0,-2}|{1,-35}|{2,-25}|{3,-10}|{4,-7}|{5,-5}|", producto.ProductID, producto.ProductName, producto.QuantityPerUnit, producto.UnitPrice, producto.UnitsInStock, producto.UnitsOnOrder)));
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                }
                contador++;
            }

        }
        }
    }
     

