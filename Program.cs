﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
    Este algoritmo se encarga de realizar las operaciones basicas 
    matematicas de dos numeros:
    
    1. El cliente ingresa un numero x
    2. El cliente ingresa un segundo numero y
    3. El cliente ingresa el tipo de operacion a realizar
    4. El programa captura estos valores y los almacena en variables
    5. El programa se encarga de realizar la operacion matematica
    6. El programa se encarga de imprimir el resultado de la operacion

*/

Console.WriteLine("Por favor ingrese su primer numero:");
var primerNumeroString = Console.ReadLine();

//if (primerNumeroString is null || primerNumeroString == "")
//{
//    Console.WriteLine("Ingreso un valor nulo o en blanco, termino el programa");
//    return;
//}

if (string.IsNullOrEmpty(primerNumeroString))
{
    Console.WriteLine("El valor es nulo o vacio, con el operador isNullOrEmpty");
    return;
}

// Algoritmo para evaluar si un texto tiene la nomenclatura de numero
// si es posible convertir un texto a numero
// 1. Es declarar una variable resultado posible
// 2. Condicionar si el texto esta realmente escrito en una nomenclatura numerica
// 3. En caso de que no sea un numero, entonces termina el programa.
// 4. En caso de que si sea un numero entonces continua la ejecucion del programa

int primerNumeroInt = 0;

if (!int.TryParse(primerNumeroString, out primerNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}

if ( primerNumeroInt <= 100)
{
    Console.WriteLine("Su numero es menor o igual que 100");
}
else if (primerNumeroInt > 100 &&  primerNumeroInt <= 200)
{
    Console.WriteLine("Su numero es mayor que 100 y menor o igual que 200");
}
else
{
    Console.WriteLine("Su numero es mayor que 200");
}

//var primerNumeroInt = int.Parse(primerNumeroString!);

Console.Write("Por favor ingrese el segundo numero:");
var segundoNumeroString = Console.ReadLine();
int segundoNumeroInt = 0;
if (string.IsNullOrEmpty(segundoNumeroString))
{
    Console.WriteLine("El valor ingresado es nulo");
    return;
}

if (!int.TryParse(segundoNumeroString, out segundoNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}

// SELECCIÓN DE OPERACIÓN
Console.WriteLine("Seleccione la operacion a realizar: \n1) Suma\n2) Resta\n3) Multiplicación\n4) Division");

int tipoOperacion = int.TryParse(Console.ReadLine(), out tipoOperacion) ? tipoOperacion : 0;

switch (tipoOperacion)
{
    case 1:
        {
            // SUMA
            var total = primerNumeroInt;
            total += segundoNumeroInt;
            Console.WriteLine($"{primerNumeroInt} + {segundoNumeroInt} = {total}");
            break;
        }
    case 2:
        {
            // RESTA
            var total = primerNumeroInt;
            total -= segundoNumeroInt;
            Console.WriteLine($"{primerNumeroInt} - {segundoNumeroInt} = {total}");
            break;
        }
    case 3:
        {
            // MULTIPLICACIÓN
            var total = primerNumeroInt;
            total *= segundoNumeroInt;
            Console.WriteLine($"{primerNumeroInt} x {segundoNumeroInt} = {total}");
            break;
        }
    case 4:
        {
            // DIVISION
            var total = primerNumeroInt;
            total /= segundoNumeroInt;
            Console.WriteLine($"{primerNumeroInt} / {segundoNumeroInt} = {total}");
            break;
        }
    default:
        {
            Console.WriteLine("Se ingreso un valor erroneo, se debe ingresar un numero del 1 al 4");
            break;
        }
}



//// SUMA
////var resultadoSuma = primerNumeroInt + segundoNumeroInt;
//var resultadoSuma = primerNumeroInt;
//resultadoSuma += segundoNumeroInt;
//Console.WriteLine("El resultado de la SUMA es:" + resultadoSuma);

//// RESTA
////var resultadoResta = primerNumeroInt- segundoNumeroInt;
//var resultadoResta = primerNumeroInt;
//resultadoResta -= segundoNumeroInt;
//Console.WriteLine("El resultado de la RESTA es:" + resultadoResta);

//// MULTIPLICACIÓN
////var resultadoMultiplicacion = primerNumeroInt * segundoNumeroInt;
//var resultadoMultiplicacion = primerNumeroInt;
//resultadoMultiplicacion *= segundoNumeroInt;
//Console.WriteLine($"El resultado de la MULTIPLICACION es {resultadoMultiplicacion}");

//// DIVISION
////var resultadoDivision = primerNumeroInt / segundoNumeroInt;
//var resultadoDivision = primerNumeroInt;
//resultadoDivision /= segundoNumeroInt;
//Console.WriteLine($"El resultado de la DIVISION es {resultadoDivision}");


