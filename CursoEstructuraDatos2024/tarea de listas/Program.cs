////Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números primos.
//HashSet<int> numeros = new HashSet<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
//HashSet<int> primos = ObtenerPrimos(numeros);
//Console.WriteLine("Los números primos son:");
//foreach (int primo in primos)
//{
//    Console.WriteLine(primo);
//}
//static HashSet<int> ObtenerPrimos(HashSet<int> numeros)
//{
//    return new HashSet<int>(numeros.Where(EsPrimo));
//}
//static bool EsPrimo(int numero)
//{
//    if (numero <= 1)
//    {
//        return false;
//    }
//    if (numero == 2)
//    {
//        return true;
//    }
//    if (numero % 2 == 0)
//    {
//        return false;
//    }
//    for (int i = 3; i <= Math.Sqrt(numero); i += 2)
//    {
//        if (numero % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que comienzan con una letra determinada.
//HashSet<string> palabras = new HashSet<string> { "manzana", "mango", "pera", "melon", "platano", "durazno", "maracuya", "pacay" };
//char letra = 'm';
//HashSet<string> palabrasFiltradas = PalabrasPorLetra(palabras, letra);
//Console.WriteLine($"Palabras que comienzan con '{letra}':");
//foreach (string palabra in palabrasFiltradas)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> PalabrasPorLetra(HashSet<string> palabras, char letra)
//{
//    return new HashSet<string>(palabras.Where(p => p.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase)));
//}




////Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son divisibles por un número determinado.
//HashSet<int> numeros = new HashSet<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15, 18, 20, 23, 21, 27, 25, 30, 31 };
//int divisor = 3;
//HashSet<int> numerosDivisibles = NumerosDivisibles(numeros, divisor);
//Console.WriteLine($"Los números divisibles por {divisor} son: ");
//foreach (int numero in numerosDivisibles)
//{
//    Console.WriteLine(numero);
//}
//static HashSet<int> NumerosDivisibles(HashSet<int> numeros, int divisor)
//{
//    return new HashSet<int>(numeros.Where(n => n % divisor == 0));
//}




////Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en ambos conjuntos.
//HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 10, 16, 19, 21, 25, 27, 32, 38 };
//HashSet<int> conjunto2 = new HashSet<int> { 4, 5, 6, 7, 8, 9, 11, 14, 10, 27, 22, 29, 38 };
//HashSet<int> interseccion = ObtenerInterseccion(conjunto1, conjunto2);
//Console.WriteLine("Los números de ambos conjuntos son: ");
//foreach (int numero in interseccion)
//{
//    Console.WriteLine(numero);
//}
//static HashSet<int> ObtenerInterseccion(HashSet<int> conjunto1, HashSet<int> conjunto2)
//{
//    return new HashSet<int>(conjunto1.Intersect(conjunto2));
//}




////Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en el 
////primer conjunto pero no en el segundo.
//HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
//HashSet<int> conjunto2 = new HashSet<int> { 4, 6, 8, 9, 11, 13, 14, 15 };
//HashSet<int> diferencia = ObtenerDiferencia(conjunto1, conjunto2);
//Console.WriteLine("Los números en el primer conjunto pero no en el segundo conjunto son: ");
//foreach (int numero in diferencia)
//{
//    Console.WriteLine(numero);
//}
//static HashSet<int> ObtenerDiferencia(HashSet<int> conjunto1, HashSet<int> conjunto2)
//{
//    return new HashSet<int>(conjunto1.Except(conjunto2));
//}




////Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en el
//segundo conjunto pero no en el primero.
//HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
//HashSet<int> conjunto2 = new HashSet<int> { 4, 6, 8, 9, 11, 13, 14, 15, 17, 19, 21, 16, 18, 23 };
//HashSet<int> diferencia = ObtenerDiferencia(conjunto2, conjunto1);
//Console.WriteLine("Los números en el segundo conjunto pero no en el primero son: ");
//foreach (int numero in diferencia)
//{
//    Console.WriteLine(numero);
//}
//static HashSet<int> ObtenerDiferencia(HashSet<int> conjunto1, HashSet<int> conjunto2)
//{
//    return new HashSet<int>(conjunto1.Except(conjunto2));
//}




////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son anagramas.
//HashSet<string> palabras = new HashSet<string> { "amor", "roma", "cosa", "saco", "aroma", "mora", "ramo", "caro" };
//HashSet<string> anagramas = ObtenerAnagramas(palabras);
//Console.WriteLine("Palabras que son anagramas:");
//foreach (string palabra in anagramas)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> ObtenerAnagramas(HashSet<string> palabras)
//{
//    var gruposAnagramas = palabras
//    .GroupBy(p => new string(p.OrderBy(c => c).ToArray()))
//    .Where(g => g.Count() > 1)
//    .SelectMany(g => g)
//    .ToHashSet();
//    return gruposAnagramas;
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos.
//HashSet<string> palabras = new HashSet<string> { "ana", "oso", "reconocer", "radar", "cívico", "perro" };
//HashSet<string> palindromos = ObtenerPalindromos(palabras);
//Console.WriteLine("Palabras que son palíndromos:");
//foreach (string palabra in palindromos)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> ObtenerPalindromos(HashSet<string> palabras)
//{
//    return palabras.Where(p => EsPalindromo(p)).ToHashSet();
//}
//static bool EsPalindromo(string palabra)
//{
//    int longitud = palabra.Length;
//    for (int i = 0; i < longitud / 2; i++)
//    {
//        if (palabra[i] != palabra[longitud - i - 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada.
//HashSet<string> palabras = new HashSet<string> { "casa", "perro", "gato", "coche", "mesa", "silla", "lore", "amigos", "larvas" };
//int longitudDeseada = 4;
//HashSet<string> palabrasFiltradas = FiltrarLongitud(palabras, longitudDeseada);
//Console.WriteLine($"Palabras de longitud {longitudDeseada}:");
//foreach (string palabra in palabrasFiltradas)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> FiltrarLongitud(HashSet<string> palabras, int longitud)
//{
//    return palabras.Where(p => p.Length == longitud).ToHashSet();
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada.
//HashSet<string> palabras = new HashSet<string> { "casa", "perro", "gato", "coche", "mesa", "silla", "mueble", "departamento" };
//char letraBuscada = 'a';
//HashSet<string> palabrasFiltradas = FiltrarLetra(palabras, letraBuscada);
//Console.WriteLine($"Palabras que contienen la letra '{letraBuscada}':");
//foreach (string palabra in palabrasFiltradas)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> FiltrarLetra(HashSet<string> palabras, char letra)
//{
//    return palabras.Where(p => p.Contains(letra)).ToHashSet();
//}



////Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de menor a mayor.
//HashSet<int> numerosDesordenados = new HashSet<int> { 5, 13, 8, 11, 9, 2, 4, 7, 15, 12, 6, 10, 3, 14, 1, 0};
//HashSet<int> numerosOrdenados = OrdenarNumeros(numerosDesordenados);
//Console.WriteLine("Números ordenados de menor a mayor:");
//foreach (int numero in numerosOrdenados)
//{
//    Console.WriteLine(numero);
//}
//static HashSet<int> OrdenarNumeros(HashSet<int> numeros)
//{
//    return new HashSet<int>(numeros.OrderBy(n => n));
//}



////Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de mayor a menor.
//HashSet<int> numerosDesordenados = new HashSet<int> { 5, 13, 8, 11, 9, 2, 4, 7, 15, 12, 6, 10, 3, 14, 1, 0 };
//HashSet<int> numerosOrdenados = OrdenarNumerosDescendente(numerosDesordenados);
//Console.WriteLine("Números ordenados de mayor a menor:");
//foreach (int numero in numerosOrdenados)
//{
//    Console.WriteLine(numero);
//}
//static HashSet<int> OrdenarNumerosDescendente(HashSet<int> numeros)
//{
//    return new HashSet<int>(numeros.OrderByDescending(n => n));
//}


////Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están duplicados.
//int[] numeros = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 1, 12, 13, 14, 14, 15};
//ISet<int> duplicados = encontrarDuplicados(numeros);
//Console.WriteLine("Los numeros duplicados son: " + string.Join(", ", duplicados));
//static ISet<int> encontrarDuplicados(int[] numeros)
//{
//    HashSet<int> set = new HashSet<int>();
//    HashSet<int> duplicados = new HashSet<int>();
//    foreach (int numero in numeros)
//    {
//        if (!set.Add(numero))
//        {
//            duplicados.Add(numero);
//        }
//    }
//    return duplicados;
//}



////Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que no están duplicados.
//int[] numeros = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 1, 12, 13, 14, 14, 15 };
//ISet<int> noDuplicados = encontrarNoDuplicados(numeros);
//Console.WriteLine("Los numeros no duplicados son: " + string.Join(", ", noDuplicados));
//static ISet<int> encontrarNoDuplicados(int[] numeros)
//{
//    return numeros.GroupBy(n => n)
//    .Where(g => g.Count() == 1)
//    .Select(g => g.Key)
//    .ToHashSet();
//}



////Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son primos
//// y están ordenados de menor a mayor.
//HashSet<int> numeros = new HashSet<int> { 10, 15, 3, 7, 2, 9, 17, 4, 11, 6, 5, 15, 13, 16, 21, 23, 27, 25, 29};
//HashSet<int> primosOrdenados = obtenerPrimosOrdenados(numeros);
//Console.WriteLine("Números primos ordenados de menor a mayor:");
//foreach (int numero in primosOrdenados)
//{
//    Console.WriteLine(numero);
//}
//static HashSet<int> obtenerPrimosOrdenados(HashSet<int> numeros)
//{
//    return new HashSet<int>(numeros.Where(EsPrimo).OrderBy(n => n));
//}
//static bool EsPrimo(int numero)
//{
//    if (numero <= 1)
//    {
//        return false;
//    }
//    for (int i = 2; i <= Math.Sqrt(numero); i++)
//    {
//        if (numero % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son
/// palíndromos y están ordenadas de menor a mayor.
//HashSet<string> palabras = new HashSet<string> { "ama", "zorro", "reconocer", "radar", "amor", "perro", "madam", "level", "roma" };
//HashSet<string> palindromosOrdenados = ObtenerPalindromosOrdenados(palabras);
//Console.WriteLine("Palabras que son palíndromos ordenadas de menor a mayor:");
//foreach (string palabra in palindromosOrdenados)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> ObtenerPalindromosOrdenados(HashSet<string> palabras)
//{
//    return new HashSet<string>(palabras.Where(EsPalindromo).OrderBy(p => p));
//}
//static bool EsPalindromo(string palabra)
//{
//    int longitud = palabra.Length;
//    for (int i = 0; i < longitud / 2; i++)
//    {
//        if (palabra[i] != palabra[longitud - i - 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//// tienen una longitud determinada y están ordenadas de menor a mayor.
//HashSet<string> palabras = new HashSet<string> { "casa", "perro", "gato", "coche", "mesa", "silla", "lore", "amigos", "larvas" };
//int longitudDeseada = 4;
//HashSet<string> palabrasOrdenadas = longitudYOrdenar(palabras, longitudDeseada);
//Console.WriteLine($"Palabras de longitud {longitudDeseada} ordenadas de menor a mayor:");
//foreach (string palabra in palabrasOrdenadas)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> longitudYOrdenar(HashSet<string> palabras, int longitud)
//{
//    return new HashSet<string>(palabras.Where(p => p.Length == longitud).OrderBy(p => p));
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
////contienen una letra determinada y están ordenadas de mayor a menor.
//HashSet<string> palabras = new HashSet<string> { "casa", "perro", "gato", "coche", "mesa", "silla", "mueble", "departamento" };
//char letraBuscada = 'o';
//HashSet<string> palabrasOrdenadas = LetraYOrdenar(palabras, letraBuscada);
//Console.WriteLine($"Palabras que contienen la letra '{letraBuscada}' ordenadas de mayor a menor:");
//foreach (string palabra in palabrasOrdenadas)
//{
//    Console.WriteLine(palabra);
//}
//static HashSet<string> LetraYOrdenar(HashSet<string> palabras, char letra)
//{
//    return new HashSet<string>(palabras.Where(p => p.Contains(letra)).OrderByDescending(p => p));
//}



////Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//// son palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor.
HashSet<string> palabras = new HashSet<string> {"ama", "zorro", "reconocer", "radar", "amor", "perro", "madam", "level", "roma"};
int longitudDeseada = 3;
HashSet<string> palindromosOrdenados = obtenerPalindromosOrdenados(palabras, longitudDeseada);
Console.WriteLine($"Palabras que son palíndromos de longitud {longitudDeseada} ordenadas de menor a mayor:");
foreach (string palabra in palindromosOrdenados)
{
    Console.WriteLine(palabra);
}
static HashSet<string> obtenerPalindromosOrdenados(HashSet<string> palabras, int longitud)
{
    return new HashSet<string>(palabras.Where(p => EsPalindromo(p) && p.Length == longitud).OrderBy(p => p));
}
static bool EsPalindromo(string palabra)
{
    int longitud = palabra.Length;
    for (int i = 0; i < longitud / 2; i++)
    {
        if (palabra[i] != palabra[longitud - i - 1])
        {
            return false;
        }
    }
    return true;
}

