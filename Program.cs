Console.WriteLine("Hello, World!");

int a;
int b;

a = 10 ;
b = a ;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


//ejericio de invetir un numero 

string numeroCaracter;

Console.WriteLine("ingresar un numero");
numeroCaracter = Console.ReadLine();

int numero;
bool verificacion = int.TryParse(numeroCaracter, out numero);

if (verificacion)
{
    Console.WriteLine("el caracter ingresado es un numero");
    Console.WriteLine($"numero: {numero}");
}
else
{
    Console.WriteLine("la cadena ingresada no es un numero");
}