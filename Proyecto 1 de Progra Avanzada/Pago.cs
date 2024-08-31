using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class Pago
    {
        protected double Amount { get; set; }
        protected Pago(double amount)
        {
            Amount = amount;
        }
        public virtual void ProcesoPago()
        {

        }
    }
}
