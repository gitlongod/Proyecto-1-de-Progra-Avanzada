using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class Parqueo
    {
        public int EspaciosCarro { get; set; }
        public int EspaciosMoto { get; set; }
        public int EspaciosVehiculoPesado { get; set; }

        public Parqueo()
        {
            Console.WriteLine("Ingrese la cantidad de espacios para Carros:");
            EspaciosCarro = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de espacios para Motos:");
            EspaciosMoto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de espacios para Vehículos Pesados:");
            EspaciosVehiculoPesado = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SE HAN CONFIGURADO LOS ESPACIOS DE PARQUEO");
            Console.ResetColor();
        }
        public void MostrarEspaciosDisponibles()
        {
            Console.WriteLine("\nESPACIOS DISPONIBLES EN EL PARQUEO:");
            Console.WriteLine($"Carros: {EspaciosCarro}");
            Console.WriteLine($"Motos: {EspaciosMoto}");
            Console.WriteLine($"Vehículos Pesados: {EspaciosVehiculoPesado}");
            Console.ReadKey();
        }
    }
}


