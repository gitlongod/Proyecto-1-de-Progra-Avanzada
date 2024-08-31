using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class VehiculoPesado: Vehiculos
    {
        public static List <VehiculoPesado> vehiculoPesado = new List<VehiculoPesado> ();
        private double tarifa;
        public double Taria
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        public VehiculoPesado(string matricula, string marca, string modelo, string type,DateTime date) : base(matricula, marca, modelo, type, date)
        {

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Type = "Vehículo Pesado";
        }
        public override double GetTarifa()
        {
            base.GetTarifa();
            int horasParqueo = (int)Math.Ceiling(GetTarifaTimeout().TotalHours);
            return horasParqueo * tarifa;
        }
    }
}
