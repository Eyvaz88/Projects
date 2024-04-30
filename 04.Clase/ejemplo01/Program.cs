using System;

int sumar (int num1,int num2)
{
    return num1 + num2;
}

Console.WriteLine("Ingrese los numeros a sumar");
Console.WriteLine("Ingrese el numero 1 a sumar");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el numero 2 a sumar");
int numero2 = int.Parse(Console.ReadLine());


int total = sumar(numero1, numero2);

Console.WriteLine("el total es: {0}.", total);
