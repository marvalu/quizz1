using System;
using System.Collections.Generic;
using System.Text;

namespace quizz1
{
   public class Citas : IMetodos<Citas>
    {
        private int _IdCita;
        private string _NombreDoctor;
        private string _NombreCliente;
        List<Citas> lista = new List<Citas>();
        public int IdCita { get => _IdCita; set => _IdCita = value; }
        public string NombreDoctor { get => _NombreDoctor; set => _NombreDoctor = value; }
        public string NombreCliente { get => _NombreCliente; set => _NombreCliente = value; }

        public Citas(int idCita, string nombreDoctor, string nombreCliente)
        {
            IdCita = idCita;
            _NombreDoctor = nombreDoctor;
            _NombreCliente = nombreCliente;
        }

        public Citas()
        {
        }

        public Citas Buscar(int indice)
        {
            return lista[indice];


        }


        public void Eliminar(int indice)
        {
            lista.RemoveAt(indice);
        }

        public void iNSERTAR(Citas item)
        {
            lista.Add(item);
        }
        public int tamañoLista()
        {
            int tamañoLista = lista.Count - 1;


            return tamañoLista;
        }
    }
}
