class Program
{
    static void Main(string[] args)
    {
        List<int> Valores = new List<int>();


        Valores.Add(5);
        Valores.Add(10);
        Valores.Add(15);
        Valores.Add(20);
        Valores.Add(25);
        Valores.Add(30);

        //Recorremos la lista
        foreach (int valor in Valores)
        {
            //NO se utiliza el Type cast
            //Es decir nos es necesario convertir
            //un objet a int o el tipo de dato que se vaya a utilizar
            Console.WriteLine(valor);
        }
        Console.WriteLine("--------------------------------");

        //Validamos si tiene los siguientes este va a arrojar falso o verdadero
        Console.WriteLine(Valores.Contains(5));
        Console.WriteLine(Valores.Contains(17));

        Console.WriteLine("----------------------------------");

        //Obtenemos el indice de un elemento
        Console.WriteLine(Valores.IndexOf(12));
        //SI este no se encuentra arrojara -1
        Console.WriteLine(Valores.IndexOf(10));
        //Si si se encuentra, dara la posicion recordar que esta desde 0 hasta un numero determinado

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Insertamos un elemento en un indice");
        //Insertamos un elemento en un indice
        Valores.Insert(6, 35);
        foreach (int valor in Valores)
        {
            Console.WriteLine(valor);
        }
        Console.WriteLine("-----------------------------------------------");

        //Eliminamos un elemento dando un indice
        Console.WriteLine("Eliminamos un elemento dando un indice");
        Valores.RemoveAt(5);
        foreach (int valor in Valores)
        {
            Console.WriteLine(valor);
        }
        Console.WriteLine("------------------------------------------------");

        //Eliminamos la primera ocurrencia de un valor
        Console.WriteLine("Eliminamos la primera ocurrencia de un valor");
        Valores.Remove(5);
        foreach(int valor in Valores)
            { Console.WriteLine(valor); }
        Console.WriteLine("--------------------------------------------------");

        //La lista se coloca en sentido contrario
        Console.WriteLine("Lista desordenada");
        Valores.Reverse();
        foreach (int valor in Valores)
            { Console.WriteLine(valor); }
        Console.WriteLine("------------------------------------------------------");

        //Mandamos a ordenar la lista
        //Si invocamos el metodo sort para utilizarlo con una clase, la clase tiene que tener IComparable
        Console.WriteLine("Lista ordenada");
        Valores.Sort();
        foreach (int valor in Valores) {
            Console.WriteLine(valor); }
        Console.WriteLine("---------------------------------------------------------");

        //Creamos una lista para nuestra clase
        List<Punto> listaPuntos = new List<Punto>();

        listaPuntos.Add(new Punto(5, 3));
        listaPuntos.Add(new Punto(7, 8));
        listaPuntos.Add(new Punto(12, 5));
        listaPuntos.Add(new Punto(6, 2));

        foreach (Punto punto in listaPuntos)
        {
            Console.WriteLine(punto);
        }

        //No funciona el siguiente metodo Sort por que no hemos implementado IComparable
        //listaPuntos.Sort();
    }
}
