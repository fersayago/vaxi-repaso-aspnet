

// cada elemento tiene un indice y no se pueden agregar mas elementos
string[] personas = { "Juan", "Felipe", "Maria", "Jose" };
//                       0        1        2        3

// List Collection - creacion
List<string> stringList = new List<string>();

// Agregar data al List desde un array string[]
stringList.AddRange(personas);

// Agregar un elemento a la lista
stringList.Add("Fernando");

// Contar elementos de una lista
Console.WriteLine($"La lista List tiene esta cantidad de items: {stringList.Count}");

// Metodo para imprimir todos los elementos de la lista
// Lo devolvemos en tupla

ImprimirLista(stringList);

void ImprimirLista(List<string> listaParaImprimir)
{
    foreach(var nombre in listaParaImprimir)
    {
        Console.WriteLine(nombre);
    }
}