using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mi Agenda Perrón");
        Console.WriteLine("Bienvenido a tu lista de contactos");

        Agenda agenda = new Agenda();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Agregar Contacto      2. Ver Contactos     3. Buscar Contactos      4. Modificar Contacto        5. Eliminar Contacto     6. Salir");
            Console.Write("Elige una opción: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AgregarContacto(agenda);
                    break;
                case 2:
                    agenda.VerContactos();
                    break;
                case 3:
                    BuscarContacto(agenda);
                    break;
                case 4:
                    ModificarContacto(agenda);
                    break;
                case 5:
                    EliminarContacto(agenda);
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    // Agregar contacto
    static void AgregarContacto(Agenda agenda)
    {
        Console.WriteLine("Vamos a agregar un contacto.");

        Console.Write("Digite el Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Digite el Teléfono: ");
        string telefono = Console.ReadLine();

        Console.Write("Digite el Email: ");
        string email = Console.ReadLine();

        Console.Write("Digite la Dirección: ");
        string direccion = Console.ReadLine();

        agenda.AgregarContacto(nombre, telefono, email, direccion);
    }

    // Buscar contacto
    static void BuscarContacto(Agenda agenda)
    {
        Console.Write("Digite el Id del contacto que desea buscar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var contacto = agenda.BuscarContacto(id);
        if (contacto != null)
        {
            Console.WriteLine(contacto);
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    // Modificar contacto
    static void ModificarContacto(Agenda agenda)
    {
        Console.Write("Digite el Id del contacto que desea modificar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var contacto = agenda.BuscarContacto(id);
        if (contacto != null)
        {
            Console.WriteLine($"El nombre actual es: {contacto.Nombre}");
            Console.Write("Digite el nuevo Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine($"El Teléfono actual es: {contacto.Telefono}");
            Console.Write("Digite el nuevo Teléfono: ");
            string telefono = Console.ReadLine();

            Console.WriteLine($"El Email actual es: {contacto.Email}");
            Console.Write("Digite el nuevo Email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"La Dirección actual es: {contacto.Direccion}");
            Console.Write("Digite la nueva Dirección: ");
            string direccion = Console.ReadLine();

            agenda.ModificarContacto(id, nombre, telefono, email, direccion);
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    // Eliminar contacto
    static void EliminarContacto(Agenda agenda)
    {
        Console.Write("Digite el Id del contacto que desea eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var contacto = agenda.BuscarContacto(id);
        if (contacto != null)
        {
            Console.WriteLine($"¿Está seguro de eliminar el contacto {contacto.Nombre}? (1. Sí, 2. No)");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                agenda.EliminarContacto(id);
                Console.WriteLine("Contacto eliminado.");
            }
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
}
