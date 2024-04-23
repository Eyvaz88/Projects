//variables

using System.ComponentModel;

int pass = 12345;
int passIngresado;
string perfilIngresado;

Console.WriteLine("ingrese su perfil");
perfilIngresado = Console.ReadLine();
Console.WriteLine("ingrese su contrasenia");
passIngresado = Convert.ToInt32(Console.ReadLine());

if (pass == passIngresado)
{
    switch (perfilIngresado)
    {
        case "A":
            Console.WriteLine("Bienvenido Admin");
            break;
        case "U":
            Console.WriteLine("Bienvenido usuario");
            break;
        default:
            Console.WriteLine("Bienvenido anonimo");
            break ;
    }
}
