
/*Console.WriteLine("introduzca un texto: ");
string cadena = Console.ReadLine();


string cadenaMayusculas = cadena.ToUpper();
Console.WriteLine("La cadena en mayúsculas es: " + cadenaMayusculas);

for (int i = 0; i < cadena.Length; i++)
{
    char caracter = cadena[i];
    char caracterMayuscula = char.ToUpper(caracter);
    Console.Write(caracterMayuscula);
}

Console.WriteLine();*/

/*Console.WriteLine("introduzca un texto: ");
string cadena = Console.ReadLine();
        string cadenaMinusculas = cadena.ToLower();
        Console.WriteLine("La cadena en minúsculas es: " + cadenaMinusculas);
        for (int i = 0; i < cadena.Length; i++)
        {
            char caracter = cadena[i];
            char caracterMinuscula = char.ToLower(caracter);
            Console.Write(caracterMinuscula);
        }

        Console.WriteLine();*/





/*class program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("introzca un texto, por favor ");
        string cadena = Console.ReadLine();

        
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            Console.Write(cadena[i]);
        }

        Console.WriteLine();
    }
}*/

/*Console.WriteLine("introduzca un texto: ");
string cadena = Console.ReadLine().ToLower();
Console.WriteLine("Introduce la palabra que vamos a buscar: ");
string palabra = Console.ReadLine().ToLower();
int indice = cadena.IndexOf(palabra);
if (indice == -1)
{
    Console.WriteLine("La palabra no se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra se encuentra en la posición {0}.", indice);
}*/





/*Console.WriteLine("Introduce una cadena de texto: ");
string cadena = Console.ReadLine().ToLower();


Console.WriteLine("Introduce la palabra a buscar: ");
string palabra = Console.ReadLine().ToLower();


int indice = cadena.IndexOf(palabra);
if (indice == -1)
{
    Console.WriteLine("La palabra no se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra se encuentra en la posición {0}.", indice);
}*/


       
/*Console.WriteLine("introduce un texto: ");
string cadena = Console.ReadLine().ToLower();

int numeroVocales = 0;
foreach (char caracter in cadena)
{
if ("aeiou".Contains(caracter))
{
numeroVocales++;
            }
}
Console.WriteLine("la cadena contiene {0} vocales.", numeroVocales);*/