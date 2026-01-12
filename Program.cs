using System;

class Program
{
    static void Main()
    {
		
		Console.WriteLine("Tabuada de 1 a 10:");

        for (int i = 1; i<=10;i++)
        {
            Console.WriteLine();
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i*j}");
            }
        }

    }
}
