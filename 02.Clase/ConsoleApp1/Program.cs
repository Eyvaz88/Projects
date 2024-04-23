// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int cantidadProductosVendidos;
int cantidadProductosDeposito = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos.");
//cuando lo toma de consola lo hace como string, x eso se convierte
cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());
stock = cantidadProductosDeposito - cantidadProductosVendidos;

if (stock == 0)
{
    Console.WriteLine("Reponer stock de productos");
    //cantidadProductosDeposito += 10;
    cantidadProductosDeposito = cantidadProductosDeposito + 10;
    Console.WriteLine("Productos cargados al deposito");

}
else
{
    if (stock <= 5)
    {
        Console.WriteLine("Stock minimo, reponer productos");
        cantidadProductosDeposito += 5;
        Console.WriteLine("Productos cargados al deposito");
        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
    }
    else
    {
        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
    }

}