using System;

class Program
{
    static void Main(string[] args)
    {
        Map();
    }
    public static void Map()
    {
        Mapping mapUtility = new Mapping();
        var mapArr = mapUtility.Array;
        for (int i = 0; i < mapArr.GetLength(0); i++)
        {
            for (int j = 0; j <= mapArr.GetLength(0); j++)
            {
                if (j % 9 == 0)
                {
                    if ( j == 0) 
                    {
                        Console.Write(mapArr[i, j] + " ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Write(mapArr[i, j] + " ");
                }
            }
        }
    }
}