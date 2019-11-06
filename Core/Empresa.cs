namespace Nominas.Core
{
    using System.Collections.Generic;

    public class Empresa
    {
        public Empresa()
        {
            this.empleados = new List<Empleado>();
        }

        public Empleado[] Empleados
        {
            get
            {
                return this.empleados.ToArray();
            }
            set
            {
                this.empleados.AddRange( value );
            }
        }

        List<Empleado> empleados;
    }
}
