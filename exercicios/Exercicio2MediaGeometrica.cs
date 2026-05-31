using System.Diagnostics.CodeAnalysis;
using TrabalhoP12AED.estrutura;

namespace TrabalhoP12AED.exercicios;

public class Exercicio2MediaGeometrica()
{
    
    public static void Executar()
    {
        while(true)
        {
            ExibirCabecalho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tESCOLHA UMA OPÇÃO:\n");
            Console.ResetColor();

            Console.WriteLine("\t1 - Calcular");
            Console.WriteLine("\t2 - Ajuda");
            Console.WriteLine("\t0 - Voltar");

            Console.Write("\n\n\tEscolha uma opção: ");

            string opcao = Console.ReadLine().Trim();

            switch(opcao)
            {
                case "1":
                    Calcular();
                    break;
                case "2":
                    ExibirMenuDeAjuda();
                    break;
                case "0":
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\tOpção inválida!");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
            }

        }
    }

    private static void Calcular()
    {
        ExibirCabecalho();

            // Solicitar o número de anos
            int n;

            while (true)
            {
                ExibirCabecalho();

                Console.Write("\tInforme o número de anos (N): ");

                if (int.TryParse(Console.ReadLine(), out n) && n > 0)  break;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tErro: informe um número inteiro positivo.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }

            double[] taxas = new double[n];

            // Coletar as taxas de crescimento anuais
            Console.WriteLine();
            Console.WriteLine("\tInforme as taxas de crescimento anual do PIB (em %):");
            

            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    ExibirCabecalho();
                    Console.Write($"\tTaxa do ano {i + 1}: ");

                    if (double.TryParse(Console.ReadLine(), out taxas[i])) break;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErro: informe um número válido.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();

                }
            }

            // Calcular o produto acumulado: ∏(1 + taxa_n / 100)

            MediaGeometricaCrescimentoPIB MGCrescimentoPIB = new MediaGeometricaCrescimentoPIB(n, taxas);
            MGCrescimentoPIB.Calcular();

            ExibirCabecalho();

            // Exibir resultado
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tRESULTADO\n");
            Console.ResetColor();


            Console.WriteLine($"\tNúmero de anos (N)              :  {n}");
            Console.WriteLine($"\tProduto acumulado               :  {MGCrescimentoPIB.Produto:F6}");
            Console.WriteLine($"\tMédia Geométrica de Crescimento :  {MGCrescimentoPIB.ValorMediaGeometrica * 100:F4}% ao ano");
            Console.WriteLine(); 

            // Exibir detalhes por ano
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tDETALHAMENTO POR ANO\n");
            Console.ResetColor();


            Console.WriteLine($"\t{"Ano",-6} {"Taxa (%)",-12} {"(1 + taxa)",-14}");
            Utilitario.LinhaSeparadora();

            MGCrescimentoPIB.ExibirDadosDeEntrada();

            Utilitario.MensagemParaVoltar();
    }

    private static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("\t║  CALCULADORA DE TAXA MÉDIA ANUAL DE CRESCIMENTO DO PIB  ║");
        Console.WriteLine("\t╚═════════════════════════════════════════════════════════╝");
        
        Utilitario.LinhaSeparadora();
        Console.ResetColor();
        Console.WriteLine();
    }

    private static void ExibirMenuDeAjuda()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@"
        ╔═════════════════════════════════════════════════════════╗
        ║            ------------- AJUDA -----------------        ║
        ║  CALCULADORA DE TAXA MÉDIA ANUAL DE CRESCIMENTO DO PIB  ║
        ╚═════════════════════════════════════════════════════════╝
        ");
        Console.ResetColor();

        Console.WriteLine($@"

        Esta calculadora utiliza a MÉDIA GEOMÉTRICA para calcular
        a taxa média anual de crescimento do PIB.

        ──────────────────────────────────────────────────────────

        COMO O CÁLCULO FUNCIONA

        1) Converter a taxa para fator de crescimento

        Exemplos:

        50%  -> 1,50
        10%  -> 1,10
        -5%  -> 0,95

        Fórmula:

        (1 + taxa)

        ──────────────────────────────────────────────────────────

        2) Multiplicar todos os fatores

        Exemplo:

        1,50 × 1,50 = 2,25

        Esse valor representa o crescimento acumulado.

        ──────────────────────────────────────────────────────────

        3) Aplicar a média geométrica

        Fórmula:

        MG = (Produto)^(1 / N) - 1

        Onde:

        MG = Média Geométrica
        N  = Número de anos

        ──────────────────────────────────────────────────────────

        EXEMPLO PRÁTICO

        Ano 1 -> 50%
        Ano 2 -> 50%

        1,50 × 1,50 = 2,25

        MG = (2,25)^(1/2) - 1

        MG = 1,50 - 1

        MG = 0,50

        Resultado:

        50% ao ano

        ──────────────────────────────────────────────────────────

        OBSERVAÇÕES IMPORTANTES

        • A média geométrica é mais precisa para crescimento
          econômico do que a média aritmética.

        • O cálculo considera crescimento composto.

        • Taxas negativas podem ser utilizadas.

        • Uma taxa de -100% gera fator 0, impossibilitando
          o cálculo da média geométrica.

        ──────────────────────────────────────────────────────────

        INTERPRETAÇÃO DO RESULTADO

        • Resultado positivo:
          Crescimento médio anual do PIB.

        • Resultado negativo:
          Redução média anual do PIB.

        • Resultado igual a 0:
          O PIB permaneceu estável no período.

        ──────────────────────────────────────────────────────────
    ");

        Utilitario.MensagemParaVoltar();
        
    }


}