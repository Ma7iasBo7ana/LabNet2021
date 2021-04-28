using Practica_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();

        //void add(T nuevoTerritorio);
        //void delete(int id);
        void Update(T territorio);

    }
}
