using TrabalhoP12AED.estrutura;
using TrabalhoP12AED.implementacao;

namespace TrabalhoP12AED.exercicios;

public class Exercicio4ArvoreDeBuscaBinaria()
{
    public static void Executar()
    {
        ArvoreDeBuscaBinaria arvore = new ArvoreDeBuscaBinaria();

        char[] elementos = { 'd', 'b', 'f', 'a', 'c', 'e', 'g' };
        foreach (char letra in elementos)
            arvore.Inserir(letra);

        ExibirCabecalho();
        ExibirEstruturaVisual();
        Console.Write("  Elementos em ordem: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        arvore.ExibirEmOrdem(arvore.Raiz);
        Console.ResetColor();
        Console.WriteLine("\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  ┌───────────────────────────────────────────┐");
            Console.WriteLine("  │  Digite uma letra (a-z) ou '0' para sair  │");
            Console.Write("  └─► ");
            Console.ResetColor();

            string entrada = Console.ReadLine()?.Trim().ToLower();

            if (entrada == "0")
                break;

            if (string.IsNullOrEmpty(entrada) || entrada.Length > 1 || entrada[0] < 'a' || entrada[0] > 'z')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  ⚠  Entrada inválida! Digite apenas uma letra de 'a' até 'z'.\n");
                Console.ResetColor();
                
                continue;
            }

            char letraPesquisa = entrada[0];

            Console.WriteLine();
            ExibirBusca(arvore, letraPesquisa);
            Console.WriteLine();
        }

        MenuPrincipal.Executar();
    }

    // ──────────────────────────────────────────
    // Exibe cabeçalho do programa
    // ──────────────────────────────────────────
    private static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("  ╔══════════════════════════════════════╗");
        Console.WriteLine("  ║     ÁRVORE BINÁRIA DE BUSCA (a-g)    ║");
        Console.WriteLine("  ╚══════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
    }

    // ──────────────────────────────────────────
    // Exibe a estrutura visual da árvore
    // ──────────────────────────────────────────
    private static void ExibirEstruturaVisual()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("  Estrutura da árvore:");
        Console.WriteLine();
        Console.WriteLine("            [d]          ← raiz (nível 0)");
        Console.WriteLine("           /   \\");
        Console.WriteLine("         [b]   [f]        ← nível 1");
        Console.WriteLine("        /  \\ /  \\");
        Console.WriteLine("      [a][c][e][g]        ← nível 2");
        Console.ResetColor();
        Console.WriteLine();
    }

    // ──────────────────────────────────────────
    // Realiza a busca e exibe o caminho passo a passo
    // ──────────────────────────────────────────

    private static void ExibirBusca(ArvoreDeBuscaBinaria arvore, char letra)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"  🔍 Buscando '{letra}'...");
        Console.ResetColor();
        Console.WriteLine("  " + new string('─', 38));

        No atual = arvore.Raiz;
        int nivel = 0;
        bool encontrado = false;
        string caminho = "";

        while (atual != null)
        {
            caminho += $"'{atual.Valor}'";

            if (letra == atual.Valor)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"  Nível {nivel}: [{atual.Valor}]  ✔ encontrado!");
                Console.ResetColor();
                encontrado = true;
                break;
            }
            else if (letra < atual.Valor)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"  Nível {nivel}: [{atual.Valor}]  '{letra}' < '{atual.Valor}' → esquerda");
                Console.ResetColor();
                caminho += " → ";
                atual = atual.Esquerdo;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"  Nível {nivel}: [{atual.Valor}]  '{letra}' > '{atual.Valor}' → direita");
                Console.ResetColor();
                caminho += " → ";
                atual = atual.Direito;
            }

            nivel++;
        }

        Console.WriteLine("  " + new string('─', 38));

        if (encontrado)
        {
            int endereco = atual!.GetHashCode();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  ✔  Letra '{letra}' ENCONTRADA no nível {nivel}!");
            Console.WriteLine($"  📍 Endereço do nó : 0x{endereco:X}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"  🗺  Caminho        : {caminho}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  ✘  Letra '{letra}' NÃO existe na árvore (a-g).");
            Console.ResetColor();
        }
    }
}
