using System;

class Program
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

