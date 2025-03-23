//JOHAN MANUEL VICENTE BERROA

//CLASE PUBLICA CONTACTO
public class Contacto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }

    public Contacto(int id, string nombre, string telefono, string email, string direccion)
    {
        Id = id;
        Nombre = nombre;
        Telefono = telefono;
        Email = email;
        Direccion = direccion;
    }

    public override string ToString()
    {
        return $"{Id}    {Nombre}    {Telefono}    {Email}    {Direccion}";
    }
}


//CLASE PUBLICA AGENDA

public class Agenda
{
    private List<Contacto> contactos;
    private int idCounter;

    public Agenda()
    {
        contactos = new List<Contacto>();
        idCounter = 1;
    }


    public void AgregarContacto(string nombre, string telefono, string email, string direccion)
    {
        var nuevoContacto = new Contacto(idCounter++, nombre, telefono, email, direccion);
        contactos.Add(nuevoContacto);
    }


    public void VerContactos()
    {
        Console.WriteLine("Id           Nombre          Telefono            Email           Dirección");
        Console.WriteLine("___________________________________________________________________________");

        foreach (var contacto in contactos)
        {
            Console.WriteLine(contacto);
        }
    }

    public Contacto BuscarContacto(int id)
    {
        return contactos.Find(c => c.Id == id);
    }

    public void ModificarContacto(int id, string nombre, string telefono, string email, string direccion)
    {
        var contacto = BuscarContacto(id);
        if (contacto != null)
        {
            contacto.Nombre = nombre;
            contacto.Telefono = telefono;
            contacto.Email = email;
            contacto.Direccion = direccion;
        }
    }


    public void EliminarContacto(int id)
    {
        var contacto = BuscarContacto(id);
        if (contacto != null)
        {
            contactos.Remove(contacto);
        }
    }
}


//CLASE PRINCIPAL
class Contactes
{
    static void Main(string[] args)
    {
     
        Agenda agenda = new Agenda();

        
        agenda.AgregarContacto("Juan Perez", "809-857-5887", "juan.perez@gmail.com", "Calle 123");
        agenda.AgregarContacto("Maria Lopez", "809-857-5855", "maria.lopez@gmail.com", "Avenida Jacobo Majluta 456");

        
        agenda.VerContactos();

        
        var contacto = agenda.BuscarContacto(1);
        if (contacto != null)
        {
            Console.WriteLine($"Contacto encontrado: {contacto}");
        }

        agenda.ModificarContacto(1, "Juan Perez", "809-515-5144", "juan.perez@gmail.com", "Calle Esperanza no 54");

        
        agenda.VerContactos();

        
        agenda.EliminarContacto(2);

     
        agenda.VerContactos();
    }
}

