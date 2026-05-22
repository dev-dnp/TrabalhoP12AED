namespace TrabalhoP12AED.estrutura;

public class No
{
    public char Valor;
    public No Esquerdo;
    public No Direito;

    public No(char valor)
    {
        Valor = valor;
        Esquerdo = null;
        Direito = null;
    }
}
