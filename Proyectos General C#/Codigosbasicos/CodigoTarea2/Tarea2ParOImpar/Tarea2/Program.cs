
// Johan Manuel Vicente    2024-1260
Console.Write("Introduzca un número entero: ");
string input = Console.ReadLine(); // Leer la entrada como string
int number;

// convertir la entrada string a un número entero
// convertir la entrada string a un número entero
if (int.TryParse(input, out number))
{
    // Verificar si el número es par o impar
    if (number % 2 == 0)
    {
        Console.WriteLine("El número " + number + " es PAR.");
    }
    else
    {
        Console.WriteLine("El número " + number + " es IMPAR.");
    }
}
else

    Console.WriteLine("Error: No ingresaste un número entero válido.");

Console.ReadKey();

