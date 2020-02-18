using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quizz1
{
    public class Operaciones : IMetodos<Iretorno>
    {

        string doc;
        string doctorLista;
        int cont;
        
        List<Iretorno> lista = new List<Iretorno>();

       // public object Item { get => item; set => item = value; }

        public Iretorno  Buscar(int indice)
        {
            return lista[indice];


        }
        

        public void Eliminar(int indice)
        {
            lista.RemoveAt(indice);
        }

        public void iNSERTAR(Iretorno item)
        {
            lista.Add(item);
        }
        public int tamañoLista() {
            int tamañoLista = lista.Count - 1;
            

            return tamañoLista;
        }
    }
}