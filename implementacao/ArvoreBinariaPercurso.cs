using TrabalhoP12AED.estrutura;

namespace TrabalhoP12AED.implementacao
{

    public class ArvoreBinariaPercurso
    {
        public static List<string> ListaAcumulativa = new List<string>();

        // Percorrer uma árvore: PRE-ORDEM

        public static void PreOrdem(No<string> no)
        {
            if (no == null) return;

            ListaAcumulativa.Add(no.Valor);
            PreOrdem(no.Esquerdo);
            PreOrdem(no.Direito);
        }

        // Percorrer uma árvore: ORDEM-ORDEM

        public static void EmOrdem(No<string> no)
        {
            if (no == null) return;

            EmOrdem(no.Esquerdo);
            ListaAcumulativa.Add(no.Valor);
            EmOrdem(no.Direito);
        }

        // Percorrer uma árvore: POS-ORDEM

        public static void PosOrdem(No<string> no)
        {
            if (no == null) return;

            PosOrdem(no.Esquerdo);
            PosOrdem(no.Direito);
            ListaAcumulativa.Add(no.Valor);
        }


        public static string ExibirPercurso()
        {

            var resultado = new List<string>(ListaAcumulativa);

            ListaAcumulativa.Clear();

            return string.Join(", ", resultado);
        }
    }
}
