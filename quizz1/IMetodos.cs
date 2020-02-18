using System;
using System.Collections.Generic;
using System.Text;

namespace quizz1
{
   public interface IMetodos <T>
    {

        void iNSERTAR(T item);

        void Eliminar(int indice);

        T Buscar(int indice);
    }
}
