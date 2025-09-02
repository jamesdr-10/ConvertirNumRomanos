class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int obtenerValorDecimal(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }

    public static int convertirRomanoADecimal(string romano)
    {
        int total = 0;
        int longitud = romano.Length;
        for (int i = 0; i < longitud; i++)
        {
            int valorActual = obtenerValorDecimal(romano[i]);
            int valorSiguiente = (i + 1 < longitud) ? obtenerValorDecimal(romano[i + 1]) : 0;
            if (valorActual < valorSiguiente)
            {
                total -= valorActual;
            } else
            {
                total += valorActual;
            }
        }
        return total;
    }
}