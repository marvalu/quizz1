using System;
using System.Collections.Generic;
using System.Text;


namespace Quizz1
{

    public class Persona
    {

        private int _id;
        private string _nombre;
        private string _apellido;
        private int _ced;

        public int ID { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Ced { get => _ced; set => _ced = value; }



        public Persona(string Nombre, int ID, string Apellido, int Ced)
        {
            _id = ID;
            _nombre = Nombre;
            _apellido = Apellido;
            _ced = Ced;
        }

        public void retornaraaaa(){}

    }
}
