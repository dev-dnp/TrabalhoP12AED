using TrabalhoP12AED;
using TrabalhoP12AED.estrutura;
using TrabalhoP12AED.implementacao;


namespace TrabalhoP12AED.exercicios;
public class Exercicio3VectorLinha
{
    public static void Executar()
    {
        while(true)
        {
            ExibirCabecalho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tESCOLHA A FORMA DE APRESENTAÇÃO:\n");
            Console.ResetColor();

            Console.WriteLine("\t1 - Maiúsculas");
            Console.WriteLine("\t2 - Minuscúlas");
            Console.WriteLine("\t3 - Ajuda");
            Console.WriteLine("\t0 - Sair");

            Console.Write("\n\n\tEscolha uma opção: ");

            string opcao = Console.ReadLine().Trim();

            switch(opcao)
            {
                case "1":
                    ExibirLetras("caixa-alta");
                    break;
                case "2":
                    ExibirLetras("caixa-baixa");
                    break;
                case "3":
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

    private static void ExibirLetras(string caixa)
    {
        string letras = VectorLinha.LetrasDoAlfabeto(caixa);

        if(caixa == "caixa-alta")
        {
            Console.Clear();

            ExibirCabecalho();

        //  Console.WriteLine("\t╚════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tEstas são as letras maiúsculas do alfabeto completo: ");
            Console.ResetColor();

            Console.WriteLine("\tA, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S,");
            Console.WriteLine("\tT, U, V, W, X, Y, Z.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEstas são as 16 primeiras letras maiúsculas do alfabeto:");
            Console.ResetColor();

            Console.WriteLine("\t" + letras);

            Utilitario.MensagemParaVoltar();
        }
        else if (caixa == "caixa-baixa")
        {
            Console.Clear();

            ExibirCabecalho();

        //  Console.WriteLine("\t╚════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tEstas são as letras maiúsculas do alfabeto completo: ");
            Console.ResetColor();

            Console.WriteLine("\ta, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s,");
            Console.WriteLine("\tt, u, v, w, x, y, z.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEstas são as 16 primeiras letras minúsculas do alfabeto:");
            Console.ResetColor();

            Console.WriteLine("\t" + letras);

            Utilitario.MensagemParaVoltar();
        }

            
    }

    private static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t╔════════════════════════════════════════════════════════╗");
        Console.WriteLine("\t║   VECTOR-LINHA COM AS 16 PRIMEIRAS LETRAS DO ALFABETO  ║");
        Console.WriteLine("\t╚════════════════════════════════════════════════════════╝");
        
        Utilitario.LinhaSeparadora();

        Console.ResetColor();
        Console.WriteLine();
    }

    private static void ExibirMenuAjuda()
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@"
        ╔═════════════════════════════════════════════════════════╗
        ║   ----------------      AJUDA       -----------------   ║
        ║   VECTOR-LINHA COM AS 16 PRIMEIRAS LETRAS DO ALFABETO   ║
        ╚═════════════════════════════════════════════════════════╝
        ");
        Console.ResetColor();


        Console.WriteLine(@"
                Este programa permite visualizar o alfabeto
                em diferentes formatos.

                OPÇÕES:

                1 - Mostra o alfabeto em MAIÚSCULAS
                2 - Mostra o alfabeto em MINÚSCULAS
                3 - Abre este menu de ajuda
                0 - Encerra o programa

                Nota:
                - Use apenas números para navegar no menu.
                - Pressione ENTER após escolher uma opção.

        ");

        Utilitario.MensagemParaVoltar();
    }

}