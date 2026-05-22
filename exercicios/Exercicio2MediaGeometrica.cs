namespace TrabalhoP12AED.exercicios;

public class Exercicio2MediaGeometrica()
{
    
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("=== Calculadora de Taxa Média Anual de Crescimento do PIB ===");
        Console.WriteLine();

        // Solicitar o número de anos
        int n;
        while (true)
        {
            Console.Write("Informe o número de anos (N): ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                break;
            Console.WriteLine("Erro: informe um número inteiro positivo.");
        }

        double[] taxas = new double[n];

        // Coletar as taxas de crescimento anuais
        Console.WriteLine();
        Console.WriteLine("Informe as taxas de crescimento anual do PIB (em %):");
        
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"  Taxa do ano {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out taxas[i]))
                    break;
                Console.WriteLine("  Erro: informe um número válido.");
            }
        }

        // Calcular o produto acumulado: ∏(1 + taxa_n / 100)

        double produto = 1.0;

        for (int i = 0; i < n; i++)
        {
            produto *= (1 + taxas[i] / 100.0);
        }

        // Calcular a média geométrica: N-ésima raiz do produto - 1
        double mediaGeometrica = Math.Pow(produto, 1.0 / n) - 1;


        Console.Clear();

        // Exibir resultado
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nRESULTADO\n");
        Console.ResetColor();


        Console.WriteLine($"Número de anos (N)              :  {n}");
        Console.WriteLine($"Produto acumulado               :  {produto:F6}");
        Console.WriteLine($"Média Geométrica de Crescimento :  {mediaGeometrica * 100:F4}% ao ano");
        Console.WriteLine(); 

        // Exibir detalhes por ano
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nDETALHAMENTO POR ANO\n");
        Console.ResetColor();


        Console.WriteLine($"{"Ano",-6} {"Taxa (%)",-12} {"(1 + taxa)",-14}");
        Console.WriteLine(new string('-', 34));
        for (int i = 0; i < n; i++)
        {
            double fator = 1 + taxas[i] / 100.0;
            Console.WriteLine($"{i + 1,-6} {taxas[i],-12:F2} {fator,-14:F6}");
        }

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
        MenuPrincipal.Executar();
    }
}