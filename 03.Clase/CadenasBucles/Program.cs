string cadenaNula = null;
string cadenaVacia = string.Empty;
string cadenaSaludo = "Hola, soy una cadena";
string cadenaComillas = " ";

Console.WriteLine(cadenaSaludo + cadenaNula + cadenaVacia);

if (cadenaNula == cadenaVacia )
{
    Console.WriteLine("Las cadenas son iguales");
    Console.WriteLine(cadenaNula);
    Console.WriteLine(cadenaVacia);
}else
{
    Console.WriteLine("las cadenas no son iguales");
   // Console.WriteLine(cadenaNula.Length);
    Console.WriteLine(cadenaVacia.Length);
    Console.WriteLine(cadenaComillas.Length);
    Console.WriteLine(cadenaSaludo.ToUpper());  
    Console.WriteLine(cadenaSaludo.ToLower());
     
    int numeroEntero = 0;
    double numeroDouble = 1.34;
    bool booleano = true;

    Console.WriteLine(numeroEntero.ToString() + numeroDouble.ToString());

    string cadena1 = "Soy una cadena ";
    string cadena2 = "Soy una cadena";

    
}

string cadena = Console.ReadLine();
double constante = 0.5;
double numeroEnCadenaConvertidoADouble;
double sumaConNumerosDouble;


if (String.IsNullOrEmpty(cadena))
{
    Console.WriteLine("La cadena no se puede parsear ya que esta vacia.");

}
else
{
    numeroEnCadenaConvertidoADouble = double.Parse(cadena);
    sumaConNumerosDouble = numeroEnCadenaConvertidoADouble + constante;
    Console.WriteLine("El resultado es " +sumaConNumerosDouble.ToString());
}




//EJEMPLO WHILE
//validar acceso

Console.WriteLine("Ingrese contrasenia");
string contrasenia = Console.ReadLine();

//while (!contrasenia.Equals)