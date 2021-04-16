using System;
using System.Collections.Generic;

namespace PooLabTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
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
            int loopAvion = 0;
            int loopAuto = 0;
            foreach (Transporte transporte in transportes)
            {



                if (transporte.GetType().ToString() == typeof(Avion).ToString())
                {
                    loopAvion++;
                    Console.WriteLine("Avion {0}:" + transporte.GetPasajeros + " pasajeros", loopAvion);
                }
                else
                {
                    loopAuto++;
                    Console.WriteLine("Automovil {0}:" + transporte.GetPasajeros + " pasajeros", loopAuto);
                }
            }


            Console.ReadKey();
        }
    }
}
