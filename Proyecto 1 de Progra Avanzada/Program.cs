using Proyecto_1_de_Progra_Avanzada;
Parqueo parqueo = new Parqueo();    


do
{
    try
    {
        Console.Clear();
        ShowMenu(ref Carro.Carros, ref Moto.motos, ref VehiculoPesado.vehiculoPesado,ref parqueo);
	}
	catch (Exception ex)
	{

        Console.WriteLine(ex.Message);
        Console.WriteLine("Ingrese una opción Válida");
        Console.ReadKey();
    }
} while (true);


 int Menu()
{
  
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nBIENVENIDO AL PARQUEO DE LA CRUZ");
    Console.ResetColor();
    Console.WriteLine("INGRESE UNA OPCIÓN ");
    Console.WriteLine("1.Registrar Vehículos");
    Console.WriteLine("2.Retiro de Vehículos");
    Console.WriteLine("3.Visualización de vehículos estacionados");
    Console.WriteLine("4.Visualización de espacios disponibles");
    Console.WriteLine("5.Salir");
    int option = int.Parse(Console.ReadLine());
  
    return option;
}
 void ShowMenu(ref List<Carro> carros, ref List<Moto> motos, ref List<VehiculoPesado>  vehiculoPesados,ref Parqueo parqueo)
{
    switch (Menu())
    {
        case 1:
            Vehiculos.AddVehiculo(ref carros, ref motos, ref vehiculoPesados, parqueo);
            break;
        case 2:
            Vehiculos.RetirarVehiculo(ref carros, ref motos, ref vehiculoPesados,parqueo);
            break;
        case 3:
            Vehiculos.ShowInfo(ref carros, ref motos, ref vehiculoPesados);
            break;
            case 4:
            parqueo.MostrarEspaciosDisponibles();
            break;
            case 5:
            return;
            
    }
}

