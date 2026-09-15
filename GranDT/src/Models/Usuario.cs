//De nuestros usuarios, es importante conocer su nombre, apellido, email (único por cada usuario),
//fecha de nacimiento y contraseña. El sistema deberá soportar hasta 2000 usuarios. Es importante tener en cuenta que
//para la persistencia del usuario, mediante un algoritmo de encriptación, todas las contraseñas tendrán una longitud 
//fija de 64 caracteres.
using System;

public class Usuario
{
    public int idUsuario;
    public string Nombre;
    public string Apellido;
    public string Email; //falta poner que sea unico
    public DateTime FechaNacimiento;
    public string Contraseña;
}