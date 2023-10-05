// See https://aka.ms/new-console-template for more information
Console.WriteLine("\t\t\tAlgoritmo para mostrar una figura en base a una variable");
Console.WriteLine("\t\t\t*********************************************************\n");
Console.WriteLine("Inserte una variable y luego ponga 'enter' para continuar o presione 'espacio' para cerrar el programa: \n");
ConsoleKey tecla;

do
{
    Console.Write("Ingrese un número: ");
    int numero = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    for (int i = 1; i <= numero; i++)
    {
        for (int j = 1; j < numero * 2; j++)
        {
            Console.Write("*");

        }
        Console.WriteLine("*");
    }
    tecla = Console.ReadKey().Key;
} while (tecla != ConsoleKey.Spacebar);