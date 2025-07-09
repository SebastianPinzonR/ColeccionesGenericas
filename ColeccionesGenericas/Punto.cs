class Punto
{
    private int x;
    private int y;
    public Punto(int parametroX, int parametroY)
    {
        x = parametroX;
        y = parametroY;
    }

    public override string ToString()
    {
        return string.Format($"X = {x} Y = {y}");
    }
}