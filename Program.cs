using System.IO.Compression;

/*Console.WriteLine("Hello, World!");

int a;
int b;

a = 10 ;
b = a ;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


//ejericio de invetir un numero 

string numeroCaracter;

Console.WriteLine("ingresar un numero"); //pido el numero
numeroCaracter = Console.ReadLine(); //ingresa el usario una cadena de caracter y lo guardo en la variable

int numero; //variable del numero convertido en entero
bool verificacion = int.TryParse(numeroCaracter, out numero); //verifica si es un numero, lo convierte en int y lo guarda en "numero"

if (verificacion)
{
    Console.WriteLine("el caracter ingresado es un numero");
    Console.WriteLine($"numero: {numero}");

    if (numero != 0)
    {
        int invertido = 0;
        while (numero != 0)
        {
            invertido += numero %10;
            numero = numero / 10;
            if (numero != 0)
            {
                invertido *= 10; 
            }
        }
        Console.WriteLine($"numero invertido: {invertido}");
    }
}
else
{
    Console.WriteLine("la cadena ingresada no es un numero");
}

*/

//obtener la longitud de la cadena y mostrarla funcionando
/*
string cadena;
string cadena2;

Console.WriteLine("ingresar una cadena de caracteres");
cadena = Console.ReadLine();

int tamanioCadena;

tamanioCadena = cadena.Length;

Console.WriteLine($"tamaño de la cadena: {tamanioCadena}");


//concatenar cadenas funcionando

Console.WriteLine("ingresar una segunda cadena");
cadena2 = Console.ReadLine();

string cadenasConcatenadas = $"{cadena}{cadena2}";

Console.WriteLine($"cadenas concatenadas: {cadenasConcatenadas}");

//obtener subcadena funcionando

string subCadena = cadenasConcatenadas.Substring(cadena.Length); //extraigo la segunda cadena

Console.WriteLine($"subcadena: {subCadena}");*/

//mostrar los resultados de las operaciones en texto funcionando


/*
int opcion;
string opcionCadena;
string numero1C;
string numero2C;
int numero1;
int numero2;

do
{

    Console.WriteLine("menu de operaciones");

    Console.WriteLine("ingrese una opcion");
    opcionCadena = Console.ReadLine();
    
    if (int.TryParse(opcionCadena, out opcion) && opcionCadena!= "6")
    {
        Console.WriteLine("ingresar dos numeros");
        numero1C = Console.ReadLine();
        numero2C = Console.ReadLine();
        if (int.TryParse(numero1C, out numero1) && int.TryParse(numero2C, out numero2))
        {
            
            switch(opcion)
            {
                case 1:
                        Console.WriteLine($"resultado de la suma de {numero1.ToString()} y de {numero2.ToString()} es igual a: {(numero1 + numero2).ToString()}");
                    break;
                case 2:
                    Console.WriteLine($"resultado de la resta de {numero1.ToString()} y de {numero2.ToString()} es igual a: {(numero1 - numero2).ToString()}");
                    break;
                case 3:
                    Console.WriteLine($"resultado del producto de {numero1.ToString()} y de {numero2.ToString()} es igual a: {(numero1 * numero2).ToString()}");  
                    break;
                case 4: 
                    Console.WriteLine($"resultado de la divicion de {numero1.ToString()} y de {numero2.ToString()} es igual a: {(numero1 / numero2).ToString()}");
                    break;
            }
        }
    }
}while(1 <= opcion && opcion < 6);

*/

//recorrer un texto con un foreach y mostrar cada elemento por pantalla 

Console.WriteLine("ingresar una cadena:");
string cadena3 = Console.ReadLine();

foreach (var elemento in cadena3)
{
    Console.WriteLine(elemento);
}
