using TrabalhoP12AED.logica;
namespace TrabalhoP12AED.exercicios
{
    public class VectorLinhaLetrasAlfabeto
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("VECTOR-LINHA COM AS LETRAS DO ALFABETO");
            Console.ResetColor();
            Console.WriteLine("=========================================");

            VectorLinha.LetrasDoAlfabeto(5);

            Console.ReadLine();

            Console.WriteLine("\n \n \n");
        }
    }
}
