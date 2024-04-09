using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculette basique :");
            Console.Write("Premier opérande : ");
            float operand1 = float.Parse(Console.ReadLine());
            Console.Write("Deuxième opérande : ");
            float operand2 = float.Parse(Console.ReadLine());
            Console.Write("Choisissez l'opération (add, subtract, multiply, divide, modulo) : ");
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "add":
                    Console.WriteLine($"{operand1} + {operand2} = {Add(operand1, operand2)}");
                    break;
                case "subtract":
                    Console.WriteLine($"{operand1} - {operand2} = {Subtract(operand1, operand2)}");
                    break;
                case "multiply":
                    Console.WriteLine($"{operand1} x {operand2} = {Multiply(operand1, operand2)}");
                    break;
                case "divide":
                    Console.WriteLine($"{operand1} ÷ {operand2} = {Divide(operand1, operand2)}");
                    break;
                case "modulo":
                    Console.WriteLine($"Le reste de la division de {operand1} par {operand2} est {Modulo(operand1, operand2)}");
                    break;
                default:
                    Console.WriteLine($"Opération inconnue : {operation}");
                    break;
            }

            Console.WriteLine("Appuyez sur une touche pour continuer ou Ctrl+C pour quitter.");
            Console.ReadKey();
            Console.Clear(); // Efface la console pour la prochaine opération
        }
    }

    static float Add(float a, float b)
    {
        return a + b;
    }

    static float Subtract(float a, float b)
    {
        return a - b;
    }

    static float Multiply(float a, float b)
    {
        return a * b;
    }

    static float Divide(float a, float b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Division par zéro impossible !");
            return float.NaN;
        }
    }

    static float Modulo(float a, float b)
    {
        return a % b;
    }
}
