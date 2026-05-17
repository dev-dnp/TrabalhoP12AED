using TrabalhoP12AED.modelos;
using TrabalhoP12AED.logica;

namespace TrabalhoP12AED.exercicios
{

    public class ArvoresBinarias
    {
        public static void Executar()
        {

            // Nivel 0
            No raiz = new No("a");

            // Nivel 1

            raiz.Esquerda = new No("b");
            raiz.Direita = new No("c");

            // Nivel 2
            raiz.Esquerda.Esquerda = new No("d");
            raiz.Esquerda.Direita = new No("e");

            raiz.Direita.Direita = new No("f");

            // Nivel 3
            raiz.Direita.Direita.Esquerda = new No("g");
            Console.Clear();

            Console.WriteLine(@"
                a
              /   \
             b     c
            / \     \
           d   e     f
                    /
                   g
            ");




            Console.WriteLine("==============================");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PRÉ-ORDEM: ");
            Console.ResetColor();

            PercorrerArvoreBinaria.PreOrdem(raiz);

            Console.WriteLine();
            Console.WriteLine("==============================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("EM-ORDEM: ");
            Console.ResetColor();

            PercorrerArvoreBinaria.EmOrdem(raiz);

            Console.WriteLine();
            Console.WriteLine("==============================");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PÓS-ORDEM: ");
            Console.ResetColor();

            PercorrerArvoreBinaria.PosOrdem(raiz);

            Console.WriteLine();
            Console.WriteLine("==============================");

            Console.WriteLine();


        }
    }

}
