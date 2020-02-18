using quizz1;
using System;
using System.Collections.Generic;
using System.Text;
namespace Quizz1
{
    public class Cliente : Persona, Iretorno
    {

        private int _telefono;
        private string _correo;



        public int Telefono1 { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }

        //public Cliente(int telefono, string correo)
        //{
        //    _telefono = telefono;
        //    Correo = correo;
        //}

        public Cliente(string Nombre, int Id, string Apellido, int Ced) : base(Nombre, Id, Apellido, Ced)
        {

        }

        //public Cliente() { }

        public void retorno()
        {
            Console.WriteLine(ID + " " + Nombre +  "\n");
        }

    }
}
