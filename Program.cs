//OPERACIONES CON TIPOS DE DATOS 
using System;
// Pedir los dos números al usuario
Console.WriteLine("**Operaciones con tipos de datos:**");
Console.WriteLine("--------------------------");
Console.WriteLine("1. Convertir suma de dos números enteros");

Console.WriteLine("Introduzca el primer número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int primerNumero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca el segundo número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int segundoNumero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Calcular la suma
int suma = primerNumero + segundoNumero;

// Mostrar el resultado
Console.WriteLine("La SUMA de los dos números enteros es: " + suma);

Console.WriteLine("**Operaciones con tipos de datos:**");
Console.WriteLine("--------------------------");
Console.WriteLine("2. Convertir resta de dos números enteros");

float resta;

// Pedir los dos números al usuario
Console.WriteLine("Introduzca el primer número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
primerNumero = (int)float.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca el segundo número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
segundoNumero = (int)float.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Calcular la resta
resta = primerNumero - segundoNumero;
Console.WriteLine("La RESTA de los dos números es: " + resta);

// Calcular la multiplicación
Console.WriteLine("**Operaciones con tipos de datos:**");
Console.WriteLine("--------------------------");
Console.WriteLine("3. Convertir multiplicación de dos números flotantes");

float multiplicación;
Console.WriteLine("Introduzca el primer número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
float.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
Console.WriteLine("Introduzca el segundo número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
float.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Mostrar el resultado
multiplicación = primerNumero * segundoNumero;
Console.WriteLine(value: $"La MULTIPLICACIÓN de los dos números es:" + multiplicación);
// Calcular la división
Console.WriteLine("**Operaciones con tipos de datos:**");
Console.WriteLine("--------------------------");
Console.WriteLine("4. Convertir divisiones de dos números a enteros");

// Pedir los dos números al usuario
Console.WriteLine("Introduzca el primer número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int PrimerNumero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca el segundo número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int SegundoNumero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Validar que el divisor no sea cero
if (segundoNumero == 0)
{
    Console.WriteLine("Error: El divisor no puede ser cero.");
    return;
}

// Calcular la división
int division = primerNumero / segundoNumero;

// Mostrar el resultado
Console.WriteLine("La DIVISIÓN de los dos números es: " + division);
// Calcular el módulo de dos núemeros enteros
Console.WriteLine("**Operaciones con tipos de datos:**");
Console.WriteLine("--------------------------");
Console.WriteLine("5. Convertir el módulo de dos números a enteros");
// Pedir los dos números al usuario
Console.WriteLine("Introduzca el primer número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int PrimerrNumero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca el segundo número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int SegundooNumero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Calcular el módulo
int modulo = primerNumero % segundoNumero;

// Mostrar el resultado
Console.WriteLine("El módulo de los dos números es: " + modulo);


