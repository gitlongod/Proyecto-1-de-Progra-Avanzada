using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_de_Progra_Avanzada
{
    public class Vehiculos
    {
        public static List<Vehiculos> vehiculosList = new List<Vehiculos>();
        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }


        public Vehiculos(string matricula, string marca, string modelo, string type, DateTime date)
        {
            this.matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Type = type;
            Date = date;


        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nMatrícula : {matricula}");
            Console.WriteLine($"\nMarca : {Marca}");
            Console.WriteLine($"\nModelo: {Modelo}");
            Console.WriteLine($"\nTipo : {Type}");
            Console.WriteLine($"\n Hora de Entrada {Date}");
        } 
        
        public static void AddVehiculo(ref List<Carro> carros, ref List<Moto>motos, ref List<VehiculoPesado> vehiculoPesados,Parqueo parqueo)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese el tipo de vehículo a ingresar");
            Console.ResetColor();
            Console.WriteLine("1. Carro");
            Console.WriteLine("2. Moto");
            Console.WriteLine("3. Vehículo Pesado");
            int option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:

                    string type = "Carro";

                    if (carros.Count <= parqueo.EspaciosCarro)
                    {
                        Console.WriteLine("\nIngrese la matrícula del vehículo");
                        string matriculaCar = Console.ReadLine();
                        Carro matriculaValidation = carros.Find(x => x.Matricula == matriculaCar);
                        if (matriculaValidation == null)
                            {
                                Console.WriteLine("\nIngrese la Marca del vehículo");
                                string marcaCar = Console.ReadLine();
                                Console.WriteLine("\nIngrese el modelo del vehículo");
                                string modeloCar = Console.ReadLine();
                                DateTime date = DateTime.Now;
                                carros.Add(new Carro(matriculaCar, marcaCar, modeloCar, type, date));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Se ha Ingresado el carro");
                                parqueo.EspaciosCarro--;
                                Console.ResetColor();
                                Console.ReadKey();

                            }                     
                        else
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("ya existe está matrícula del carro ingresado");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El parque para carros está lleno no puede ingresar");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    break;
                    case 2:
                    string type2 = "Moto";
                    if (motos.Count <= parqueo.EspaciosMoto)
                    {

                        Console.WriteLine("\nIngrese la matrícula del vehículo");
                        string matriculaMoto = Console.ReadLine();
                        Moto validationMoto = motos.Find(p=>p.Matricula == matriculaMoto);
                        if (validationMoto == null)
                        {
                            Console.WriteLine("\nIngrese la Marca del vehículo");
                            string marcaCar = Console.ReadLine();
                            Console.WriteLine("\nIngrese el modelo del vehículo");
                            string modeloCar = Console.ReadLine();
                            DateTime date = DateTime.Now;
                            motos.Add(new Moto(matriculaMoto, marcaCar, modeloCar, type2, date));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Se ha ingresado la moto correctamente");
                            parqueo.EspaciosMoto--;
                            Console.ResetColor();
                            Console.ReadKey(); 
                        } 
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ya existe está matrícula de la moto ingresada");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El parque para motos está lleno no puede ingresar");
                        Console.ResetColor();
                        Console.ReadKey();
                    }

                    break;
                    case 3:
                    string type3 = "Vehículo Pesado";
                    if (vehiculoPesados.Count <= parqueo.EspaciosVehiculoPesado )
                    {
                        Console.WriteLine("\nIngrese la matrícula del vehículo");
                        string matriculaCar = Console.ReadLine();
                        Console.WriteLine("\nIngrese la Marca del vehículo");
                        string marcaCar = Console.ReadLine();
                        Console.WriteLine("\nIngrese el modelo del vehículo");
                        string modeloCar = Console.ReadLine();
                        DateTime date = DateTime.Now;
                        vehiculoPesados.Add(new VehiculoPesado(matriculaCar, marcaCar, modeloCar, type3, date));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Se ha ingresado el vehículo pesado correctamente");
                        parqueo.EspaciosVehiculoPesado--;
                        Console.ResetColor();
                        Console.ReadKey(); 
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El parque para vehículo pesado  está lleno no puede ingresar");
                        Console.ResetColor();
                        Console.ReadKey();
                    }

                    break;
            }
        }
        public virtual double GetTarifa()
        {
            return 0;
        }
        public TimeSpan GetTarifaTimeout()
        {
            return DateTime.Now - Date;
        }
       public static void RetirarVehiculo(ref List<Carro> carros, ref List<Moto> motos, ref List<VehiculoPesado> vehiculoPesados, Parqueo parqueo )
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tipo de vehículo que desea retirar");
            Console.WriteLine("1.Carro");
            Console.WriteLine("2.Moto");
            Console.WriteLine("3.Vehículo Pesado");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Ingrese la matricula del carro ");
                    string searchMatricula = Console.ReadLine();
                    Carro searchCarro = carros.Find(p => p.Matricula == searchMatricula);
                    if (searchCarro != null)
                    {
                     
                        double costoTotal = searchCarro.GetTarifa();
                        Console.WriteLine($"Tiempo estacionado : {searchCarro.GetTarifaTimeout().TotalHours}");
                        Console.WriteLine($"\nCosto Total : {costoTotal}");
                        Console.WriteLine("Ingrese el tipo de pago");
                        Console.WriteLine("1.Tarjeta");
                        Console.WriteLine("2.Efectivo");
                        int metodoPago = int.Parse(Console.ReadLine());
                        switch (metodoPago)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el número de la tarjeta");
                                string numTarjeta = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre a quien pertenece");
                                string name = Console.ReadLine();
                                Console.WriteLine("Ingrese la fecha de vencimiento de la tarjeta");
                                DateTime expirationDate = DateTime.ParseExact(Console.ReadLine(), "mm/yy", null);

                                if (expirationDate > DateTime.Now)
                                {
                                    Console.WriteLine("Ingrese el CVV");
                                    int cvv = int.Parse(Console.ReadLine());
                                    Tarjeta validation = new Tarjeta(costoTotal, numTarjeta, name, expirationDate, cvv);
                                    validation.ProcesoPago();
                                    carros.Remove(searchCarro);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Carro retirado con exito");
                                    parqueo.EspaciosCarro++;
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                else
                                {
                                    Console.ForegroundColor= ConsoleColor.Red;
                                    Console.WriteLine("Ingrese una fecha de tarjeta valida");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                    break;
                            case 2:
                                Console.WriteLine("Ingrese la cantidad de efectivo con la que se pago");
                                double amount = double.Parse(Console.ReadLine());
                                Efectivo efectivo = new Efectivo(costoTotal,amount);
                                efectivo.ProcesoPago();
                                carros.Remove(searchCarro); 
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Carro retirado con éxito");
                                parqueo.EspaciosCarro++;
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La placa del carro no existe en el parqueo ingrese una placa existente");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                        break;
                    case 2:
                    Console.WriteLine("Ingrese la matricula de la moto ");
                    string searchMatricula1 = Console.ReadLine();
                    Moto searchMoto = motos.Find(p => p.Matricula == searchMatricula1);
                    if (searchMoto != null)
                    {
                        double costoTotal = searchMoto.GetTarifa();
                        Console.WriteLine($"Tiempo estacionado : {searchMoto.GetTarifaTimeout().TotalHours}");
                        Console.WriteLine($"\nCosto Total : {costoTotal}");
                        Console.WriteLine("Ingrese el tipo de pago");
                        Console.WriteLine("1.Tarjeta");
                        Console.WriteLine("2.Efectivo");
                        int pago2 = int.Parse(Console.ReadLine());

                        switch (pago2)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el número de la tarjeta");
                                string numTarjeta = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre a quien pertenece");
                                string name = Console.ReadLine();
                                Console.WriteLine("Ingrese la fecha de vencimiento de la tarjeta");
                                DateTime expirationDate = DateTime.ParseExact(Console.ReadLine(), "mm/yy", null);
                                if (expirationDate  > DateTime.Now)
                                {
                                    Console.WriteLine("Ingrese el CVV");
                                    int cvv = int.Parse(Console.ReadLine());
                                    Tarjeta validation = new Tarjeta(costoTotal, numTarjeta, name, expirationDate, cvv);
                                    validation.ProcesoPago();
                                    motos.Remove(searchMoto);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Carro retirado con exito");
                                    parqueo.EspaciosMoto++;
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ingrese una fecha de tarjeta valida");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                    break;
                            case 2:
                                Console.WriteLine("Ingrese la cantidad de efectivo con la que se pago");
                                double amount = double.Parse(Console.ReadLine());
                                Efectivo efectivo = new Efectivo(costoTotal, amount);
                                efectivo.ProcesoPago();
                                motos.Remove(searchMoto);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Carro retirado con éxito");
                                parqueo.EspaciosMoto++;
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La placa de la moto no existe en el parqueo ingrese una placa existente");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                        break;
                    case 3:
                    Console.WriteLine("Ingrese la matricula del vehículo pesado ");
                    string searchMatricula2 = Console.ReadLine();
                    VehiculoPesado searchVehiculoPesado = vehiculoPesados.Find(p => p.Matricula == searchMatricula2);
                    if (searchVehiculoPesado != null)
                    {
                        double costoTotal = searchVehiculoPesado.GetTarifa();
                        Console.WriteLine($"Tiempo estacionado : {searchVehiculoPesado.GetTarifaTimeout().TotalHours}");
                        Console.WriteLine($"\nCosto Total : {costoTotal}");
                        Console.WriteLine("Ingrese el tipo de pago");
                        Console.WriteLine("1.Tarjeta");
                        Console.WriteLine("2.Efectivo");
                        int pago3 = int.Parse(Console.ReadLine());
                        switch (pago3)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el número de la tarjeta");
                                string numTarjeta = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre a quien pertenece");
                                string name = Console.ReadLine();
                                Console.WriteLine("Ingrese la fecha de vencimiento de la tarjeta");
                                DateTime expirationDate = DateTime.ParseExact(Console.ReadLine(), "mm/yy", null);

                                if (expirationDate > DateTime.Now)
                                {
                                    Console.WriteLine("Ingrese el CVV");
                                    int cvv = int.Parse(Console.ReadLine());
                                    Tarjeta validation = new Tarjeta(costoTotal, numTarjeta, name, expirationDate, cvv);
                                    validation.ProcesoPago();
                                    vehiculoPesados.Remove(searchVehiculoPesado);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Carro retirado con exito");
                                    parqueo.EspaciosVehiculoPesado++;
                                    Console.ResetColor();
                                    Console.ReadKey(); 
                                }
                                else
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ingrese una fecha de tarjeta valida");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                    break;
                            case 2:
                                Console.WriteLine("Ingrese la cantidad de efectivo con la que se pago");
                                double amount = double.Parse(Console.ReadLine());
                                Efectivo efectivo = new Efectivo(costoTotal, amount);
                                efectivo.ProcesoPago();
                                vehiculoPesados.Remove(searchVehiculoPesado);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Carro retirado con éxito");
                                parqueo.EspaciosVehiculoPesado++;
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                        }
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La placa del vehículo pesado no existe en el parqueo ingrese una placa existente");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                        break;
                   
            }
        }
        public static void ShowInfo(ref List<Carro> carros, ref List<Moto> motos, ref List<VehiculoPesado> vehiculoPesados)
        {
            Console.Clear();
            foreach (Carro carro in carros)
            {
                Console.WriteLine($"Matricula :{carro.Matricula} | Marca: {carro.Marca}| Modelo : {carro.Modelo} Tipo : {carro.Type}");
                
            }
            foreach (Moto moto in motos)
            {
                Console.WriteLine($"Matricula :{moto.Matricula} | Marca: {moto.Marca}| Modelo : {moto.Modelo} Tipo : {moto.Type}");
              
            }
            foreach (VehiculoPesado vehiculoPesado in vehiculoPesados)
            {
                Console.WriteLine($"Matricula :{vehiculoPesado.Matricula} | Marca: {vehiculoPesado.Marca}| Modelo : {vehiculoPesado.Modelo} Tipo : {vehiculoPesado.Type}");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}

