//ENUNCIADO 1

//1.1.
//for (int n=2; n<11; n = n + 2)
//{
//    Console.WriteLine(n);
//}


//1.2.
//int suma = 0;

//for (int n=0; n<=10; n++)
//{
//    suma = suma + n;
//}

//Console.WriteLine($"El resultado de la suma es: {suma}");



//ENUNCIADO 2

//2.1.
//int n = 0, suma = 0;

//do
//{
//    Console.WriteLine("Ingrese un número positivo: ");
//    n = Convert.ToInt32(Console.ReadLine());

//    if (n > 0)
//    {
//        suma = suma + n;
//    }
//} while (n >= 0);

//    Console.WriteLine($"La suma de numeros positivos es: {suma}");

//2.2.
//int n = 1;

//while (true)
//{
//    if (n % 7 == 0 && n % 11 == 0)
//    {
//        Console.WriteLine($"El primer numero entero divisible entre 7 y 11 es: {n}");
//        break;
//    }
//    n++;
//}



//ENUNCIADO 3

//3.1.
//String contra;

//do
//{
//    Console.WriteLine("Ingrese la contraseña: ");
//    contra = Console.ReadLine();
//} while (contra!="jutiapa");

//Console.WriteLine("Contraseña correcta.");


//3.2.
Random random = new Random();
int numAleatorio = random.Next(1, 101);
int num;

do
{
    Console.WriteLine("Ingrese un numero: ");
    num = Convert.ToInt32(Console.ReadLine());
} while (num != numAleatorio);

Console.WriteLine("Ha adivinado el número.");