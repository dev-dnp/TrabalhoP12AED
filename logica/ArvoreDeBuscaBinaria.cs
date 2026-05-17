
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