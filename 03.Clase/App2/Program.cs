﻿int cantidadDeNotas = 0;
double promedioNotas  = 0;
double nota;
double sumaNotas = 0;

Console.WriteLine("Ingrese la cantidad de notas a calcular");
cantidadDeNotas = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidadDeNotas; i++)
{
    Console.WriteLine("Ingrese nota " + i);
    nota = double.Parse(Console.ReadLine());
    sumaNotas = sumaNotas + nota;
}
promedioNotas = sumaNotas / cantidadDeNotas;

Console.WriteLine("El promedio es "+promedioNotas);

Console.WriteLine("El numero de notas cargadas es: {0}", cantidadDeNotas);

int numero;

Console.WriteLine("Ingrese un numero para clasificar");
Console.WriteLine("Ingrese 0 para salir");
numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    if (numero > 0)
    {
        Console.WriteLine("Numero positivo");
    }else {
        Console.WriteLine("Numero negativo");
            };

    Console.WriteLine("Ingrese un numero para clasificar");
    Console.WriteLine("Ingrese 0 para salir");
    numero = int.Parse(Console.ReadLine());
}