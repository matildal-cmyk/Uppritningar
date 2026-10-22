namespace Uppritningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Places city = new Places(95, new int[25, 98], 93);
            city.Build();

            Prison fängelse = new Prison(3, new int[10, 10], 12);
            fängelse.Build();

            Fattighus fattighus = new Fattighus(40, new int[10, 48], 50); //för att det ska bli jämnt
            fattighus.Build();

            
        }
    }
}
