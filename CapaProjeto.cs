namespace TrabalhoP12AED;

public class CapaDoProjeto
{
    static public void Exibir()
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@"
                               UNIVERSIDADE TÉCNICA DE ANGOLA
                                   FACULDADE DE ENGENHARIA
             Departamento de Ensino e Investigação de Tecnologia de Informação - DEITIC

                          Disciplina: Algoritmo e Estrutura de Dados


                                      Integrantes do Grupo
        ");
        Console.ResetColor();


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"

                  ╔═════════════════════════════════════════════════════════════╗
                  ║ Nº | Nome                                 | Nº de Matrícula ║
                  ║----|--------------------------------------|-----------------║
                  ║ 1º | Domingos Nkula Pedro                 |      44613      ║
                  ╚═════════════════════════════════════════════════════════════╝
        ");
        Console.ResetColor();

        Console.WriteLine(@"
                                         Luanda/Angola
                                           Junho/2026
        ");


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Prima qualquer tecla para continuar e aceder o menu");
        Console.ResetColor();
        Console.ReadKey();

    
    }
}