using TrabalhoP12AED.logica;
namespace TrabalhoP12AED.exercicios
{
    public class VectorLinhaLetrasAlfabeto
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Quantas letras do alfabeto pretende gerar?");
            string valor = Console.ReadLine();


            try
            {
                var quantidade = Convert.ToByte(valor);

                if(quantidade == 0 || quantidade > 26)
                {
                    throw new FormatException();
                }

                Console.Clear();

                Console.WriteLine("=========================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("VECTOR-LINHA COM AS LETRAS DO ALFABETO");
                Console.ResetColor();
                Console.WriteLine("=========================================");

                VectorLinha.LetrasDoAlfabeto(quantidade);

                Console.ReadLine();

                Console.Write("\nQuer continuar? (Sim/Não):");

                var opcao = Console.ReadLine();



            }
            catch(Exception)
            {
                Console.WriteLine("Formato incorreto. Por favor, digite um número válido (de 1 a 26). \n Pressione ENTER para continuar.");
                Console.ReadLine();
                Executar();
            }


        }
    }
}
