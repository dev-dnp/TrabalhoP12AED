namespace TrabalhoP12AED;

public class MediaGeometricaCrescimentoPIB
{
    private int NumeroDeAnos;
    private double[] Taxas;
    public double ValorMediaGeometrica;
    public double Produto = 1.0;


    public MediaGeometricaCrescimentoPIB(int numeroDeAnos, double[] taxas)
    {
        this.NumeroDeAnos = numeroDeAnos;
        this.Taxas = taxas;
    }

    public void Calcular()
    {

        for (int i = 0; i < this.NumeroDeAnos; i++)
        {
            Produto *= 1 + (this.Taxas[i]/100.0);
        }

        ValorMediaGeometrica = Math.Pow(Produto, 1.0 / NumeroDeAnos) - 1;
    }

    public void ExibirDadosDeEntrada()
    {
        for (int i = 0; i < this.NumeroDeAnos; i++)
        {
            double fator = 1 + this.Taxas[i] / 100.0;
            Console.WriteLine($"\t{i + 1,-6} {this.Taxas[i],-12:F2} {fator,-14:F6}");
        }
    }
}