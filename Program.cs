Console.WriteLine("Hello, World!");

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
}
else
{
    Console.WriteLine("la cadena ingresada no es un numero");
}