﻿namespace Nominas.Ui
{
    using System;
    using Core;

    class MainClass
    {
        public static void Main(string[] args)
        {
            Empleado d = new Directivo("Tío Gilito");
            Empleado d2 = new Directivo("Daisy");
            Empleado o = new Obrero("Pato Donald");
            Empleado o2 = new Obrero("Jaimito");
            var empresa = new Empresa();

            empresa.Empleados = new Empleado[] { d, d2, o, o2 };

            foreach(Empleado empleado in empresa.Empleados)
            {
                Console.Write( empleado );
                Console.WriteLine( " nómina: " + empleado.CalculaNomina(10) );
            }
        }
    }
}
