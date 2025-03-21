using System;
using System.Collections.Generic;

public class Agenda
{
    private List<Contacto> contactos;
    private int idCounter;

    public Agenda()
    {
        contactos = new List<Contacto>();
        idCounter = 1; // Empezamos con id 1
    }

    // Agregar un nuevo contacto
    public void AgregarContacto(string nombre, string telefono, string email, string direccion)
    {
        var nuevoContacto = new Contacto(idCounter++, nombre, telefono, email, direccion);
        contactos.Add(nuevoContacto);
    }

    // Mostrar todos los contactos
    public void VerContactos()
    {
        Console.WriteLine("Id           Nombre          Telefono            Email           Dirección");
        Console.WriteLine("___________________________________________________________________________");

        foreach (var contacto in contactos)
        {
            Console.WriteLine(contacto);
        }
    }

    // Buscar un contacto por su Id
    public Contacto BuscarContacto(int id)
    {
        return contactos.Find(c => c.Id == id);
    }

    // Modificar un contacto
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

    // Eliminar un contacto
    public void EliminarContacto(int id)
    {
        var contacto = BuscarContacto(id);
        if (contacto != null)
        {
            contactos.Remove(contacto);
        }
    }
}
