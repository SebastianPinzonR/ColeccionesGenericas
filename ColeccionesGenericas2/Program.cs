using ColeccionesGenericas2;

class Program
{
    static void Main(string[] args)
    {
        Stack<Punto> puntos = new Stack<Punto>();
        puntos.Push(new Punto(3, 4));
        puntos.Push(new Punto(5, 7));
        puntos.Push(new Punto(9, 11));
        puntos.Push(new Punto(1, 4));

        Console.WriteLine("Una pila");

        foreach (Punto punto in puntos)
        {
            Console.WriteLine($"-> {punto}");
        }

        Console.WriteLine("---------------------------------------------------------------");

        //Hacemos un peek
        //lo cual nos permite observar el elemento que se encuentra hasta arriba de la pila
        Console.WriteLine($"Peek {puntos.Peek()}");
        Console.WriteLine("El peek permite obtener el elemento que se encuentra hasta arriba de la pila");
        foreach (Punto punto in puntos)
        {
            Console.WriteLine($"-> {punto}");
        }

        Console.WriteLine("----------------------------------------------------------------");

        //Hacemos un pop, este sirve para sacar el elemento que esta mas arriba de la pila 
        Console.WriteLine("Hacemos un pop, este sirve para sacar el elemento que esta mas arriba de la pila ");
        Console.WriteLine($"Pop {puntos.Pop()}");
        Console.WriteLine($"Pop {puntos.Pop()}");
        foreach (Punto punto in puntos)
        {
            Console.WriteLine($"-> {punto}");
        }
        Console.WriteLine("---------------------------------------------------------------");

        //Hacemos un peek
        Console.WriteLine($"Peek {puntos.Peek()}");

        foreach (Punto punto in puntos)
        {
            Console.WriteLine($"-> {punto}");
        }

        Console.WriteLine("---------------------------------------------------------------");
    }
}