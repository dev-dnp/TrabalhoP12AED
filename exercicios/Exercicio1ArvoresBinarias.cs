using TrabalhoP12AED;
using TrabalhoP12AED.estrutura;
using TrabalhoP12AED.implementacao;

namespace TrabalhoP12AED.exercicios
{

    public class ArvoresBinarias
    {
        public static void Executar()
        {
            Console.Clear();

            // Nivel 0
            var raiz = new No<string>("a");

            // Nivel 1

            raiz.Esquerdo = new No<string>("b");
            raiz.Direito = new No<string>("c");

            // Nivel 2
            raiz.Esquerdo.Esquerdo = new No<string>("d");
            raiz.Esquerdo.Direito = new No<string>("e");

            raiz.Direito.Direito = new No<string>("f");

            // Nivel 3
            raiz.Direito.Direito.Esquerdo = new No<string>("g");
            

            ExibirArvore();

            Console.WriteLine("-----------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nESCOLHA UMA OPÇÃO:\n");
            Console.ResetColor();

            Console.WriteLine("1 - Percurso Pré-ordem");
            Console.WriteLine("2 - Percurso Em-ordem");
            Console.WriteLine("3 - Percurso Pós-ordem");
            Console.WriteLine("4 - Mostrar todos os Percursos");
            Console.WriteLine("5 - Sair");
            
            Console.Write("\n\nResposta: ");

            string opcao = Console.ReadLine().Trim();

            switch(opcao)
            {
                case "1":
                    ExibirPreOrdem(raiz);
                    break;
                case "2":
                    ExibirEmOrdem(raiz);
                    break;
                case "3":
                    ExibirPosOrdem(raiz);
                    break;
                case "4":
                    ExibirTodosPercusos(raiz);
                    break;
                case "5":
                    MenuPrincipal.Executar();
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

        private static void ExibirPreOrdem(No<string> raiz)
        {
            Console.Clear();

            ExibirArvore();

            Console.WriteLine("-----------------------------------\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PRÉ-ORDEM: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PreOrdem(raiz);
            Console.WriteLine(ArvoreBinariaPercurso.ExibirPercurso());
            
            Console.WriteLine("\n-----------------------------------");

            MensagemParaVoltar();  
        }

        private static void ExibirEmOrdem(No<string> raiz)
        {
            Console.Clear();
            
            ExibirArvore();

            Console.WriteLine("-----------------------------------\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("EM-ORDEM: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.EmOrdem(raiz);
            Console.WriteLine(ArvoreBinariaPercurso.ExibirPercurso());
            
            Console.WriteLine("\n-----------------------------------");

            MensagemParaVoltar(); 
        }

        private static void ExibirPosOrdem(No<string> raiz)
        {
            Console.Clear();
            
            ExibirArvore();

            Console.WriteLine("-----------------------------------\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("POS-ORDEM: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PosOrdem(raiz);
            Console.WriteLine(ArvoreBinariaPercurso.ExibirPercurso());
            
            Console.WriteLine("\n-----------------------------------");

            MensagemParaVoltar(); 
        }

        private static void ExibirTodosPercusos(No<string> raiz)
        {
            Console.Clear();
            ExibirArvore();
            
            Console.WriteLine("-----------------------------------\n");

            // EXIBIR EM PRE-ORDEM

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PRÉ-ORDEM: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PreOrdem(raiz);
            Console.WriteLine(ArvoreBinariaPercurso.ExibirPercurso());
            Console.WriteLine("\n");


            // EXIBIR EM EM-ORDEM

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("EM-ORDEM: ");
            Console.ResetColor();


            ArvoreBinariaPercurso.EmOrdem(raiz);
            Console.WriteLine(ArvoreBinariaPercurso.ExibirPercurso());
            Console.WriteLine("\n");


            // EXIBIR EM POS-ORDEM

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("POS-ORDEM: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PosOrdem(raiz);
            Console.WriteLine(ArvoreBinariaPercurso.ExibirPercurso());
            Console.WriteLine("\n");

            Console.WriteLine("-----------------------------------\n");

            MensagemParaVoltar();
        }

        private static void ExibirArvore()
        {
            Console.WriteLine(@"
                  a
                /   \
               b     c
              / \     \
             d   e     f
                      /
                     g
            ");
        }

        private static void MensagemParaVoltar()
        {
            Console.WriteLine("\nPrima qualquer tecla para voltar");
            Console.ReadKey();
            Executar();
        }


    }

}
