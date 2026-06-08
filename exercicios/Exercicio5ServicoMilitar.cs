using TrabalhoP12AED.implementacao;
using TrabalhoP12AED.estrutura;

namespace TrabalhoP12AED.exercicios
{
    public class Exercicio5ServicoMilitarObrigatorio
    {

        public List<Pessoa> Candidatos = new List<Pessoa>();
        public List<string> ErrosEncontrados = new List<string>();

        public static void Executar()
        {
            Console.Clear();
            
            int n;

            while (true)
            {
                Console.Write("\tInsira o número de candidatos a registar:");

                if (int.TryParse(Console.ReadLine(), out n) && n > 0)  break;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tErro: informe um número inteiro positivo.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }

            Pessoa[] candidatos = new Pessoa[n];

            for (int i = 0; i < n; i++)
            {
                Pessoa Candidato = new Pessoa();
                Console.Clear();

                // Inserir o nome do candidato
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i+1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();

                    Console.Write($"\tInforme o nome completo: ");
                    
                    string nomeInserido = Console.ReadLine().Trim();

                    if (!string.IsNullOrWhiteSpace(nomeInserido))
                    {
                        Candidato.Nome = nomeInserido;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErro: informe um nome válido.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }


                // Inserir o número do bilhete de identidade
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i+1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();

                    Console.Write($"\tInforme o número do bilhete de identidade: ");

                    string bilheteInserido = Console.ReadLine().Trim();

                    if (!string.IsNullOrWhiteSpace(bilheteInserido))
                    {
                        Candidato.BilheteIdentidade = bilheteInserido;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErro: informe um número válido no formato: 000000000AB000");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }

                // Inserir a data de nascimento
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i+1}");
                    Console.ResetColor();
                    
                    Utilitario.LinhaSeparadora();
                    

                    DateTime dataNascimentoCandidato;

                    Console.Write($"\tInforme a data de nascimento: ");

                    if (DateTime.TryParse(Console.ReadLine(), out dataNascimentoCandidato)) {
                        Candidato.DataNascimento = dataNascimentoCandidato;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErro: informe uma data válida no formato 01-04-2026");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }

                // Inserir o género

                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i+1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();


                    DateTime dataNascimentoCandidato;

                    Console.WriteLine("\t1 - Masculino");
                    Console.WriteLine("\t2 - Feminino");
                    Console.Write("\tInforme o género: ");

                    string opcao = Console.ReadLine().Trim();

                    if(opcao == "1")
                    {
                        Candidato.Sexo = ESexo.Masculino;
                        break;
                    } else if(opcao == "2")
                    {
                        Candidato.Sexo = ESexo.Feminino;
                        break;
                    } 
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\tErro: informe um genéro válido");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    } 
                
                }

                Saude saude = new Saude();

                // Altura
                while (true)
                {
                    Console.Clear();
                    Console.Write("\tInforme a altura (em metros): ");

                    if (double.TryParse(Console.ReadLine(), out double altura) && altura > 0)
                    {
                        saude.Altura = altura;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tErro: informe uma altura válida.");
                    Console.ResetColor();
                    Console.ReadKey();
                }

                saude.ResExameRastreioMedico = PerguntarSimNao("Passou no exame de rastreio médico");

                saude.ResExamesPsicotecnicos = PerguntarSimNao("Passou nos exames psicotécnicos");

                saude.ResProvaAptidaoFisica = PerguntarSimNao("Passou na prova de aptidão física");

                saude.TemAntecedentesGraves = PerguntarSimNao("Possui antecedentes graves");

                Candidato.Saude = saude;

                ResumoDados(Candidato);

                candidatos[i] = Candidato;
            }

            ExibirListaCandidatos(candidatos);

            Console.ReadKey();
            return;
        }

        public static bool PerguntarSimNao(string pergunta)
        {
            while (true)
            {
                Console.Write($"\t{pergunta} (S/N): ");

                string resposta = Console.ReadLine().Trim().ToLower();

                if (resposta == "s")
                    return true;

                if (resposta == "n")
                    return false;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tErro: responda apenas S ou N.");
                Console.ResetColor();
            }
        }

        public static void ResumoDados(Pessoa candidato)
        {
            Console.Clear();

            string data = candidato.DataNascimento.ToString("dd/MM/yyyy");

            int idade = DateTime.Now.Year - candidato.DataNascimento.Year;

            if (candidato.DataNascimento.Date >
                DateTime.Today.AddYears(-idade))
            {
                idade--;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tRESUMO DO CANDIDATO");
            Console.ResetColor();

            Utilitario.LinhaSeparadora();

            Console.WriteLine("\n\tDADOS PESSOAIS\n");

            Console.WriteLine($"\tNome..................: {candidato.Nome}");
            Console.WriteLine($"\tGénero................: {candidato.Sexo}");
            Console.WriteLine($"\tData de Nascimento....: {data}");
            Console.WriteLine($"\tIdade.................: {idade}");
            Console.WriteLine($"\tBilhete de Identidade.: {candidato.BilheteIdentidade}");

            Console.WriteLine("\n\tDADOS DE SAÚDE\n");

            Console.WriteLine($"\tAltura................: {candidato.Saude.Altura:F2} m");
            Console.WriteLine($"\tRastreio Médico.......: {(candidato.Saude.ResExameRastreioMedico ? "Apto" : "Não Apto")}");
            Console.WriteLine($"\tExames Psicotécnicos..: {(candidato.Saude.ResExamesPsicotecnicos ? "Apto" : "Não Apto")}");
            Console.WriteLine($"\tProva Física..........: {(candidato.Saude.ResProvaAptidaoFisica ? "Apto" : "Não Apto")}");
            Console.WriteLine($"\tAntecedentes Graves...: {(candidato.Saude.TemAntecedentesGraves ? "Sim" : "Não")}");

            Utilitario.LinhaSeparadora();

            Console.Write("\n\tPrima qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void ExibirListaCandidatos(Pessoa[] candidatos)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tLISTA DE CANDIDATOS");
            Console.ResetColor();

            Utilitario.LinhaSeparadora();

            for (int i = 0; i < candidatos.Length; i++)
            {
                Pessoa candidato = candidatos[i];
                
                AvaliarCandidato avaliacao = new AvaliarCandidato(candidato);

                Console.WriteLine($"\n\tCANDIDATO {i + 1}");

                Console.WriteLine($"\tNome                  : {avaliacao.Candidato.Nome}");
                Console.WriteLine($"\tGénero                : {avaliacao.Candidato.Sexo}");
                Console.WriteLine($"\tData de Nascimento    : {avaliacao.Candidato.DataNascimento:dd/MM/yyyy}");
                Console.WriteLine($"\tBilhete de Identidade : {avaliacao.Candidato.BilheteIdentidade}");

                Console.WriteLine();

                Console.WriteLine($"\tAltura                : {avaliacao.Candidato.Saude.Altura:F2} m");
                Console.WriteLine($"\tRastreio Médico       : {(avaliacao.Candidato.Saude.ResExameRastreioMedico ? "Apto" : "Não Apto")}");
                Console.WriteLine($"\tExames Psicotécnicos  : {(avaliacao.Candidato.Saude.ResExamesPsicotecnicos ? "Apto" : "Não Apto")}");
                Console.WriteLine($"\tProva Física          : {(avaliacao.Candidato.Saude.ResProvaAptidaoFisica ? "Apto" : "Não Apto")}");
                Console.WriteLine($"\tAntecedentes Graves   : {(avaliacao.Candidato.Saude.TemAntecedentesGraves ? "Sim" : "Não")}");

                bool apto = avaliacao.Resultado();
                var erros = avaliacao.Erros;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\tRESULTADO FINAL       : ");
                Console.ResetColor();

                if(apto)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"APROVADO");
                    Console.ResetColor();
                }  
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"REPROVADO");
                    Console.ResetColor();

                    Console.WriteLine($"\tMotivos: ");

                    Console.ForegroundColor = ConsoleColor.Red;

                    for(int indice = 0; indice < erros.Count; indice++)
                    {
                        Console.WriteLine($"\t  Erro {indice + 1}: {erros[indice]}");
                    }

                    Console.ResetColor();

                } 
                
                Utilitario.LinhaSeparadora();

                if((i+1)%5 == 0 && (i+1) != candidatos.Length &&  i != 0)
                {
                    Console.Write("\tPrima ENTER para continuar a ver a lista");
                    Console.ReadKey();
                }
            }

                Console.Write("\n\tPrima qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}