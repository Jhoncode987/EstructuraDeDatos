////RECURSIVIDAD
//// Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 

//ImprimirNumerosPares(1);
//static void ImprimirNumerosPares(int numero)
//{
//    if (numero > 100)
//    {
//        return;
//    }
//    if (numero % 2 == 0)
//    {
//        Console.WriteLine(numero);
//    }
//    ImprimirNumerosPares(numero + 1);
//}



////Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.

//int n = 10; 
//int suma = SumaN(n);
//Console.WriteLine("La suma de los números del 1 al " + n + " es: " + suma);

//static int SumaN(int n)
//{
//  if (n == 1)
//  {
//    return 1;
//  }
//  else
//  {
//     return n + SumaN(n - 1);
//  }
//}



////Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.

//int n = 5; 
//Piramide(1, n);
//static void Piramide(int inicio, int n)
//{
//if (inicio > n) 
//  {
//    return;
//  }
//    for (int i = 1; i <= inicio; i++)
//    {
//       Console.Write(i + " ");
//    }
//  Console.WriteLine(); 
//  Piramide(inicio + 1, n);
//}



////Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.

//int n = 5; 
//PiramideInvertida(1, n);
//static void PiramideInvertida(int inicio, int n)
//{
//   if (inicio > n) 
//   {
//      return;
//   }
//   for (int i = n; i >= inicio; i--)
//   {
//      Console.Write(i + " ");
//   }
//   Console.WriteLine(); 
//   PiramideInvertida(inicio + 1, n);
//}



////Ejercicio 5: Escribe una función recursiva que imprima la tabla de multiplicar del n.

//int n = 5; 
//int limite = 12; 
//TablaMultiplicar(n, 1, limite);
//static void TablaMultiplicar(int n, int multiplicador, int limite)
//{
//   if (multiplicador > limite) 
//   {
//      return;
//   }
//      Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
//      TablaMultiplicar(n, multiplicador + 1, limite);
//}


////ARREGLOS Y MATRICES  
////Crea una matriz de números reales.

//int filas = 3;
//int columnas = 3;
//double[,] matriz = new double[filas, columnas];

//matriz[0, 0] = 1.5;
//matriz[0, 1] = 2;
//matriz[0, 2] = 3.9;
//matriz[1, 0] = 4;
//matriz[1, 1] = 5.4;
//matriz[1, 2] = 6;
//matriz[2, 0] = 7.8;
//matriz[2, 1] = 8.0;
//matriz[2, 2] = 9;

//Console.WriteLine("Matriz de números reales:");
//for (int i = 0; i < filas; i++)
//{
//   for (int j = 0; j < columnas; j++)
//   {
//      Console.Write(matriz[i, j] + "\t");
//   }
//   Console.WriteLine();
//}



////Crea una matriz de números complejos.

//using System.Numerics;

//int filas = 3;
//int columnas = 3;
//Complex[,] matriz = new Complex[filas, columnas];

//matriz[0, 0] = new Complex(1, 2); 
//matriz[0, 1] = new Complex(3, 4); 
//matriz[0, 2] = new Complex(5, 6); 
//matriz[1, 0] = new Complex(7, 8); 
//matriz[1, 1] = new Complex(9, 10);
//matriz[1, 2] = new Complex(11, 12); 
//matriz[2, 0] = new Complex(13, 14); 
//matriz[2, 1] = new Complex(15, 16); 
//matriz[2, 2] = new Complex(17, 18); 

//Console.WriteLine("Matriz de números complejos:");
//for (int i = 0; i < filas; i++)
//{
//   for (int j = 0; j < columnas; j++)
//   {
//       Console.Write(matriz[i, j] + "\t");
//   }
//   Console.WriteLine();
//}



////Crea una matriz de matrices.

//int filas = 2;
//int columnas = 2;
//int[][][] matriz = new int[filas][][];
//for (int i = 0; i < filas; i++)
//{
//    matriz[i] = new int[columnas][];
//    for (int j = 0; j < columnas; j++)
//    {
//       matriz[i][j] = new int[] { i + 1, j + 1, i * j };
//    }
//}
//Console.WriteLine("Matriz de matrices:");
//for (int i = 0; i < filas; i++)
//{
//   for (int j = 0; j < columnas; j++)
//   {
//       Console.Write("[");
//       for (int k = 0; k < matriz[i][j].Length; k++)
//       {
//           Console.Write(matriz[i][j][k]);
//           if (k < matriz[i][j].Length - 1)
//           {
//               Console.Write(", ");
//           }
//       }
//       Console.Write("] ");
//   }
//   Console.WriteLine();
//}



////Accede al elemento central de una matriz.

//int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//int size = matriz.GetLength(0); 
//int ElementoCentral = matriz[size / 2, size / 2];
//Console.WriteLine(ElementoCentral);



////Suma dos matrices de diferentes tamaños.
///
//int[,] matriz1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
//int[,] matriz2 = new int[,] { { 7, 8, 4 }, { 9, 10, 8 }, { 11, 12, 7 } };
//int fila1 = matriz1.GetLength(0);
//int columna1 = matriz1.GetLength(1);
//int fila2 = matriz2.GetLength(0);
//int columna2 = matriz2.GetLength(1);

//if (columna1 != columna2)
//{
//    Console.WriteLine("Error:las matrices tienen columnas diferentes ");
//    return;
//}

//int[,] resultado = new int[fila1, columna1];
//for (int i = 0; i < fila1; i++)
//{
//    for (int j = 0; j < columna1; j++)
//    {
//        resultado[i, j] = matriz1[i, j] + matriz2[i, j];
//    }
//}

//for (int i = 0; i < fila2; i++)
//{
//    for (int j = 0; j < columna2; j++)
//    {
//        if (fila1 + i < resultado.GetLength(0))
//        {
//            resultado[fila1 + i, j] = matriz2[i, j];
//        }
//    }
//}

//for (int i = 0; i < resultado.GetLength(0); i++)
//{
//    for (int j = 0; j < resultado.GetLength(1); j++)
//    {
//        Console.Write(resultado[i, j] + " ");
//    }
//    Console.WriteLine();
//}



////Multiplica una matriz por un número.

//int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
//int numero = 2;
//int fila = matriz.GetLength(0);
//int columna = matriz.GetLength(1);

//for (int i = 0; i < fila; i++)
//{
//    for (int j = 0; j < columna; j++)
//    {
//        matriz[i, j] *= numero;
//    }
//}

//// print result
//for (int i = 0; i < fila; i++)
//{
//    for (int j = 0; j < columna; j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}



////Calcula la media de los elementos de una matriz.

int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
double media = CalcularMedia(matriz);
Console.WriteLine("el elemento media de la mtriz es: " + media);
static double CalcularMedia(int[,] matriz)
{
    int suma = 0;
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            suma += matriz[i, j];
        }
    }
    double media = (double)suma / (matriz.GetLength(0) * matriz.GetLength(1));
    return media;
}

