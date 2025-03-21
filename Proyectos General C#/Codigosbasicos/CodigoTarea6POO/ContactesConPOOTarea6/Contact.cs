public class Contacto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }

    // Constructor
    public Contacto(int id, string nombre, string telefono, string email, string direccion)
    {
        Id = id;
        Nombre = nombre;
        Telefono = telefono;
        Email = email;
        Direccion = direccion;
    }

    // Método ToString para mostrar la información del contacto
    public override string ToString()
    {
        return $"{Id}    {Nombre}    {Telefono}    {Email}    {Direccion}";
    }
}



