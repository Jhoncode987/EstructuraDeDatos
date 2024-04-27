// hacer un programa que pida un numero entero y indique si es par o impar

// declarar variables
Console.Write("========programa que determina si es par o impar===========");
Console.Write("INGRESE UN NUMERO ENTERO: ");
var numeroRecibido = Console.ReadLine(); 
var numero = int.Parse(numeroRecibido);
var esPar = false;
//resolver
if (numero%2 == 0)
{
    esPar = true;
}
//mostrar resultado
Console.WriteLine(esPar ? "es par" : "es impar");
Console.ReadLine(); 





//var i = 10;
//var indice = 1;
//do
//{ 

//}

//for (var j = 1; j <= i; j++)
//{
//    Console.WriteLine(j);
//}
//var i = 5;
////condicion?positiva:negativa
//var mensaje = i >= 4 ? "el numero es mayor o igual a 4!" : "el numero es menor a 4!";
//Console.WriteLine(mensaje);
//var i = 5;
//if (i >= 4)
//{
//    //positiva
//    Console.WriteLine("el numero es mayor o igual a 4! ");
//}
//else
//{
//    //negativa
//    Console.WriteLine("el numero es menor a 4!");
//}

//Console.ReadKey();
