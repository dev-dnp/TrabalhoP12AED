using TrabalhoP12AED;
using TrabalhoP12AED.implementacao;

namespace TrabalhoP12AED.exercicios
{
    public class Exercicio3VectorLinha
    {
        public static void Executar()
        {
            Console.Clear();

            Console.WriteLine("VECTOR-LINHA COM AS 16 PRIMEIRAS LETRAS DO ALFABETO");
            
            Console.WriteLine("-----------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nESCOLHA A FORMA DE APRESENTAÇÃO:\n");
            Console.ResetColor();

            Console.WriteLine("1 - Maiúsculas");
            Console.WriteLine("2 - Minuscúlas");
            Console.WriteLine("0 - Sair");

            Console.Write("\n\nResposta: ");

            string opcao = Console.ReadLine().Trim();

            switch(opcao)
            {
                case "1":
                    ExibirLetrasMaiusculas();
                    break;
                case "2":
                    ExibirLetrasMinisculas();
                    break;
                case "0":
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

        private static void ExibirLetrasMaiusculas()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVECTOR-LINHA COM LETRAS MAIÚSCULAS:\n");
            Console.ResetColor();

            Console.WriteLine("-----------------------------------");


            string letras = VectorLinha.LetrasDoAlfabeto("caixa-alta");

            Console.WriteLine(letras);
            Console.WriteLine();

            MensagemParaVoltar();
        }

        private static void ExibirLetrasMinisculas()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVECTOR-LINHA COM LETRAS MINUSCÚLAS:\n");
            Console.ResetColor();

            Console.WriteLine("-----------------------------------");


            string letras = VectorLinha.LetrasDoAlfabeto();

            Console.WriteLine(letras);
            Console.WriteLine();

            MensagemParaVoltar();
        }

        private static void MensagemParaVoltar()
        {
            Console.WriteLine("\nPrima qualquer tecla para voltar");
            Console.ReadKey();
            Executar();
        }
    }
}
