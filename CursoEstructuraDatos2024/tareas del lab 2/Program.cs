// OPERACIONES BASICAS
//Realizar la suma, resta, multiplicacion y division de dos numeros ingresados por el usuario
using System.ComponentModel.Design;
using System.Xml;

Console.Write("Ingrese el primer numero: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

//resolver
suma = num1 + num2;
resta = num1 - num2;
multiplicacion = num1 * num2;

if (num1 != 0) 
{
    dividir = num1 / num2;

}
else
{
    Console.WriteLine("error: no se puede dividir entre 0.");
}

// mostrar resultado
Console.WriteLine("la suma es: " + suma);
Console.WriteLine("la resta es: " + resta);
Console.WriteLine("la multiplicacion es: " + multiplicacion);
Console.WriteLine("la division es: " + dividir);

Console.ReadLine();