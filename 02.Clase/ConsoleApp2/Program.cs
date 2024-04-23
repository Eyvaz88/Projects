// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//switch

string categoria;
Console.WriteLine("Ingrese la categoria A, B, C o D");

categoria = Console.ReadLine();

switch(categoria)
{
    //tanto A o D hace lo mismo
    case "A":
    case "D":
        Console.WriteLine("Empleado administrativo");
        break;
    case "B":
        Console.WriteLine("Empleado Profesional");
        break; 
    case "C":
        Console.WriteLine("Empleado Maestraza");
        break;
    default:
        Console.WriteLine("Sin Categoria");
        break;

}


// Escuela

string comision;
int calificacion;

Console.WriteLine("Bienvenidos");
Console.WriteLine("Ingrese su comision");
comision = Console.ReadLine();

switch (comision)
{
    //tanto A o D hace lo mismo
    case "A":
        Console.WriteLine("Turno Maniana");
        break;
    case "B":
        Console.WriteLine("Turno Tarde");
        break;
    case "C":
        Console.WriteLine("Turno Noche");
        break;
    default:
        Console.WriteLine("Sin turno fijo");
        break;

}

Console.WriteLine("Ingrese la nota del alumno");

calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 0 && calificacion < 4)
{
    Console.WriteLine("Recursa");
}else if (calificacion >= 4 && calificacion < 7)
{
    Console.WriteLine("Alumno aprueba cursada");
}else if (calificacion >= 7 && calificacion<=10)
{
    Console.WriteLine("Alumno promociona");
}
else
{
    Console.WriteLine("Por favor ingrese valor valido");
}