using TrabalhoP12AED.modelos;

namespace TrabalhoP12AED.logica
{
    public class PercorrerArvoreBinaria
    {

        public static void PreOrdem(No no)
        {
            if (no == null) return;

            Console.Write(no.Valor + ", ");
            PreOrdem(no.Esquerda);
            PreOrdem(no.Direita);
        }

        public static void EmOrdem(No no)
        {
            if (no == null) return;

            EmOrdem(no.Esquerda);
            Console.Write(no.Valor + ", ");
            EmOrdem(no.Direita);
        }

        public static void PosOrdem(No no)
        {
            if (no == null) return;

            PosOrdem(no.Esquerda);
            PosOrdem(no.Direita);
            Console.Write(no.Valor + ", ");
        }
    }
}
