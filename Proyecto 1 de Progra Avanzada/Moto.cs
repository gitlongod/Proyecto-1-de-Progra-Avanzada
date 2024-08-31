using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class Moto : Vehiculos
    {
        public static List<Moto> motos = new List<Moto>();
        public double tarifa = 5.00;
        public Moto(string matricula, string marca, string modelo, string type,DateTime date) : base(matricula, marca, modelo, type,date)
        {

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Type = "Moto";
        }
        public override double GetTarifa()
        {
            base.GetTarifa();
            int horasParqueo = (int)Math.Ceiling(GetTarifaTimeout().TotalHours);
            return horasParqueo * tarifa;
        }
    }
}
