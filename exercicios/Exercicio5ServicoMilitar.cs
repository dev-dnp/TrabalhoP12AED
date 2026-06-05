using TrabalhoP12AED.estrutura;
using TrabalhoP12AED.implementacao;

namespace TrabalhoP12AED.exercicios;
public class Exercicio5ServicoMilitar()
{
    public static void Executar()
    {

        while(true)
        {
            ExibirCabecalho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tESCOLHA UMA OPÇÃO:\n");
            Console.ResetColor();

            Console.WriteLine("\t 1 - Criar utilizador");
            Console.WriteLine("\t 2 - Listar utilizadores");
            Console.WriteLine("\t 3 - Editar utilizador");
            Console.WriteLine("\t 4 - Eliminar utilizador");
            Console.WriteLine("\t 4 - Ajuda");
            Console.WriteLine("\t 0 - Sair");
            
            Console.Write("\n\n\tEscolha uma opção: ");

            string opcao = Console.ReadLine().Trim();

            switch(opcao)
            {
                case "1":
                    // ServicoMilitarObrigatorio.Avaliar();
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

    private static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("\t║                       SERVIÇO MILITAR                   ║");
        Console.WriteLine("\t╚═════════════════════════════════════════════════════════╝");

            
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

}
