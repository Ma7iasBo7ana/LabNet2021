using System;
using System.Collections.Generic;

namespace PooLabTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se Crea Una lista llamada "transportes" con diez objetos cargados */
            List<Transporte> transportes = new List<Transporte>
            {
                new Avion(1000),
                new Avion(300),
                new Avion(100),
                new Avion(30),
                new Avion(10),
                new Automovil(5),
                new Automovil(4),
                new Automovil(3),
                new Automovil(2),
                new Automovil(1)           

            };
            
            int contadorAvion = 0;
            int contadorAuto = 0;

            /*Iteración que busca que tipo de transporte es y le asigna un número */
            foreach (Transporte transporte in transportes)
            {                                            

                if (transporte.GetType().ToString() == typeof(Avion).ToString())
                {
                    contadorAvion++;
                    Console.WriteLine($"Avion {contadorAvion}:{transporte.getPasajeros} pasajeros");
                }
                else
                {
                    contadorAuto++;
                    Console.WriteLine($"Automovil {contadorAuto}:{transporte.getPasajeros} pasajeros");
                }
            }

            Console.ReadKey();
        }
    }
}
