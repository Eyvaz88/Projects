
bool validarContrasenia(string contrasenia)
{
    return contrasenia.Equals("usSystem2022");
}

string ocultarPass(string pass)
{
    //array de chars
    char[] caracteres = pass.ToCharArray();
    for (int i = 0; i < caracteres.Length; i++)
    {
        caracteres[i] = '*';
    }
    //convierte el array en un string
    string textoModificado = new string(caracteres);
    return textoModificado;
}


void validoIngreso()
{
    int intentos = 0;

    string contrasenia;
    bool ingreso = true;

    Console.WriteLine("ingrese la contrasenia");

    while (ingreso)
    {
        contrasenia = Console.ReadLine();
        intentos++;

        if (validarContrasenia(contrasenia))
        {
            string passOculto= ocultarPass(contrasenia);
            Console.WriteLine("bienvenido a dev");
            Console.WriteLine("Su contrasenia es correcta {0}", passOculto); 
            break;
        } 
        else if (intentos >= 5) {
            Console.WriteLine("Su contrasenia no fue valida y agoto los intentos/");
         break;       
         }
        int restoDeIntentos = 5-intentos;
        Console.WriteLine("Su contrasenia no fue valida, intente nuevamente. Le quedan {0} intentos", restoDeIntentos);


    }

}


validoIngreso();