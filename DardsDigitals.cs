namespace DardsDigitals;
public class JocDards
{
    public static (int, int) LanzarDardos(Random random, int puntstotals1, int puntstotals2)
    {
        
        int Dard1 = random.Next(9);
        int Dard2 = random.Next(9);
        int Dard3 = random.Next(9);
        int Dard4 = random.Next(9);
            
        
        var punts = Diana[Dard1, Dard2];
        var punts2 = Diana[Dard3, Dard4];

        
        return (puntstotals1 + punts, puntstotals2 + punts2);
    }

    
    private static int[,] Diana =
    {
        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 1, 2, 2, 2, 2, 2, 1, 0 },
        { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
        { 0, 1, 2, 5, 10, 5, 2 ,1, 0 },
        { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
        { 0, 1 ,2, 2, 2, 2, 2, 1, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    };
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int puntstotals1 = 0;
        int puntstotals2 = 0;

        
        while (puntstotals1 < 50 && puntstotals2 < 50)
        {
            var result = JocDards.LanzarDardos(random, puntstotals1, puntstotals2);
            puntstotals1 = result.Item1;
            puntstotals2 = result.Item2;

            Console.WriteLine($"Jugador 1: {puntstotals1} | Jugador 2: {puntstotals2}");
        }

        if (puntstotals1 > puntstotals2)
            Console.WriteLine("Ha guanyat jugador 1");
        else
            Console.WriteLine("Ha guanyat jugador 2");
    }
   
}



