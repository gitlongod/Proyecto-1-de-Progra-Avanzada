using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class Tarjeta : Pago
    {
        
        private string CardNumber { get; }
        private string Name { get; }
        private DateTime ExpirationDate { get; }
        private int CVV { get; }
        public Tarjeta(double amount, string cardnumber, string name, DateTime expirationdate, int cvv) : base(amount)
        {
            CardNumber = cardnumber;
            Name = name;
            ExpirationDate = expirationdate;
            CVV = cvv;
        }
        public override void ProcesoPago()
        {
                base.ProcesoPago();
            if (ExpirationDate > DateTime.Now)
            {
                Console.Clear();
                Console.WriteLine("Pago Realizado Exitosamente");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Tarjeta Vencida");
                Console.ReadKey();
            }
        }
    }
}
