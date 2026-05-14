using System;
using System.Security.Cryptography.X509Certificates;
class program
{
    static void Main(string[] args)
    {
        int acumulador;
        int contador;
        int maximo;
        int minimo;
        int RegistrarValor = 0;
        int opcion =0;
        double CalcularPromedio = 0;
        acumulador = 0;
        contador = 0;
        maximo = 0;
        minimo = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("1- Procesar un solo numero");
            Console.WriteLine("2- Procesar varios numeros");
            Console.WriteLine("3- Mostrar maximo y minimo");
            Console.WriteLine("4- Mostrar promedio");
            Console.WriteLine("5- Mostrar cantidad de numeros ingresados");
            Console.WriteLine("6- Reiniciar Variables");
            Console.WriteLine("7- Cerrar la consola");
            opcion = Convert.ToInt32(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Ingrese el numero");
                    RegistrarValor = Convert.ToInt32(Console.ReadLine());
                    acumulador += RegistrarValor;
                    contador++;
                    Console.WriteLine($"Numero mayor: {RegistrarValor}");
                    if (maximo == 0)
                    {
                        maximo = RegistrarValor;

                    }
                    else if (minimo == 0)
                    {
                        minimo = RegistrarValor;
                    }
                    else
                    {
                        if (RegistrarValor > maximo)
                        {
                            maximo = RegistrarValor;
                        }
                        if (minimo > RegistrarValor)
                        {
                            minimo = RegistrarValor;
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                        Console.WriteLine("Ingrese el numero");
                        RegistrarValor = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        acumulador += RegistrarValor;
                        contador++;
                        if (maximo == 0)
                        {
                            maximo = RegistrarValor;

                        }
                        if (minimo == 0)
                        {
                            minimo = RegistrarValor;
                        }
                        else
                        {
                            if (RegistrarValor > maximo)
                            {
                                maximo = RegistrarValor;
                            }
                            if (minimo > RegistrarValor)
                            {
                                minimo = RegistrarValor;
                            }
                        }
                        Console.WriteLine("Ingrese el numero");
                        RegistrarValor = Convert.ToInt32(Console.ReadLine());
                    } while (RegistrarValor != -1);

                    Console.WriteLine($"Numero mayor: {maximo}"); 
                    Console.WriteLine($"Numero menor: {minimo}");
            break;

                
            case 3:
                    Console.Clear();

                    Console.WriteLine($"Numero Maximo ingresado: {maximo}");
                Console.WriteLine($"Numero minimo ingresador: {minimo}");
                break;
            case 4:
                    Console.Clear();

                    if (contador == 0)
                    Console.WriteLine("No se registraron ingresos de numeros");
                else
                {
                    CalcularPromedio = 1.0 * ((double)acumulador / contador);
                    Console.WriteLine($"Promedio de numeros: {CalcularPromedio}");

                }
                break;
            case 5:
                    Console.Clear();

                    Console.WriteLine($"Cantidad de numero ingresador: {contador}");
                break;
            case 6:
                    Console.Clear();

                    contador = 0;
                acumulador = 0;
                maximo = 0;
                minimo = 0;
                break;
             case 7:
                    Environment.Exit(0);
                    break;

            }
        } while (opcion != 0);
    }
}
