namespace Nominas.Ui
{
    using System;
    using Core;

    class MainClass
    {
        public static void Main(string[] args)
        {
            Empleado d = new Directivo("Tío Gilito");
            Empleado o = new Obrero("Pato Donald");
            var empresa = new Empresa();

            empresa.Empleados = new Empleado[] { d, o };

            foreach(Empleado empleado in empresa.Empleados)
            {
                Console.Write( empleado );
                Console.WriteLine( " nómina: " + empleado.CalculaNomina(10) );
            }
        }
    }
}
