using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Challenge: Borner une saisie utilisateur");

        // Demander à l'utilisateur de saisir les limites
        Console.Write("Limit1: ");
        int limit1 = int.Parse(Console.ReadLine());
        Console.Write("Limit2: ");
        int limit2 = int.Parse(Console.ReadLine());

        // Déterminer le minimum et le maximum parmi les deux limites
        int min = Math.Min(limit1, limit2);
        int max = Math.Max(limit1, limit2);

        // Demander à l'utilisateur de saisir un entier à borner
        Console.Write("Integer to limit: ");
        int input = int.Parse(Console.ReadLine());

        // Borner l'entier saisi par l'utilisateur
        if (input < min)
        {
            Console.WriteLine($"You have entered {input} which is lower than {min} which is the minimum");
            Console.WriteLine("Resulting integer: " + min);
        }
        else if (input > max)
        {
            Console.WriteLine($"You have entered {input} which is greater than {max} which is the maximum");
            Console.WriteLine("Resulting integer: " + max);
        }
        else
        {
            Console.WriteLine("The integer is within the limits provided by the user.");
            Console.WriteLine("Resulting integer: " + input);
        }
    }
}
