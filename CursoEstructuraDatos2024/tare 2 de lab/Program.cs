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

//int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//double media = CalcularMedia(matriz);
//Console.WriteLine("el elemento media de la mtriz es: " + media);
//static double CalcularMedia(int[,] matriz)
//{
//    int suma = 0;
//    for (int i = 0; i < matriz.GetLength(0); i++)
//    {
//        for (int j = 0; j < matriz.GetLength(1); j++)
//        {
//            suma += matriz[i, j];
//        }
//    }
//    double media = (double)suma / (matriz.GetLength(0) * matriz.GetLength(1));
//    return media;
//}



////EJERCICIO MATRICES
////Ejercicio 1: Crea una matriz de números aleatorios de tamaño 100x100.

//Random rnd = new Random();
//int[,] matriz = new int[100, 100];

//for (int i = 0; i < 100; i++)
//{
//   for (int j = 0; j < 100; j++)
//   {
//       matriz[i, j] = rnd.Next(-10, 11);
//   }
//}

//for (int i = 0; i < 100; i++)
//{
//    for (int j = 0; j < 100; j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}




////Ejercicio 2:Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.

//using System.Linq;
//int[,] matriz = new int[,]
//{
//   {1, 2, 3},
//   {4, 5, 6},
//   {7, 8, 9}
//};
//double media = CalcularMediaMatriz(matriz);
//Console.WriteLine("Media: " + media);
//double mediana = CalcularMedianaMatriz(matriz);
//Console.WriteLine("Mediana: " + mediana);
//double desviacionEstandar = CalcularDesviacionEstandarMatriz(matriz, media);
//Console.WriteLine("Desviación estándar: " + desviacionEstandar);
//static double CalcularMediaMatriz(int[,] matriz)
//{
//   int suma = 0;
//   foreach (int elemento in matriz)
//   {
//      suma += elemento;
//   }
//   double media = (double)suma / (matriz.GetLength(0) * matriz.GetLength(1));
//   return media;
//}
//static double CalcularMedianaMatriz(int[,] matriz)
//{
//    int[] elementosOrdenados = matriz.Cast<int>().OrderBy(x => x).ToArray();
//    int cantidadElementos = elementosOrdenados.Length;
//    if (cantidadElementos % 2 == 0)
//    {
//        int medio1 = elementosOrdenados[cantidadElementos / 2 - 1];
//        int medio2 = elementosOrdenados[cantidadElementos / 2];
//        return (double)(medio1 + medio2) / 2;
//    }
//    else
//    {
//        return elementosOrdenados[cantidadElementos / 2];
//    }
//}
//static double CalcularDesviacionEstandarMatriz(int[,] matriz, double media)
//{
//    double sumaCuadradosDiferencias = 0;
//    foreach (int elemento in matriz)
//    {
//       double diferencia = elemento - media;
//       sumaCuadradosDiferencias += diferencia * diferencia;
//    }
//    double varianza = sumaCuadradosDiferencias / (matriz.GetLength(0) * matriz.GetLength(1));
//    double desviacionEstandar = Math.Sqrt(varianza);
//    return desviacionEstandar;
//}



////Ejercicio 3: Escribe una función que encuentre el elemento máximo de una matriz.

//int[,] matriz = {
//   {1, 3, 5},
//   {9, 7, 2},
//   {4, 6, 8}
//};
//int maximo = EncontrarMaximo(matriz);
//Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
//static int EncontrarMaximo(int[,] matriz)
//{
//    int maximo = matriz[0, 0];
//    foreach (int elemento in matriz)
//    {
//        if (elemento > maximo)
//        {
//           maximo = elemento;
//        }
//    }
//    return maximo;
//}



////Ejercicio 4: Escribe una función que encuentre la submatriz de mayor suma de una matriz.


//int[,] matriz = {
//   {-1, 2, 3},
//   {4, -5, 6},
//   {7, 8, -9}
//};

//int maximaSuma = 0;
//int filaInicio = 0;
//int filaFin = 0;
//int columnaInicio = 0;
//int columnaFin = 0;
//EncontrarSubmatrizMaxima(matriz, out maximaSuma, out filaInicio, out filaFin, out columnaInicio, out columnaFin);
//Console.WriteLine("La submatriz de mayor suma es:");
//for (int i = filaInicio; i <= filaFin; i++)
//{
//    for (int j = columnaInicio; j <= columnaFin; j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//        }
//Console.WriteLine("La suma de la submatriz de mayor suma es: " + maximaSuma);
//static void EncontrarSubmatrizMaxima(int[,] matriz, out int maximaSuma, out int filaInicio, out int filaFin, out int columnaInicio, out int columnaFin)
//{
//    int filas = matriz.GetLength(0);
//    int columnas = matriz.GetLength(1);
//    maximaSuma = int.MinValue;
//    filaInicio = 0;
//    filaFin = 0;
//    columnaInicio = 0;
//    columnaFin = 0;
//    for (int columnaInicioActual = 0; columnaInicioActual < columnas; columnaInicioActual++)
//    {
//        int[] sumaTemporal = new int[filas];
//        for (int columnaFinActual = columnaInicioActual; columnaFinActual < columnas; columnaFinActual++)
//        {
//            for (int fila = 0; fila < filas; fila++)
//            {
//                sumaTemporal[fila] += matriz[fila, columnaFinActual];
//            }

//        int maximaSumaTemporal = 0;
//        int maximaSumaHastaAhora = int.MinValue;
//        int filaInicioTemporal = 0;
//        for (int fila = 0; fila < filas; fila++)
//        {
//             maximaSumaTemporal += sumaTemporal[fila];
//             if (maximaSumaTemporal > maximaSumaHastaAhora)
//             {
//                 maximaSumaHastaAhora = maximaSumaTemporal;
//                 filaFin = fila;
//                 filaInicio = filaInicioTemporal;
//             }
//             if (maximaSumaTemporal < 0)
//             {
//                 maximaSumaTemporal = 0;
//                 filaInicioTemporal = fila + 1;
//             }
//        }
//            if (maximaSumaHastaAhora > maximaSuma)
//            {
//                maximaSuma = maximaSumaHastaAhora;
//                columnaInicio = columnaInicioActual;
//                columnaFin = columnaFinActual;
//            }
//        }
//    }
//}





////Ejercicio 5: Escribe una función que encuentre la matriz de covarianza de dos matrices.

double[,] matriz1 = {
     {1, 2, 3},
     {4, 5, 6},
     {7, 8, 9}
};
double[,] matriz2 = {
     {9, 8, 7},
     {6, 5, 4},
     {3, 2, 1}
};
double[,] matrizCovarianza = CalcularMatrizCovarianza(matriz1, matriz2);
Console.WriteLine("Matriz de covarianza:");
MostrarMatriz(matrizCovarianza);
static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
{
   int filas = matriz1.GetLength(0);
   int columnas = matriz1.GetLength(1);
   if (filas != matriz2.GetLength(0) || columnas != matriz2.GetLength(1))
   {
      throw new ArgumentException("Las dimensiones de las matrices deben ser iguales para calcular la covarianza.");
   }
   double[] mediaMatriz1 = CalcularMediaColumnas(matriz1);
   double[] mediaMatriz2 = CalcularMediaColumnas(matriz2);
   double[,] matrizCovarianza = new double[columnas, columnas];
   for (int i = 0; i < columnas; i++)
   {
       for (int j = 0; j < columnas; j++)
       {
           double covarianza = 0;
           for (int k = 0; k < filas; k++)
           {
               covarianza += (matriz1[k, i] - mediaMatriz1[i]) * (matriz2[k, j] - mediaMatriz2[j]);
           }
           covarianza /= filas - 1; 
           matrizCovarianza[i, j] = covarianza;
       }
   }
   return matrizCovarianza;
}
static double[] CalcularMediaColumnas(double[,] matriz)
{
   int filas = matriz.GetLength(0);
   int columnas = matriz.GetLength(1);
   double[] medias = new double[columnas];
   for (int j = 0; j < columnas; j++)
   {
       double sumaColumna = 0;
       for (int i = 0; i < filas; i++)
       {
           sumaColumna += matriz[i, j];
       }
       medias[j] = sumaColumna / filas;
   }
   return medias;
}
static void MostrarMatriz(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            Console.Write(matriz[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

