using System;
using System.Collections.Generic;
using System.Text;

namespace PooLabTransporte
{
    abstract class Transporte
    {
        protected Transporte(int pasajeros)
        {
            this._pasajeros = pasajeros;
        }              

        public int getPasajeros
        {
            get { return _pasajeros; }
            
        }        

        private int _pasajeros; 

        public abstract void Avanzar();


        public abstract void Detenerse();
        
    }
}
