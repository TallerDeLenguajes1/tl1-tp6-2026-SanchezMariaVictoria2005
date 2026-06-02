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
}*/

int opcion; //opcion de operaciones, forma de entero

string opcionCadena; //opcion en forma de cadena
string numero1C; //primer numero ingresado en forma de cadena
string numero2C; //segundo numero ingresado en forma de cadena
int numero1; //primer numero ingresado en forma de entero
int numero2; //segundo numero ingresado en forma de entero
bool repite = false; //variable para controlar si el usuario quiere realizar otra operacion
string repetirCadena; //opcion para realizar otra operacion en forma de cadena
int repetir; // opcion para realizar otra operacion en forma de entero
float numero;
do
{

    Console.WriteLine("menu de operaciones");
    Console.WriteLine("1-valor absoluto");
    Console.WriteLine("2-cuadrado");
    Console.WriteLine("3-raiz cuadrada");
    Console.WriteLine("4-seno");
    Console.WriteLine("5-coseno");
    Console.WriteLine("7-parte entera de un float");

    //  ingresa un solo numero
    Console.WriteLine("ingrese una opcion");
    opcionCadena = Console.ReadLine();

    if (int.TryParse(opcionCadena, out opcion) && opcionCadena != "6")
    {
        Console.WriteLine("ingresar un numero");
        numero1C = Console.ReadLine();
        if (float.TryParse(numero1C, out numero))
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine(Math.Abs(numero));
                break;
                   
                case 2:
                     Console.WriteLine(Math.Pow(numero, 2));
                break;

                case 3:
                     Console.WriteLine(Math.Sqrt(numero));
                break;

                case 4:
                     Console.WriteLine(Math.Sin(numero));
                break;

                case 5:
                     Console.WriteLine(Math.Cos(numero));
                break;

                case 7:
                     Console.WriteLine(Math.Truncate(numero));
                break;
            }
        }
    }

    Console.WriteLine("menu de operaciones");
    Console.WriteLine("suma");
    Console.WriteLine("2-resta");
    Console.WriteLine("3-multiplicar");
    Console.WriteLine("4-divir");
    Console.WriteLine("6-salir");
    

    Console.WriteLine("ingrese una opcion");
    opcionCadena = Console.ReadLine();
    
    if (int.TryParse(opcionCadena, out opcion) && opcionCadena!= "6") //controla que sea un numero y sea distinto a la salida
    {
        Console.WriteLine("ingresar dos numeros");
        numero1C = Console.ReadLine();
        numero2C = Console.ReadLine();
        if (int.TryParse(numero1C, out numero1) && int.TryParse(numero2C, out numero2)) //controla que ambos caracteres ingresados sean numeros
        {
            do //estructura para realizar otra operacion si el usuario lo desea
            {
                 switch(opcion)
                {
                case 1:
                        Console.WriteLine($"resultado de la suma: {numero1 + numero2}");
                        
                    break;
                case 2:
                    Console.WriteLine($"resultado de la resta: {numero1 - numero2}");
                    
                    break;
                case 3:
                    Console.WriteLine($"resultado del producto: {numero1 * numero2}");  
                    
                    break;
                case 4: 
                    Console.WriteLine($"resultado de la divicion: {numero1 / numero2}");
                    
                    break;
                

                }

            Console.WriteLine("escribir 0 si quiere realizar otra operacion:");
            repetirCadena = Console.ReadLine();
            if ((int.TryParse(repetirCadena, out repetir)))
                {
                    if (repetir ==  0) //si quiere realizar otra operacion
                    {
                        repite = true;
                        Console.WriteLine("ingrese una opcion"); //ingresa el numero de la operacion
                        opcionCadena = Console.ReadLine();
                        int.TryParse(opcionCadena, out opcion);

                    }
                    else
                    {
                        repite = false;
                    }
                }

            

            } while (repite);
        }
    }
}while(1 <= opcion && opcion < 6);