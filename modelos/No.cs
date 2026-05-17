namespace TrabalhoP12AED.modelos
{

    public class No
    {
        public string Valor;
        public No Esquerda;
        public No Direita;

        public No(string valor)
        {
            this.Valor = valor;
        }
    }

}
