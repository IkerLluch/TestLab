﻿namespace Carrera;

class Program
{
    static void Main(string[] args)
    {
        var cr = new Carrera();

        int[,] carrera1 =
        {
            { 1, 4, 3, 5, 4, },
            { 2, 8, 2, 5, 7, },
            { 3, 7, 4, 6, 2, },
            { 4, 4, 3, 1, 3, },
            { 1, 6, 2, 9, 9, },
            { 2, 6, 9, 9, 5, },
            { 3, 6, 1, 6, 4, },
            { 4, 9, 4, 1, 6, },
            { 1, 4, 4, 5, 2, },
            { 2, 6, 2, 2, 1, },
            { 3, 8, 6, 8, 6, },
            { 4, 1, 8, 8, 1, },
            { 1, 9, 7, 8, 6, },
            { 2, 7, 8, 2, 3, },
            { 3, 4, 1, 2, 5, },
            { 4, 2, 6, 2, 9, },
            { 1, 3, 3, 4, 9, },
            { 2, 1, 2, 1, 5, },
            { 3, 1, 3, 3, 1, },
            { 4, 7, 9, 3, 2, },
            { 1, 7, 1, 9, 6, },
            { 2, 3, 4, 5, 7, },
            { 3, 5, 3, 7, 9, },
            { 4, 9, 2, 3, 2, },
            { 1, 3, 8, 5, 5, },
            { 2, 7, 9, 9, 6, },
            { 3, 9, 6, 6, 1, },
            { 4, 7, 2, 1, 4, },
            { 1, 7, 8, 4, 2, },
            { 2, 6, 1, 8, 3, },
            { 3, 4, 4, 2, 6, },
            { 4, 2, 3, 5, 2, },
            { 1, 1, 5, 6, 1, },
            { 2, 7, 9, 4, 3, },
            { 3, 5, 4, 6, 5, },
            { 4, 9, 5, 1, 7, },
            { 1, 8, 9, 4, 5, },
            { 2, 6, 6, 2, 2, },
            { 3, 5, 2, 4, 9, },
            { 4, 4, 5, 7, 6, },
        };

        int[,] carrera2 =
        {
            { 1, 6, 8, 5, 3, },
            { 2, 7, 6, 8, 1, },
            { 3, 6, 2, 5, 8, },
            { 4, 5, 2, 7, 1, },
            { 1, 8, 3, 2, 3, },
            { 2, 3, 5, 6, 7, },
            { 3, 5, 8, 1, 6, },
            { 4, 2, 3, 9, 6, },
            { 1, 9, 2, 8, 3, },
            { 2, 7, 2, 4, 3, },
            { 3, 3, 8, 3, 6, },
            { 4, 4, 8, 9, 9, },
            { 1, 3, 5, 2, 3, },
            { 2, 7, 4, 1, 7, },
            { 3, 1, 8, 2, 4, },
            { 4, 9, 6, 3, 8, },
            { 1, 4, 1, 9, 2, },
            { 2, 9, 3, 8, 8, },
            { 3, 9, 7, 5, 9, },
            { 4, 7, 2, 9, 7, },
            { 1, 5, 4, 5, 1, },
            { 2, 6, 3, 7, 4, },
            { 3, 9, 2, 3, 8, },
            { 4, 2, 6, 8, 2, },
            { 1, 3, 2, 7, 6, },
            { 2, 9, 2, 1, 4, },
            { 3, 9, 4, 9, 7, },
            { 4, 8, 9, 5, 8, },
            { 1, 8, 2, 1, 9, },
            { 2, 5, 4, 3, 1, },
            { 3, 9, 5, 7, 7, },
            { 4, 7, 4, 6, 1, },
            { 1, 5, 5, 1, 5, },
            { 2, 1, 2, 2, 1, },
            { 3, 6, 6, 1, 6, },
            { 4, 3, 9, 6, 6, },
            { 1, 1, 5, 5, 4, },
            { 2, 2, 3, 3, 5, },
            { 3, 6, 1, 9, 8, },
            { 4, 3, 1, 8, 7, },
        };

        int[,] carrera3 =
        {
            { 1, 1, 3, 2, 6, },
            { 2, 6, 6, 6, 3, },
            { 3, 7, 6, 2, 4, },
            { 4, 3, 2, 6, 3, },
            { 1, 7, 6, 2, 1, },
            { 2, 6, 6, 4, 2, },
            { 3, 6, 3, 7, 2, },
            { 4, 4, 5, 3, 1, },
            { 1, 1, 5, 8, 8, },
            { 2, 4, 2, 5, 8, },
            { 3, 3, 5, 7, 8, },
            { 4, 2, 3, 3, 9, },
            { 1, 2, 9, 5, 8, },
            { 2, 5, 4, 4, 5, },
            { 3, 8, 6, 3, 4, },
            { 4, 8, 6, 9, 1, },
            { 1, 2, 9, 5, 8, },
            { 2, 4, 2, 9, 4, },
            { 3, 9, 4, 3, 4, },
            { 4, 7, 4, 9, 4, },
            { 1, 4, 9, 9, 5, },
            { 2, 2, 7, 9, 9, },
            { 3, 9, 1, 8, 6, },
            { 4, 3, 3, 6, 4, },
            { 1, 2, 3, 6, 1, },
            { 2, 7, 1, 3, 5, },
            { 3, 7, 4, 5, 9, },
            { 4, 5, 2, 1, 6, },
            { 1, 2, 8, 5, 6, },
            { 2, 1, 9, 3, 5, },
            { 3, 2, 9, 8, 3, },
            { 4, 6, 4, 5, 1, },
            { 1, 3, 2, 4, 4, },
            { 2, 9, 8, 4, 6, },
            { 3, 5, 2, 1, 2, },
            { 4, 4, 9, 3, 2, },
            { 1, 9, 9, 8, 1, },
            { 2, 5, 9, 2, 6, },
            { 3, 1, 3, 8, 2, },
            { 4, 7, 2, 3, 2, },
        };

        Console.WriteLine("Guanyador de la Carrera 1: Corredor " + cr.ConsegueixElGuanyador(carrera1));
        Console.WriteLine("Guanyador de la Carrera 2: Corredor " + cr.ConsegueixElGuanyador(carrera2));
        Console.WriteLine("Guanyador de la Carrera 3: Corredor " + cr.ConsegueixElGuanyador(carrera3));
    }
}
public class Carrera{
    

public int ConsegueixElGuanyador(int[,] carrera)
    {
        int numCorredors = 4; 
        int[] distancia = new int[numCorredors + 1]; 

        for (int i = 0; i < carrera.GetLength(0); i++)
        {
            int corredor = carrera[i, 0];
            int max = 0;
            int min = 100;

            for (int j = 1; j < carrera.GetLength(1); j++)
            {
                if (carrera[i, j] > max) max = carrera[i, j];
                if (carrera[i, j] < min) min = carrera[i, j];
            }

            int distancia2 = max - min;
             distancia[corredor] += distancia2;
        }

        int guanyador = -1;
        int maxDistancia = int.MinValue;

        for (int i = 1; i <= numCorredors; i++)
        {
            if (distancia[i] > maxDistancia)
            {
                maxDistancia = distancia[i];
                guanyador = i;
            }
        }

        return guanyador;
    }
}