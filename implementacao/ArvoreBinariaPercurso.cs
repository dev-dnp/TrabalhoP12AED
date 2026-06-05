using System.Collections.Generic;
using TrabalhoP12AED.estrutura;
namespace TrabalhoP12AED.implementacao
{
    public class ArvoreBinariaPercurso
    {
        public No Raiz { get; private set; }
        public static List<char> ListaAcumulativa = new List<char>();

        public ArvoreBinariaPercurso()
        {
            Raiz = new No('a');
            // Nivel 1
            Raiz.Esquerdo = new No('b');
            Raiz.Direito = new No('c');
            // Nivel 2
            Raiz.Esquerdo.Esquerdo = new No('d');
            Raiz.Esquerdo.Direito = new No('e');
            Raiz.Direito.Direito = new No('f');
            // Nivel 3
            Raiz.Direito.Direito.Esquerdo = new No('g');
        }

        public static void PreOrdem(No no)
        {
            if (no == null) return;

            ListaAcumulativa.Add(no.Valor); // Raiz
            PreOrdem(no.Esquerdo);          // Esquerdo
            PreOrdem(no.Direito);           // Direito
        }

        public static void EmOrdem(No no)
        {
            if (no == null) return;

            EmOrdem(no.Esquerdo);           // Esquerdo
            ListaAcumulativa.Add(no.Valor); // Raiz
            EmOrdem(no.Direito);            // Direito
        }

        public static void PosOrdem(No no)
        {
            if (no == null) return;

            PosOrdem(no.Esquerdo);          // Esquerdo
            PosOrdem(no.Direito);           // Direito
            ListaAcumulativa.Add(no.Valor); // Raiz
        }

        // Retorna o resultado acumulado e limpa a lista para o próximo percurso
        public static string ExibirPercurso()
        {
            var resultado = new List<char>(ListaAcumulativa);
            ListaAcumulativa.Clear();
            return string.Join(", ", resultado);
        }
    }
}