
namespace TrabalhoP12AED.logica
{
    

    public class ArvoreDeBuscaBinaria
    {

        private class No
        {
            public char Valor;
            public No Esquerdo;
            public No Direito;

            public No(char valor)
            {
                Valor = valor;
            }

        }

        private No Raiz = null;


        public void Inserir(char valor)
        {
            Raiz = InserirRecursao(valor, Raiz);
        }

        public void Percorrer()
        {
            EmOrdem(Raiz);
        }

        private No InserirRecursao(char valor, No no)
        {
            if(no == null)
                return new No(valor);



            if (valor < no.Valor)
            {
                no.Esquerdo = InserirRecursao(valor, no.Esquerdo);
            }
            else if(valor > no.Valor)
            {
                no.Direito = InserirRecursao(valor, no.Direito);
            }


            return no;
        }

        private void PreOrdem(No no)
        {
            if (no == null) return;

            Console.Write(no.Valor + ", ");
            PreOrdem(no.Esquerdo);
            PreOrdem(no.Direito);
        }

        private void EmOrdem(No no)
        {
            if (no == null) return;

            EmOrdem(no.Esquerdo);
            Console.Write(no.Valor + ", ");
            EmOrdem(no.Direito);
        }

        private static void PosOrdem(No no)
        {
            if (no == null) return;

            PosOrdem(no.Esquerdo);
            PosOrdem(no.Direito);
            Console.Write(no.Valor + ", ");
        }

    }

}


/*
char valorDoNo = Convert.ToChar(no.Valor);

            if (valorAInserir > valorDoNo)
            {
                if (no.Direita == null)
                {
                    no.Direita = new No(Convert.ToString(valorAInserir));
                    return;
                }

                Inserir(no.Direita, valorAInserir);
            }
            else if (valorAInserir < valorDoNo)
            {
                if (no.Esquerda == null)
                {
                    no.Esquerda = new No(Convert.ToString(valorAInserir));
                    return;
                }

                Inserir(no.Esquerda, valorAInserir);
            }

*/