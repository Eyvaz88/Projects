// See https://aka.ms/new-console-template for more information



Console.WriteLine("Bienvenidos!");

string nombre;
nombre = "Alex";

const int dni = 34001115;


Console.WriteLine("Mi nombre es: " + nombre);

string apellido = "Eyvazian";

Console.WriteLine("Mi apellido es: " + apellido);


Console.WriteLine("Mi DNI es: "+dni);

///// Ejemplo 2
int num1;
int num2;

Console.WriteLine("Ingrese el primer numero a sumar.");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero a sumar.");
num2 = Convert.ToInt32(Console.ReadLine());

int total = num1 + num2;
Console.WriteLine("el total de la suma es: "+total);

//Ejemplo 3 concatenar

Console.WriteLine("Mi nombre es {0} {1} {2}.",nombre,"Ricardo",apellido);

string mensaje = $"Mi nombre es {nombre} Ricardo {apellido}";
Console.WriteLine(mensaje);

//pide una tecla para cerrar el programa
Console.ReadKey();