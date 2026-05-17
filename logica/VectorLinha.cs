namespace TrabalhoP12AED.logica
{

    public class VectorLinha()
    {

        public static void LetrasDoAlfabeto(byte quantidade)
        {
            char[] letras = new char[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                letras[i] = (char)('a' + i);
                Console.Write(letras[i] + ", ");
            }
        }
    }
}
