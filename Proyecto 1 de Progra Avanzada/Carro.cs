using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class Carro : Vehiculos
    {
        public static List<Carro> Carros = new List<Carro>();
        private double tarifa = 10.00;
        public Carro(string matricula, string marca, string modelo, string type, DateTime date) : base(matricula, marca, modelo, type, date)
        {
            
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Type = "Carro";
        }

        public override double GetTarifa()
        {
            base.GetTarifa();
            int horasParqueo = (int)Math.Ceiling(GetTarifaTimeout().TotalHours);
            return horasParqueo * tarifa;
        }
       
    }
}