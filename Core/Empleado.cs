namespace Nominas.Core
{
    public abstract class Empleado
    {
        protected Empleado(string nombre, int salarioPorHora)
        {
            this.Nombre = nombre;
            this.SalarioPorHora = salarioPorHora;
        }

        public int SalarioPorHora
        {
            get; set;
        }

        public string Nombre
        {
            get; set;
        }

        public virtual int CalculaNomina(int horas)
        {
            return this.SalarioPorHora * horas;
        }

        public override string ToString()
        {
            return "Empleado: " + this.Nombre
                    + " salario/hora: " + this.SalarioPorHora;
        }
    }
}
