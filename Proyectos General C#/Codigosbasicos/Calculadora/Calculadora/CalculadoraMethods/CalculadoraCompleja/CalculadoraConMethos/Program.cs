// Johan Manuel Vicente B      2024-1260

List<decimal> typedNumbers = new List<decimal>();
decimal result = 0;
int typedOption = 1;
bool running = true;

Console.WriteLine("This is the best calculator");

while (running)
{
    DisplayHeader();

    try
    {
        typedOption = Convert.ToInt32(Console.ReadLine());

        if (typedOption == 5)
        {
            running = false;
        }
        else
        {
            typedNumbers = GetNumbersFromUser();

            switch (typedOption)
            {
                case 1:
                    result = AddList(typedNumbers);
                    break;
                case 2:
                    result = SubtractList(typedNumbers);
                    break;
                case 3:
                    result = MultiplyList(typedNumbers);
                    break;
                case 4:
                    result = DivideList(typedNumbers);
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine($"The Result of the operation is: {result}");
        }
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"You cannot divide by zero: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"You need to choose a correct option: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Closing DB Connection");
    }
}
    

    static List<decimal> GetNumbersFromUser()
{
    List<decimal> numbers = new List<decimal>();
    Console.WriteLine("Please type the first number:");
    numbers.Add(Convert.ToDecimal(Console.ReadLine()));

    Console.WriteLine("Please type the second number:");
    numbers.Add(Convert.ToDecimal(Console.ReadLine()));

    while (true)
    {
        Console.WriteLine("Do you want to continue inserting numbers? 1. Yes, 2. No");
        int option = Convert.ToInt32(Console.ReadLine());
        if (option == 2)
            break;

        Console.WriteLine("Please type another number:");
        numbers.Add(Convert.ToDecimal(Console.ReadLine()));
    }
    return numbers;
}

static decimal AddList(List<decimal> numbers)
{
    decimal result = 0;
    foreach (decimal num in numbers)
    {
        result += num;
    }
    return result;
}

static decimal SubtractList(List<decimal> numbers)
{
    decimal result = numbers[0];
    for (int i = 1; i < numbers.Count; i++)
    {
        result -= numbers[i];
    }
    return result;
}

static decimal MultiplyList(List<decimal> numbers)
{
    decimal result = 1;
    foreach (decimal num in numbers)
    {
        result *= num;
    }
    return result;
}

static decimal DivideList(List<decimal> numbers)
{
    decimal result = numbers[0];
    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] == 0)
            throw new DivideByZeroException("Cannot divide by zero");
        result /= numbers[i];
    }
    return result;
}

static void DisplayHeader()
{
    Console.WriteLine("Please type the option number that you want");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("1. Sum, \n2. Subtract,  \n3. Multiplication,  \n4. Division,  \n5. Exit");
}
