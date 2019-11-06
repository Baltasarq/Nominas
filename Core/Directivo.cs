namespace Nominas.Core
{
    public class Directivo: Empleado
    {
        public const int SalarioBase = 1000;
        public const int SalarioPorHoraPrefijado = 100;

        public Directivo(string nombre)
                :base(nombre, SalarioPorHoraPrefijado)
        {
        }

        public override int CalculaNomina(int hrs)
        {
            return SalarioBase + base.CalculaNomina(hrs);
        }
    }
}
