using System;
using System.Collections.Generic;
using System.Text;

namespace PooLabTransporte
{
    abstract class Transporte
    {
        protected Transporte(int pasajeros)
        {
            this._Pasajeros = pasajeros;
        }

        

        public int GetPasajeros
        {
            get { return _Pasajeros; }
            
        }


        int _Pasajeros; 

        public abstract void Avanzar();


        public abstract void Detenerse();
        
    }
}
