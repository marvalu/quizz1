using System;
using System.Collections.Generic;
using System.Text;
using Quizz1;

namespace quizz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //empieza

            //Operaciones operaciones = new Operaciones();
            //Doctor doctor1 = new Doctor("marco1", 1, "val", 12, "pediatra");
            //Doctor doctor2 = new Doctor("marco2", 1, "val", 123, "pediatra");
            //Doctor doctor3 = new Doctor("marco3", 1, "val", 1234, "pediatra");


            //Cliente cliente1 = new Cliente("dieg1", 2, "dd", 11);
            //Cliente cliente2 = new Cliente("dieg2", 3, "dd", 12);
            //Cliente cliente3 = new Cliente("dieg3", 4, "dd", 13);
            //Cliente cliente4 = new Cliente("dieg4", 5, "dd", 14);
            //Cliente cliente5 = new Cliente("dieg5", 5, "dd", 15);
            //Cliente cliente6 = new Cliente("dieg6", 5, "dd", 16);
            //Cliente cliente7 = new Cliente("dieg7", 5, "dd", 17);
            //Cliente cliente8 = new Cliente("dieg8", 5, "dd", 18);
            //Cliente cliente9 = new Cliente("dieg9", 5, "dd", 19);
            //Cliente cliente10 = new Cliente("dieg10", 5, "dd", 20);



            //operaciones.iNSERTAR(doctor);
            //operaciones.iNSERTAR(doctor1);
            //operaciones.iNSERTAR(doctor2);
            //operaciones.iNSERTAR(doctor3);
            //operaciones.iNSERTAR(doctor4);
            //operaciones.iNSERTAR(cliente);
            //operaciones.iNSERTAR(cliente1);
            //operaciones.iNSERTAR(cliente2);
            //operaciones.iNSERTAR(cliente3);

            //termina

            List<Citas> listaCitas = new List<Citas>();


            //*****************************************************************************************************************
            //Se valida metodo para buscar todos los doctores asi como los pacientes se muestren en pantalla


            //******************************************



            //int cont = operaciones.tamañoLista();
            //Console.WriteLine("digite que tipo desea buscar Cliente o Doctor");
            //string tipo = Console.ReadLine();
            //string doctorLista = "";
            //if (tipo == "Doctor")
            //{
            //    while (cont >= 0)
            //    {
            //        var itemTipo = operaciones.Buscar(cont);
            //        if (itemTipo is Doctor)
            //        {
            //            doctorLista += (((Doctor)itemTipo).Nombre) + "\n";

            //        }

            //        cont--;
            //    }


            //}
            //else
            //{
            //    while (cont >= 0)
            //    {
            //        var itemTipo = operaciones.Buscar(cont);
            //        if (itemTipo is Cliente)
            //        {
            //            doctorLista += (((Cliente)itemTipo).Nombre) + "\n";

            //        }

            //        cont--;
            //    }

            //}
            //Console.WriteLine(doctorLista);




            //**********************************************
            //Termina metodo de busqueda
            //**************************************************************************************************





            //*****************************************
            //empieza metodo de insertar Citas
            //Doctores Disponibles Marco1, Marco2, Marco3
            //int horaCita = 8;
            //string docAsignado = "Marco1";


            //int cont = operaciones.tamañoLista() - 1;
            //Console.WriteLine("digite el doctor que desea buscar");
            //string tipo = Console.ReadLine();
            //string doctorLista = "";
            //if (horaCita >= 8 && horaCita <= 12)
            //{
            //    while (cont >= 0)
            //    {
            //        var itemTipo = operaciones.Buscar(cont);

            //        if ((((Doctor)itemTipo).Nombre) != docAsignado)
            //        {

            //            Citas citas = new Citas(123, docAsignado, "Diego", horaCita);

            //        }
            //        else
            //        {

            //           Console.WriteLine("El doctor requerido se encuentra ocupado");

            //        }


            //        cont--;
            //    }
            //    cont--;
            //}



            //Termina metodo citas
            //********************************************























            //int salidaMenu= 3;
            //while (salidaMenu>=1) {
            //    Console.Clear();
            //    Console.WriteLine("Que opcion desea realizar \n");
            //    Console.WriteLine("1- Insertar Cita \n 2- Eliminar Cita \n 3-Buscar Cita \n 4-Buscar Doctores o Pacientes\n");
            //    salidaMenu = Convert.ToInt32(Console.ReadLine());
            //    switch (salidaMenu) {
            //        case 1: Console.WriteLine("Indica num Cita  \n nombre paciente \n Doctor");
            //            int numCita= Convert.ToInt32(Console.ReadLine());
            //            string nombrePaciente = Console.ReadLine();
            //            string nomDoctor = Console.ReadLine();

            //            Citas Citas = new Citas(numCita, nomDoctor, nombrePaciente);
            //            listaCitas.Add(Citas);
            //            break;
            //        case 2:
            //            Console.WriteLine("Indique el ID de Cita que desea eliminar");
            //            numCita = Convert.ToInt32(Console.ReadLine());
            //            int contadortemp = 0;


            //            while (contadortemp < listaCitas.Count) {

            //                // Falta de implementar

            //                contadortemp++;
            //            }
            //            break;

            //        case 3:
            //            //Falta de implementar
            //            break;


            //        case 4:

            //            int cont = operaciones.tamañoLista();
            //            Console.WriteLine("digite que tipo desea buscar Cliente o Doctor");
            //            string tipo = Console.ReadLine();
            //            string doctorLista = "";
            //            if (tipo == "Doctor")
            //            {
            //                while (cont >= 0)
            //                {
            //                    var itemTipo = operaciones.Buscar(cont);
            //                    if (itemTipo is Doctor)
            //                    {
            //                        doctorLista += (((Doctor)itemTipo).Nombre) + "\n";

            //                    }

            //                    cont--;
            //                }


            //            }
            //            else
            //            {
            //                while (cont >= 0)
            //                {
            //                    var itemTipo = operaciones.Buscar(cont);
            //                    if (itemTipo is Cliente)
            //                    {
            //                        doctorLista += (((Cliente)itemTipo).Nombre) + "\n";

            //                    }

            //                    cont--;
            //                }

            //            }
            //            Console.WriteLine(doctorLista);
            //            break;





            //    }


            //    Console.WriteLine("Desea continuar en el menu\n 1 - continuar \n 0 salir");
            //    salidaMenu = Convert.ToInt32(Console.ReadLine());


            //}




            Console.ReadKey();



        }
    }
}

