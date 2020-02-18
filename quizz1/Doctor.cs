using quizz1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz1
{
    public class Doctor : Persona, Iretorno
    {

        private string _especialidad;

        public string Especialidad { get => _especialidad; set => _especialidad = value; }


        public Doctor(string Nombre, int Id, string Apellido, int Ced, string Especialidad) : base(Nombre, Id, Apellido, Ced)
        {
            _especialidad = Especialidad;
        }

       

        public void retorno()
        {
            Console.WriteLine(ID+" "+ Nombre + " "+ Especialidad+ "\n");
        }
    }
}