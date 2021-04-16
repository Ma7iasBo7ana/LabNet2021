using System;
using System.Collections.Generic;
using System.Text;

namespace PooLabTransporte
{
    class Avion : Transporte
    {
        public Avion(int pasajeros) : base(pasajeros)
        {
        }

        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
