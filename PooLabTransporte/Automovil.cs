using System;
using System.Collections.Generic;
using System.Text;

namespace PooLabTransporte
{
    class Automovil : Transporte
    {
        public Automovil(int pasajeros) : base(pasajeros)
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
