// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese un primer numero");

var primerNumeroString = Console.ReadLine();
// var primerNumero = primerNumeroString !== "" ? int.Parse(primerNumeroString) : 0;
var primerResultadoPosible = 0;
if ( ! int.TryParse(primerNumeroString, out primerResultadoPosible))
{
    Console.WriteLine("El valor es nulo o vacio");
    return;
}
var primerNumero = int.Parse(primerNumeroString!);


Console.WriteLine("Ingrese su segundo numero");

var segundoNumeroString = Console.ReadLine();
//var segundoNumero = segundoNumeroString !== "" ? int.Parse(segundoNumeroString) : 0;
var segundoResultadoPosible = 0;
if ( ! int.TryParse(segundoNumeroString, out segundoResultadoPosible))
{
    Console.WriteLine("El valor es nulo o vacio");
    return;
}
var segundoNumero = int.Parse(segundoNumeroString!);

Console.WriteLine($"{primerNumero} + {segundoNumero} = {primerNumero + segundoNumero}");