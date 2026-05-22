
using TrabalhoP12AED.estrutura;

namespace TrabalhoP12AED.implementacao;
    
    public class ArvoreDeBuscaBinaria
    {
        public No Raiz = null;

        public ArvoreDeBuscaBinaria()
        {
            Raiz = null;
        }

        public void Inserir(char valor)
        {
            Raiz = InserirRecursao(valor, Raiz);
        }

        public No Buscar(char valor)
        {
            return BuscarRec(valor, Raiz);
        }

        private static No InserirRecursao(char valor, No raiz)
        {
            if(raiz == null)
                return new No (valor);


            if (valor < raiz.Valor)
            {
                raiz.Esquerdo = InserirRecursao(valor, raiz.Esquerdo);
            }
            else if(valor > raiz.Valor)
            {
                raiz.Direito = InserirRecursao(valor, raiz.Direito);
            }

            return raiz;
        }

        public static No BuscarRec(char valor, No no)
        {
            if(no == null || valor == no.Valor)
            {
                return no;
            }
            else if(valor < no.Valor)
            {
                return BuscarRec(valor, no.Esquerdo);
            }
            else
            {
                return BuscarRec(valor, no.Direito);
            }

        }

        public void ExibirEmOrdem(No raiz)
        {
            if (raiz != null)
            {
                ExibirEmOrdem(raiz.Esquerdo);
                Console.Write(raiz.Valor + " ");
                ExibirEmOrdem(raiz.Direito);
            }
        }

    }