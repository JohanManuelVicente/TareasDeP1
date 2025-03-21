// Johan Manuel Vicente B      2024-1260


Console.WriteLine("Bienvenido a mi lista de Contactes");

//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   6. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption;
    if (!int.TryParse(Console.ReadLine(), out typeOption))
    {
        Console.WriteLine("Entrada no válida, intenta de nuevo.");
        continue;
    }

    switch (typeOption)
    {
        case 1:
            AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 2:
            ViewContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 3:
            SearchContact(ids, names, lastnames);
            break;
        case 4:
            ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 5:
            DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;
    }
}


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Write("Digite el nombre: ");
    string name = Console.ReadLine();
    Console.Write("Digite el apellido: ");
    string lastname = Console.ReadLine();
    Console.Write("Digite la dirección: ");
    string address = Console.ReadLine();
    Console.Write("Digite el teléfono: ");
    string phone = Console.ReadLine();
    Console.Write("Digite el email: ");
    string email = Console.ReadLine();
    Console.Write("Digite la edad: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("¿Es mejor amigo? (1. Sí, 2. No): ");
    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    int id = ids.Count + 1;
    ids.Add(id);
    names[id] = name;
    lastnames[id] = lastname;
    addresses[id] = address;
    telephones[id] = phone;
    emails[id] = email;
    ages[id] = age;
    bestFriends[id] = isBestFriend;
}

static void ViewContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("ID	Nombre	Apellido	Dirección	Teléfono	Email	Edad	Mejor Amigo");
    Console.WriteLine("--------------------------------------------------------------------------------");
    foreach (var id in ids)
    {
        Console.WriteLine($"{id}	{names[id]}	{lastnames[id]}	{addresses[id]}	{telephones[id]}	{emails[id]}	{ages[id]}	{(bestFriends[id] ? "Sí" : "No")}");
    }
}

static void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames)
{
    Console.Write("Ingrese el nombre o apellido del contacto a buscar: ");
    string query = Console.ReadLine().ToLower();

    foreach (var id in ids)
    {
        if (names[id].ToLower().Contains(query) || lastnames[id].ToLower().Contains(query))
        {
            Console.WriteLine($"ID: {id}, Nombre: {names[id]}, Apellido: {lastnames[id]}");
        }
    }
}

static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Write("Ingrese el ID del contacto a modificar: ");
    int id = Convert.ToInt32(Console.ReadLine());

    if (!ids.Contains(id))
    {
        Console.WriteLine("Contacto no encontrado.");
        return;
    }

    Console.Write("Nuevo nombre: ");
    names[id] = Console.ReadLine();
    Console.Write("Nuevo apellido: ");
    lastnames[id] = Console.ReadLine();
    Console.Write("Nueva dirección: ");
    addresses[id] = Console.ReadLine();
    Console.Write("Nuevo teléfono: ");
    telephones[id] = Console.ReadLine();
    Console.Write("Nuevo email: ");
    emails[id] = Console.ReadLine();
    Console.Write("Nueva edad: ");
    ages[id] = Convert.ToInt32(Console.ReadLine());
    Console.Write("¿Es mejor amigo? (1. Sí, 2. No): ");
    bestFriends[id] = Convert.ToInt32(Console.ReadLine()) == 1;
}

static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Write("Ingrese el ID del contacto a eliminar: ");
    int id = Convert.ToInt32(Console.ReadLine());

    if (!ids.Contains(id))
    {
        Console.WriteLine("Contacto no encontrado.");
        return;
    }

    ids.Remove(id);
    names.Remove(id);
    lastnames.Remove(id);
    addresses.Remove(id);
    telephones.Remove(id);
    emails.Remove(id);
    ages.Remove(id);
    bestFriends.Remove(id);
    Console.WriteLine("Contacto eliminado correctamente.");
}
