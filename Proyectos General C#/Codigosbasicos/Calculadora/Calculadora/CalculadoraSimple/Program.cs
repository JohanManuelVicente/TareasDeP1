
decimal num1;
decimal num2;
int typedOperation;

Console.WriteLine("Bienvenido a mi calculadora");
Console.WriteLine("Inserte el primier número que desea sumar. (Debe ser un valor numerico, decimal o entero)");
num1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Inserte el segundo número que desea sumar. (Debe ser un valor numerico, decimal o entero)");
num2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite 1, 2, 3, 4");
typedOperation = int.Parse(Console.ReadLine());

decimal result = 0;

if (typedOperation == 1)
{
    result = num1 + num2;
}
else if (typedOperation == 2)
{
    result = num1 - num2;
}
else if (typedOperation == 3)
{
    result = num1 * num2;
}
else if (typedOperation == 4)
{
    result = num1 / num2;
}

else
{
    result = 0;
}
Console.WriteLine($"El resultado es: {result}");
