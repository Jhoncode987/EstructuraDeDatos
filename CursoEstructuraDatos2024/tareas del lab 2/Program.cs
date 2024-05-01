// OPERACIONES BASICAS
//Realizar la suma, resta, multiplicacion y division de dos numeros ingresados por el usuario

//Console.Write("Ingrese el primer numero: ");
//var num1 = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el segundo numero: ");
//var num2 = int.Parse(Console.ReadLine());

////resolver
//var suma = num1 + num2;
//var resta = num1 - num2;
//var multiplicacion = num1 * num2;

//double dividir; 

//if (num2 != 0) 
//{
//    dividir = (double)num1 / num2; 
//}
//else
//{
//    Console.WriteLine("Error: No se puede dividir entre 0.");
//    dividir = 0; 
//}

//// mostrar resultado
//Console.WriteLine("La suma es: " + suma);
//Console.WriteLine("La resta es: " + resta);
//Console.WriteLine("La multiplicacion es: " + multiplicacion);
//Console.WriteLine("La division es: " + Math.Round(dividir, 2)); 
//Console.ReadLine();



////VERIFICACION DE NUMERO PAR O IMPAR
////Solicita un numero al usuario y determina si es par o impar
//Console.Write("========programa que determina si es par o impar===========");
//Console.Write("INGRESE UN NUMERO ENTERO: ");
//var numeroRecibido = Console.ReadLine();
//var numero = int.Parse(numeroRecibido);
//var esPar = false;
////resolver
//if (numero % 2 == 0)
//{
//    esPar = true;
//}
////mostrar resultado
//Console.WriteLine(esPar ? "es par" : "es impar");
//Console.ReadLine();



//AREA DE UN TRIANGULO
//Pide la base y altura de un triangulo al usuario y calcula su area

//Console.WriteLine("======= calcular el area de un triangulo =======");

//Console.Write("Ingrese la base del triángulo: ");
//var baseT = int.Parse(Console.ReadLine());

//Console.Write("Ingrese la altura del triángulo: ");
//var alturaT = int.Parse(Console.ReadLine());
////resolver
//var areaT = (baseT * alturaT) / 2;

//// Mostrar el resultado 
//Console.WriteLine($"El área del triángulo con base {baseT} y altura {alturaT} es: {areaT}");



//CALCULADORA DE FACTORIAL
//Crea una funcion que calcule la factorial de un numero

//Console.WriteLine("======= Cálcular el Factorial de un Número =======");
//Console.Write("Ingrese un número entero positivo: ");
//int numero = int.Parse(Console.ReadLine());
//long factorial = CalcularFactorial(numero);
////resolver
//Console.WriteLine($"El factorial de {numero} es: {factorial}");
////mostrar resultado
// static long CalcularFactorial(int n)
//{
//    if (n < 0)
//    {
//        throw new ArgumentException("El número debe ser un entero positivo.");
//    }
//    long resultado = 1;
//    for (int i = 2; i <= n; i++)
//    {
//        resultado *= i;
//    }
//    return resultado;
//}



//NUMERO PRIMO
//Verifica si un numero ingresado por el usuario es primo o no

// Console.Write("Ingrese un número entero positivo para verificar si es primo: ");
// int numero = int.Parse(Console.ReadLine());
////resolver
//if (EsPrimo(numero))
//{
//Console.WriteLine($"{numero} es un número primo.");
//}
//else
//{
//Console.WriteLine($"{numero} no es un número primo.");
//}
////mostrar reultado
//static bool EsPrimo(int numero)
//{
// if (numero <= 1)
// {
//  return false;
// }
//    for (int i = 2; i <= Math.Sqrt(numero); i++)
//    {
//        if (numero % i == 0)
//        {
//            return false;
//        }
//    }
// return true;
//}



//INVERSION DE CADENA
//Toma una cadena de texto y muestra su inversion

//Console.Write("Ingrese una cadena de texto para invertirla: ");
//string texto = Console.ReadLine();
//string textoInvertido = InvertirCadena(texto);
////resolver
//Console.WriteLine("La cadena invertida es: " + textoInvertido);
////mostrar resultado
//static string InvertirCadena(string cadena)
//{
//   char[] caracteres = cadena.ToCharArray();
//   Array.Reverse(caracteres);
//   return new string(caracteres);
//}  



//SUMA DE NUMEROS PARES
//Calcula la suma de los numeros pares en un rango especificado por el usuario

//Console.Write("Ingrese el valor mínimo del rango: ");
//int minimo = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el valor máximo del rango: ");
//int maximo = int.Parse(Console.ReadLine());
////resolver
//int sumaPares = CalcularSumaPares(minimo, maximo);
//Console.WriteLine($"La suma de los números pares en el rango [{minimo}, {maximo}] es: {sumaPares}");
////mostrar resultado
//static int CalcularSumaPares(int minimo, int maximo)
//{
//   int suma = 0;
//for (int i = minimo; i <= maximo; i++)
//    {
//     if (i % 2 == 0)
//     {
//     suma += i;
//     }
//    }

//  return suma;
//}



//LISTA DE CUADRADOS
//Crea una lista de los cuadrados de los primeros 10 numeros naturales

//List<int> listaCuadrado = new List<int>();
////resolver
//for (int i = 1; i <= 10; i++)
//{
//  int cuadrado = i * i;
//  listaCuadrado.Add(cuadrado);
//}
//Console.WriteLine("Los cuadrados de los primeros 10 números naturales son: ");
////mostrar resultado
//foreach (int cuadrado in listaCuadrado)
//{
//  Console.WriteLine(cuadrado);
//}
//Console.ReadLine();



//CONTADOR DE VOCALES
//Cuenta el numero de vocales en una cadena de texto

//Console.Write("Ingrese una cadena de texto: ");
//string texto = Console.ReadLine();
//int cantidadVocales = ContarVocales(texto);
////resolver
//Console.WriteLine($"El número de vocales en la cadena es: {cantidadVocales}");
//Console.ReadLine();
////mostrar resultado
//static int ContarVocales(string texto)
//    {
//        int cantidadVocales = 0;

//        foreach (char c in texto)
//        {
//            if (EsVocal(c))
//            {
//                cantidadVocales++;
//            }
//        }
//        return cantidadVocales;
//    }
//    static bool EsVocal(char c)
//    {
//        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
//               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
//    }



//NUMEROS DE LA SERIE FIBONACCI 
//Genera los primeros 10 numeros de la serie fibonacci

//Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
////resolver
//for (int i = 0; i < 10; i++)
//{
//  Console.Write(Fibonacci(i) + " ");
//}
////mostrar resultado
//static int Fibonacci(int n)
//    {
//        if (n <= 1)
//        {
//            return n;
//        }
//        else
//        {
//            return Fibonacci(n - 1) + Fibonacci(n - 2);
//        }
//}




//ORDENAMIENTO DE LISTA
//Ordena una lista de numeros ingresados por el usuario de menor a mayor

//Console.Write("Ingrese la cantidad de números que desea ordenar: ");
//int cantidad = int.Parse(Console.ReadLine());
//int[] numeros = new int[cantidad];
////reolver
//for (int i = 0; i < cantidad; i++)
//{
//  Console.Write($"Ingrese el número {i + 1}: ");
//  numeros[i] = int.Parse(Console.ReadLine());
//}
//OrdenarNumeros(numeros);
//Console.WriteLine("Números ordenados de menor a mayor:");
////mostrar resultado
//foreach (int numero in numeros)
//{
//  Console.WriteLine(numero);
//}
// static void OrdenarNumeros(int[] numeros)
//{
//  Array.Sort(numeros);
//}



//PALINDROMO
//Verifica si una palabra ingresada por el usuario es un palindromo

//Console.Write("Ingrese una palabra para verificar si es un palíndromo: ");
//string palabra = Console.ReadLine();
////resolver
//if (EsPalindromo(palabra))
//{
//   Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
//}
//else
//{
//   Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
//}
////mostrar resultado
//static bool EsPalindromo(string palabra)
//{
//palabra = palabra.ToLower();
//for (int i = 0; i < palabra.Length / 2; i++)
//    {
//     if (palabra[i] != palabra[palabra.Length - 1 - i])
//        {
//           return false;
//        }
//     }
//   return true;
//}



//GENERADOR DE TABLAS DE MULTIPLICAR
//Crea un programa que genere la tabla de multiplicar de un numero ingresado por el usuario

//Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
//int numero = int.Parse(Console.ReadLine());
////resolver
//Console.WriteLine($"Tabla de multiplicar del número {numero}:");
//for (int i = 1; i <= 12; i++)
//{
//   int resultado = numero * i;
//    //mostrar resultado
//   Console.WriteLine($"{numero} x {i} = {resultado}");
//}




//CALCULO DEL AREA DE UN CIRCULO 
//Pide el radio de un circulo al usuario y calcula su area

//Console.Write("ingresa el radio del circulo: ");
////resolver
//var radio = Convert.ToDouble(Console.ReadLine());
//var area = Math.PI * Math.Pow(radio, 2);
////mostrar resultado
//Console.WriteLine($"el area del circulo con el radio {radio} es {area}");
//Console.ReadLine();



//SUMA DE DIGITOS
//Toma un numero entero y calcula la suma de sus digitos

Console.Write("Ingresa un numero: ");
//resolver
int numero = Convert.ToInt32(Console.ReadLine());
int suma = 0;
while (numero > 0)
{
  int digit = numero % 10;
  suma += digit;
  numero /= 10;
}
//mostrar resultado
Console.WriteLine($"la suma de los digitos es: {suma}");
Console.ReadLine();
