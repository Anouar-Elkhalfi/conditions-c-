using System;

class Program
{
    static void Main()
    {

        int[] tableau1 = new int[5];
        int[] tableau2 = new int[5];


        for (int i = 0; i < tableau1.Length; i++)
        {
            tableau1[i] = i + 1;
            tableau2[i] = i + 6;
        }

        /
        int[] tableau3 = new int[tableau1.Length + tableau2.Length];


        for (int i = 0; i < tableau1.Length; i++)
        {
            tableau3[i] = tableau1[i];
        }


        for (int i = 0; i < tableau2.Length; i++)
        {
            tableau3[tableau1.Length + i] = tableau2[i];
        }

        // Afficher le contenu des trois tableaux
        Console.WriteLine("Contenu du premier tableau :");
        AfficherTableau(tableau1);
        Console.WriteLine("Contenu du deuxième tableau :");
        AfficherTableau(tableau2);
        Console.WriteLine("Contenu du troisième tableau :");
        AfficherTableau(tableau3);
    }

    static void AfficherTableau(int[] tableau)
    {
        foreach (var valeur in tableau)
        {
            
