using TrabalhoP12AED.exercicios;

namespace TrabalhoP12AED
{
    
    public class MenuPrincipal
    {
        public static void Executar()
        {
            while(true)
            {
                ExibirCabecalho();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\tESCOLHA UMA OPÇÃO:\n");
                Console.ResetColor();

                Console.WriteLine("\t 1 - Árvores Binárias");
                Console.WriteLine("\t 2 - Média Geométrica");
                Console.WriteLine("\t 3 - Vector-linha");
                Console.WriteLine("\t 4 - Árvore de Busca Binária");
                Console.WriteLine("\t 5 - Serviço Militar");
                Console.WriteLine("\t 0 - Sair");
                Console.Write("\n\n\tEscolha uma opção: ");

                var opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1": 
                        Exercicio1ArvoresBinarias.Executar();
                        break;
                    case "2": 
                        Exercicio2MediaGeometrica.Executar();
                        break;
                    case "3": 
                        Exercicio3VectorLinha.Executar();
                        break;
                    case "4": 
                        Exercicio4ArvoreDeBuscaBinaria.Executar();
                        break;
                    case "5": 
                        Exercicio5ServicoMilitar.Executar();
                        break;
                    case "0": 
                        Console.Clear();
                        Console.WriteLine("Saindo da aplicação...");
                        Environment.Exit(0);
                        break;
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
            Console.WriteLine("\t║                          MENU                           ║");
            Console.WriteLine("\t╚═════════════════════════════════════════════════════════╝");
            

            Console.ResetColor();
            Console.WriteLine();
        }

        private static void LinhaSeparadora()
        {
            Console.WriteLine("\t..........................................................");
        }

    }
}
