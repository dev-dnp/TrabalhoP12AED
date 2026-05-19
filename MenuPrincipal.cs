using TrabalhoP12AED.exercicios;

namespace TrabalhoP12AED
{
    
    public class MenuPrincipal
    {
        public static void Executar()
        {
            Console.Clear();



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MENU: \n");
            Console.ResetColor();

            Console.WriteLine("1 - Árvores Binárias");
            Console.WriteLine("2 - [NÃO DISPONIVEL] Média Geométrica");
            Console.WriteLine("3 - Vector-linha");
            Console.WriteLine("4 - Árvore de Busca Binária");
            Console.WriteLine("5 - Serviço Militar");
            Console.WriteLine("6 - Sair");
            Console.Write("\n\nResposta: ");

            var opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1": 
                    ArvoresBinarias.Executar();
                    break;
                case "2": 
                    Console.WriteLine("Não disponível");
                    break;
                case "3": 
                    VectorLinhaLetrasAlfabeto.Executar();
                    break;
                case "4": 
                    // ArvoresBinarias.Executar();
                    break;
                case "5": 
                    Console.WriteLine("Não disponível");
                    break;
                case "6": 
                    Console.Clear();
                    Console.WriteLine("Saindo da aplicação...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nResposta Inválida!\n");
                    Console.ResetColor();
                    Console.ReadKey();
                    Executar();
                    break;
            }
        }
    }
}
