


using System.Numerics;

   //desafio prox clase. el usuario se tiene que loguear antes de realizar la compra

int precioCodigo(string codigo)

{
    int precio = 0;
    switch (codigo)
    {
        case "DES":
            precio = 200;
            break;
        case "JP":
            precio = 300;
            break;
        case "DET":
            precio = 250;
            break;
        default:
            precio = 0;
            break;  
    }
    return precio;
}


void venta()
{
    string codigo = "";
    int cantProductos;
    int montoAPagar = 0;
    string confirmacion = "-";


    Console.WriteLine("Bienvenido, estos son nuestros productos");
    Console.WriteLine("Codigo     Descripcion     Precio\r\nDES        Desodorante     200\r\nJP         Jabon en polvo  300\r\nDET        Detergente      250");
   
    
    
    while (codigo != "FIN")
    {
        Console.WriteLine("Ingrese el codigo del producto deseado o escriba Fin para continuar");
        codigo = Console.ReadLine().ToUpper();


        if (codigo == "FIN")
        {
            break;
        }
        int precio = precioCodigo(codigo); //funcion
        Console.WriteLine("ingrese la cantidad que desea comprar");
        cantProductos = int.Parse(Console.ReadLine());

        montoAPagar += cantProductos * precio;



    }
    //TODO EL FINAL DE LA COMPRA
    Console.WriteLine("su monto a pagar es {0}",montoAPagar);
    Console.WriteLine("desea realizar la compra? Si/No");
    confirmacion = Console.ReadLine().ToUpper();

    if(confirmacion == "SI")
    {
        Console.WriteLine("Gracias x la compra!");
    }



}



venta();