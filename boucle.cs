using System;

class Program
{
    static void Main()
    {
        // Création du tableau moves de taille 32
        string[] moves = new string[32];
        int count = 0;

        // Boucle pour permettre à l'utilisateur de rentrer les pas de danse
        Console.WriteLine("Entrez vos pas de danse (ou tapez 'done' pour terminer) :");
        while (count < moves.Length)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            moves[count] = input;
            count++;
        }

        // Demande du nombre d'itérations
        Console.WriteLine("Entrez le nombre d'itérations :");
        int iterations = int.Parse(Console.ReadLine());

        // Répétition des pas de danse
        for (int i = 0; i < iterations; i++)
        {
            Console.WriteLine($"Itération {i + 1} :");
            for (int j = 0; j < count; j++)
            {
                Console.WriteLine(moves[j]);
            }
        }
    }
}
