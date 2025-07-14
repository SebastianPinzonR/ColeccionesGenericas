using ColeccionesGenericas1;

class Program
{
    static void Main(string[] args)
    {
        //Lista de objetos de nuestra clase
        //Adicion explicita, no con add
        List<Punto> puntos = new List<Punto>
        {
            new Punto(2,3),
            new Punto(5,23),
            new Punto(7,9)
        };

        foreach (Punto p in puntos)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("--------------------------------------------------");

        //adicionamos un punto
        puntos.Add(new Punto(2,3));

        foreach (Punto p in puntos)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("--------------------------------------------------");

        //Insertamos un punto en un indice predeterminado
        puntos.Insert(2, new Punto(100,51));

        foreach (Punto p in puntos)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("--------------------------------------------------");

        //Copiamos de lista a arreglo

        //creamos un arreglo de tipo Punto 
        Console.WriteLine("Arreglo o Array");
        Punto[] arregloPuntos = puntos.ToArray();
        for (int n = 0; n < arregloPuntos.Length; n++)
        {
            Console.WriteLine(arregloPuntos[n]);
        }
        Console.WriteLine("---------------------------------------------------");
    }
}
