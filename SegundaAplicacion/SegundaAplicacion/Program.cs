
//// ------ LISTAS ------

//// cada elemento tiene un indice y no se pueden agregar mas elementos
//string[] personas = { "Jorge", "Juana", "Maria", "Jose", "Cecilia" };
////                       0        1        2        3

//// List Collection - creacion
//List<string> stringList = new List<string>();

//// Agregar data al List desde un array string[]
//stringList.AddRange(personas);

//// Agregar un elemento a la lista
//stringList.Add("Fernando");

//// Contar elementos de una lista
//Console.WriteLine($"La lista List tiene esta cantidad de items: {stringList.Count}");

//// Consultar un elemento de la lista

//Console.WriteLine($"El primer elemento de la lista es: {stringList[0]}");

//// Eliminar elementos por indice y por valor
//stringList.RemoveAt(2); // Maria
//stringList.Remove("Jose");

//// Ordenar Lista
//stringList.Sort();

//// Revisar la existencia de un elemento, en caso de que no exista, agregarlo
//if (!stringList.Contains("Javier"))
//{
//    stringList.Add("Javier");
//}

//// Booleano que establece si hay un nombre con un largo mayor a 5
//var hayNombreLargo = stringList.Exists(x => x.Length > 5);
//Console.WriteLine($"Los nombres con mas caracteres que 5 son: {hayNombreLargo}");

//// Buscar el primer nombre que comiencen con "C"
//var nombresConC = stringList.Find(x => x.StartsWith("C"));
//Console.WriteLine($"El nombre que comienzan con C son: {nombresConC}");

//// Busca TODOS los nombres que comienzan con "J"
//var nombresConJ = stringList.Where(name => name.StartsWith("J"));
//Console.WriteLine($"Los nombres que comienzan con J son: {
//     String.Join(", ", nombresConJ)
//    }");

//// Metodo para imprimir todos los elementos de la lista
//// Lo devolvemos en tupla

//ImprimirLista(stringList);

//void ImprimirLista(List<string> listaParaImprimir)
//{
//    foreach(var nombre in listaParaImprimir)
//    {
//        Console.WriteLine(nombre);
//    }
//}

// ------ LINKEDLISTS ------
// Manejo secuencial de listas
string[] canciones =
{
    "Imagine",
    "One",
    "Billie Jean",
    "Hey Jude",
    "God Save The Queen",
    "Born to Run",
    "Creep",
    "Yesterday",
    "My Generation",
    "Respect"
};

// Creando un linkedlist
LinkedList<string> cancionesLinkedList = new LinkedList<string>(canciones);

// Agregar un elemento
cancionesLinkedList.AddFirst("Primera Cancion");
cancionesLinkedList.AddLast("Ultima Cancion");

// Buscando primer y ultimo elemento de la lista
LinkedListNode<string> primeraCancion = cancionesLinkedList.First!;
LinkedListNode<string> ultimaCancion = cancionesLinkedList.Last!;

Console.WriteLine($"Primera y ultima cancion: {primeraCancion.Value}, {ultimaCancion.Value}");

// Los elementos pueden ser agregados o removidos dependiendo de un elemento existente
cancionesLinkedList.AddAfter(primeraCancion, "Segunda cancion");

// Remove elemento
// cancionesLinkedList.RemoveLast();

// Imprimir elementos de la linkedList
foreach (string cancion in cancionesLinkedList)
{
    Console.WriteLine(cancion);
}

// Buscar elementos utilizando el metodo Contains
Console.WriteLine($"Buscando la cancion Imagine: {cancionesLinkedList.Contains("Imagine")}");

// Acceder a la data utilizando los metodos next y previous
Console.WriteLine($"La cancion proxima a la primera es: {primeraCancion.Next!.Value}");
Console.WriteLine($"La cancion anterior a la ultima es: {ultimaCancion.Previous!.Value}");


// ------ STACKED COLLECTION ------

// El primer elemento en entrar es el ultimo en la lista

// Crear una stacked collection
Stack<string> miStack = new Stack<string>();

// Agregamos elementos al stack
miStack.Push("uno");
miStack.Push("dos");
miStack.Push("tres");
miStack.Push("cuatro");
miStack.Push("cinco");
miStack.Push("seis");

// Buscar el primer elemento
string topStack = miStack.Peek();
System.Console.WriteLine($"El primer elemento del stack es: {topStack}");

// Remover un elemento
string elementoEliminado = miStack.Pop();
System.Console.WriteLine($"El elemento eliminado del stack es: {elementoEliminado}");

// Imprimir los elementos del stack utiliziando el foreach
foreach (string elemento in miStack)
{
    Console.WriteLine(elemento);
}

//  Busqueda de elemento
bool existeElemento = miStack.Contains("seis");
System.Console.WriteLine($"El elemento seis existe en el stack? {existeElemento}");

// ------ QUEUE COLLECTION ------

// El primer elemento en entrar es el primero en la lista

// Crear Queue Collection
Queue<string> miQueue = new Queue<string>();

// Agregar elementos
miQueue.Enqueue("uno");
miQueue.Enqueue("dos");
miQueue.Enqueue("tres");
miQueue.Enqueue("cuatro");
miQueue.Enqueue("cinco");
miQueue.Enqueue("seis");

// Buscar al primer elemento de la lista
var primerElementoQueue = miQueue.Peek();
System.Console.WriteLine($"El primer elemento del queue es: {primerElementoQueue}");

// Eliminar un elemento de un Queue
var elementoEliminadoQueue = miQueue.Dequeue();
System.Console.WriteLine($"El elemento eliminado del queue es: {elementoEliminadoQueue}");

// Buscar un elemento en el Queue
var existeElementoQueue = miQueue.Contains("uno");
System.Console.WriteLine($"El elemento seis existe en el queue? {existeElementoQueue}");

// Imprimir elementos
foreach (string elemento in miQueue)
{
    Console.WriteLine(elemento);
}

// ------ DICTIONARY COLLECTION ------

// Se controlan los indices de los elementos

// Crear un Dictionary (key, value)
Dictionary<string, string> miDiccionario = new Dictionary<string, string>();

// Agregar elementos a un diccionario
miDiccionario.Add("key1", "uno");
miDiccionario.Add("key2", "dos");
miDiccionario.Add("key3", "tres");
miDiccionario.Add("key4", "cuatro");
miDiccionario.Add("key5", "cinco");
miDiccionario.Add("key6", "seis");

// Eliminar un elemento del diccionario
var elementoEliminadoDiccionario = miDiccionario.Remove("key1");
System.Console.WriteLine($"El elemento eliminado del diccionario es key1");

// Buscar un elemento en el diccionario
var existeElementoDiccionario = miDiccionario.ContainsKey("key1");
System.Console.WriteLine($"El elemento key1 existe en el diccionario? {existeElementoDiccionario}");

// Tratamos de agregar un valor ya existente
var sePuedeAgregarValorDiccionario = miDiccionario.TryAdd("key2", "dos"); // False
if (sePuedeAgregarValorDiccionario)
{
    miDiccionario.Add("key2", "dos");
    System.Console.WriteLine("Se agrego el valor porque no existe");
} else {
    System.Console.WriteLine("No se puede agregar el valor porque ya existe");
}

// Actualizar el valor de un diccionario
miDiccionario["key6"] = "seis actualizado";

// Imprimir elementos del diccionario
foreach(KeyValuePair<string, string> elemento in miDiccionario)
{
    System.Console.WriteLine($"Key: {elemento.Key}, Value: {elemento.Value}");
}

// Buscar elementos de un diccionario por el key y por el valor
// var buscarElementoPorKey = miDiccionario["key2"];
System.Console.WriteLine($"Buscando un elemento con key5: {miDiccionario.ContainsKey("key5")}");

System.Console.WriteLine($"Buscando un elemento con valor '5': {miDiccionario.ContainsValue("cinco")}");