using TrabalhoP12AED.estrutura;
using TrabalhoP12AED.implementacao;

namespace TrabalhoP12AED.exercicios;
public class Exercicio4ArvoreDeBuscaBinaria()
{
    public static void Executar()
    {

        while(true)
        {
            ExibirCabecalho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tESCOLHA UMA OPÇÃO:\n");
            Console.ResetColor();

            Console.WriteLine("\t 1 - Árvore de Busca Binária (a - g)");
            Console.WriteLine("\t 2 - Ajuda");
            Console.WriteLine("\t 0 - Sair");
            
            Console.Write("\n\n\tEscolha uma opção: ");

            string opcao = Console.ReadLine().Trim();

            switch(opcao)
            {
                case "1":
                    ExibirArvoreDeBuscaBinaria();
                    break;
                case "2":
                    ExibirMenuAjuda();
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

    private static void ExibirArvoreDeBuscaBinaria()
    {
        ArvoreDeBuscaBinaria arvore = new ArvoreDeBuscaBinaria();

        char[] elementos = { 'd', 'b', 'f', 'a', 'c', 'e', 'g' };

        foreach (char letra in elementos)
            arvore.Inserir(letra);


        while (true)
        {
            ExibirCabecalho();
            // ExibirEstruturaVisual();

            Console.Write("\tElementos em ordem: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            arvore.ExibirEmOrdem(arvore.Raiz);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\t┌───────────────────────────────────────────┐");
            Console.WriteLine("\t│  Digite uma letra (a-z) ou '0' para sair  │");
            Console.Write("\t└─► ");
            Console.ResetColor();

            string entrada = Console.ReadLine()?.Trim().ToLower();

            if (entrada == "0")
                break;

            if (string.IsNullOrEmpty(entrada) || entrada.Length > 1 || entrada[0] < 'a' || entrada[0] > 'z')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tEntrada inválida! Digite apenas uma letra de 'a' até 'z'");
                Console.ResetColor();
                Console.ReadKey();
                continue;
            }

            char letraPesquisa = entrada[0];

            Console.WriteLine();
            ExibirBusca(arvore, letraPesquisa);
            Console.WriteLine();
        }
    }

    private static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("\t║               ÁRVORE BINÁRIA DE BUSCA (a-g)             ║");
        Console.WriteLine("\t╚═════════════════════════════════════════════════════════╝");

        Console.WriteLine(@"
                Estrutura da árvore:
            
                       [d]             ← Nível 0 (raíz)
                      /   \          
                    [b]    [f]         ← Nível 1
                   /  \    /  \      
                 [a]  [c] [e]  [g]     ← Nível 2
        ");
        Console.ResetColor();
        Console.WriteLine();
            
        Utilitario.LinhaSeparadora();
        Console.ResetColor();
        Console.WriteLine();
    }

    private static void ExibirMenuAjuda()
    {
        Console.WriteLine(@"
        ╔══════════════════════════════════════════════╗
        ║   ÁRVORE BINÁRIA DE BUSCA (A FIXA: A - G)   ║
        ╚══════════════════════════════════════════════╝

        Este programa utiliza uma árvore binária
        já pré-definida com os elementos:

                        D
                     /     \
                    B       F
                   / \     / \
                  A   C   E   G

        FUNCIONALIDADES:

        1 - Pesquisar elemento
            Verifica se uma letra (A a G) existe na árvore.

        2 - Mostrar árvore
            Exibe a estrutura fixa da árvore.

        3 - Percorrer árvore
            - Pré-ordem
            - Em ordem
            - Pós-ordem

        0 - Sair

        REGRAS:
        - A árvore é fixa (não permite inserção nem remoção)
        - Apenas letras de A até G são válidas

        ");

        Utilitario.MensagemParaVoltar();
    }

    // ──────────────────────────────────────────
    // Exibe a estrutura visual da árvore
    // ──────────────────────────────────────────

    private static void ExibirEstruturaVisual()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@"
                Estrutura da árvore:
            
                       [d]             ← Nível 0 (raíz)
                      /   \          
                    [b]    [f]         ← Nível 1
                   /  \    /  \      
                 [a]  [c] [e]  [g]     ← Nível 2
        ");


        
        Console.ResetColor();
        Console.WriteLine();
    }

    // ──────────────────────────────────────────
    // Realiza a busca e exibe o caminho passo a passo
    // ──────────────────────────────────────────

    private static void ExibirBusca(ArvoreDeBuscaBinaria arvore, char letra)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\t🔍 Buscando '{letra}'...");
        Console.ResetColor();
        Console.WriteLine("\t" + new string('─', 60));

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
                Console.WriteLine($"\tNível {nivel}: [{atual.Valor}]  ✔ encontrado!");
                Console.ResetColor();
                encontrado = true;
                break;
            }
            else if (letra < atual.Valor)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"\tNível {nivel}: [{atual.Valor}]  '{letra}' < '{atual.Valor}' → esquerda");
                Console.ResetColor();
                caminho += " → ";
                atual = atual.Esquerdo;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"\tNível {nivel}: [{atual.Valor}]  '{letra}' > '{atual.Valor}' → direita");
                Console.ResetColor();
                caminho += " → ";
                atual = atual.Direito;
            }

            nivel++;
        }

        Console.WriteLine("\t" + new string('─', 60));

        if (encontrado)
        {
            int endereco = atual.GetHashCode();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t✅ Letra '{letra}' ENCONTRADA no nível {nivel}!");
            Console.WriteLine($"\t📍 Endereço do nó na memória do computador em hexadecimal:");
            Console.WriteLine($"\t   0x{endereco:X}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\t🗺  Caminho: {caminho}");
            Console.Write("\n\t");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\t✘  Letra '{letra}' NÃO existe na árvore (a-g).");
            Console.Write("\n\n\t");
            Console.ResetColor();
        }

        Console.Write("Prima qualquer tecla para continuar");
        Console.ReadKey();
    }
}
