using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface Iservices<T>
    {
        string Guardar(T Cliente);
        string Delete(T Cliente);
        string Edit(T Cliente);
        List<T> GetAll();
       
    }
}