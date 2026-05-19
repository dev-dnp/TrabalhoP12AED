namespace TrabalhoP12AED.implementacao
{

    public class VectorLinha()
    {
        public static string LetrasDoAlfabeto(string caixa = "caixa-baixa")
        {
            const int QUANTIDADE = 16;
            
            char[] letras = new char[QUANTIDADE];

            if(caixa == "caixa-alta")
            {
                for (int i = 0; i < QUANTIDADE; i++)
                {
                    letras[i] = (char)('A' + i);
                }
            }
            else
            {
                for (int i = 0; i < QUANTIDADE; i++)
                {
                    letras[i] = (char)('a' + i);
                }
            }

            return string.Join(", ", letras);
        }
    }
}
