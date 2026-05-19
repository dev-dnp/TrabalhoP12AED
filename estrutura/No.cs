namespace TrabalhoP12AED.estrutura;

public class No<T>
{
    public T Valor;
    public No<T> Esquerdo;
    public No<T> Direito;

    public No(T valor)
    {
        Valor = valor;
        Esquerdo = null;
        Direito = null;
    }
}
