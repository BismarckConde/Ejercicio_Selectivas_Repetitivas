Console.WriteLine("\t¡BIENVENIDO AL PROGRAMA DE SUMA DE NUMEROS POSITIVOS Y NEGATIVOS!");
Console.WriteLine();

Console.WriteLine("Por favor, ingrese 9 numeros enteros.");

int positivos = 0;
int negativos = 0;

for (int i = 0; i < 9; i++)
{
    int num = 0;
    bool valido = false;

    while (!valido)
    {
        Console.Write("Ingrese el numero {0}: ", i + 1);
        valido = int.TryParse(Console.ReadLine(), out num);

        if (!valido)
        {
            Console.WriteLine("¡ERROR! necesita ingresar un numero entero valido...");
        }
    }
    if (num > 0)
    {
        positivos += num;
    }
    else if (num < 0)
    {
        negativos += num;
    }
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nLa suma de los numeros positivos es: " + positivos);
Console.WriteLine("\nLa suma de los numeros negativos es: " + negativos);
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nGracias por usar el programa. Presione cualquier tecla para salir.");
Console.ReadKey();