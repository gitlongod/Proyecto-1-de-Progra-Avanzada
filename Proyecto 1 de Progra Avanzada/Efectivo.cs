using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class Efectivo : Pago
    {
        private double CashAmount { get; }
        public Efectivo(double amount, double cashamount) : base(amount)
        {
            CashAmount = cashamount;
        }
        public override void ProcesoPago()
        {
            if (CashAmount >= Amount)
            {
                Console.Clear();
                double changeAmount = CashAmount - Amount;
                Console.WriteLine("Pago Realizado con Éxito");
                Console.WriteLine($"Cambio: Q.{changeAmount:F2}");
                ChangeToGive(changeAmount);
            }
            else
            {
                Console.WriteLine("Monto Insuficiente");
                Console.ReadKey();
            }
        }
        private void ChangeToGive(double changeAmount)
        {
            int[] billetes = { 200, 100, 50, 20, 10, 5, 1 };
            foreach (int bill in billetes)
            {
                int quantity = (int)(changeAmount / bill);
                if (quantity > 0)
                {
                    Console.WriteLine($"{quantity} Billetes de Q.{bill}.00");
                    changeAmount -= quantity * bill;
                }
            }
        }
    }
}
