using TrabalhoP12AED.implementacao;
using TrabalhoP12AED.estrutura;

namespace TrabalhoP12AED.exercicios
{
    public class Exercicio5ServicoMilitarObrigatorio
    {
        // Corrigido: instância em vez de estático, para evitar estado partilhado entre execuções
        private int _nrAprovados = 0;
        private int _nrReprovados = 0;

        public List<Pessoa> Candidatos = new List<Pessoa>();
        public List<string> ErrosEncontrados = new List<string>();

        public static void Executar()
        {
            while(true)
            {
                Console.Clear();
                ExibirCabecalho();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\tESCOLHA UMA OPÇÃO:\n");
                Console.ResetColor();

                Console.WriteLine("\t 1 - Registar");
                Console.WriteLine("\t 0 - Sair");
                
                Console.Write("\n\n\tEscolha uma opção: ");

                string opcao = Console.ReadLine().Trim();

                switch(opcao)
                {
                    case "1":
                        InsercaoServicoMilitar();
                        break;
                    case "0":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n\tOpção inválida!");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void InsercaoServicoMilitar()
        {
            Console.Clear();

            int n;

            while (true)
            {
                ExibirCabecalho();
                Console.Write("\tInsira o número de candidatos a registar: ");

                string entrada = Console.ReadLine()?.Trim() ?? string.Empty;

                if (int.TryParse(entrada, out n) && n > 0) break;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tErro: informe um número inteiro positivo.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }

            Pessoa[] candidatos = new Pessoa[n];

            for (int i = 0; i < n; i++)
            {
                Pessoa candidato = new Pessoa();
                Console.Clear();

                // Nome
                while (true)
                {
                    ExibirCabecalho();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i + 1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();

                    Console.Write("\tInforme o nome completo: ");

                    string nomeInserido = Console.ReadLine()?.Trim() ?? string.Empty;

                    if (!string.IsNullOrWhiteSpace(nomeInserido))
                    {
                        candidato.Nome = nomeInserido;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErro: informe um nome válido.");
                    Console.ResetColor();
                    Console.ReadKey();
                }

                // Bilhete de Identidade
                while (true)
                {
                    ExibirCabecalho();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i + 1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();

                    Console.Write("\tInforme o número do bilhete de identidade: ");

                    string bilheteInserido = Console.ReadLine()?.Trim() ?? string.Empty;

                    if (!string.IsNullOrWhiteSpace(bilheteInserido))
                    {
                        candidato.BilheteIdentidade = bilheteInserido;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErro: informe um número válido no formato: 000000000AB000");
                    Console.ResetColor();
                    Console.ReadKey();
                }

                // Data de Nascimento
                while (true)
                {
                    ExibirCabecalho();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i + 1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();

                    Console.Write("\tInforme a data de nascimento (ex: 01-04-2006): ");

                    string entradaData = Console.ReadLine()?.Trim() ?? string.Empty;

                    if (DateTime.TryParse(entradaData, out DateTime dataNascimento))
                    {
                        candidato.DataNascimento = dataNascimento;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErro: informe uma data válida no formato 01-04-2006.");
                    Console.ResetColor();
                    Console.ReadKey();
                }

                // Género — removida variável DateTime declarada por engano aqui
                while (true)
                {
                    ExibirCabecalho();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i + 1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();

                    Console.WriteLine("\t1 - Masculino");
                    Console.WriteLine("\t2 - Feminino");
                    Console.Write("\tInforme o género: ");

                    string opcao = Console.ReadLine()?.Trim() ?? string.Empty;

                    if (opcao == "1")
                    {
                        candidato.Sexo = ESexo.Masculino;
                        break;
                    }
                    else if (opcao == "2")
                    {
                        candidato.Sexo = ESexo.Feminino;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\tErro: informe um género válido (1 ou 2).");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }

                // Saúde
                Saude saude = new Saude();

                while (true)
                {
                    ExibirCabecalho();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tCANDIDATO {i + 1}");
                    Console.ResetColor();

                    Utilitario.LinhaSeparadora();

                    Console.Write("\tInforme a altura (em metros, ex: 1.75): ");

                    string entradaAltura = Console.ReadLine()?.Trim() ?? string.Empty;

                    if (double.TryParse(entradaAltura, out double altura) && altura > 0)
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
                saude.ResExamesPsicotecnicos  = PerguntarSimNao("Passou nos exames psicotécnicos");
                saude.ResProvaAptidaoFisica   = PerguntarSimNao("Passou na prova de aptidão física");
                saude.TemAntecedentesGraves   = PerguntarSimNao("Possui antecedentes graves");

                candidato.Saude = saude;

                ResumoDados(candidato);

                candidatos[i] = candidato;
            }

            ExibirListaCandidatos(candidatos);

        }

        public static bool PerguntarSimNao(string pergunta)
        {
            while (true)
            {
                ExibirCabecalho();
                Console.Write($"\t{pergunta} (S/N): ");

                string resposta = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                if (resposta == "s") return true;
                if (resposta == "n") return false;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tErro: responda apenas S ou N.");
                Console.ResetColor();
                Console.Read();
            }
        }

        public static void ResumoDados(Pessoa candidato)
        {
            Console.Clear();

            string data = candidato.DataNascimento.ToString("dd/MM/yyyy");

            int idade = DateTime.Now.Year - candidato.DataNascimento.Year;
            if (candidato.DataNascimento.Date > DateTime.Today.AddYears(-idade))
                idade--;

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
            // Contadores locais, calculados ANTES de exibir o título
            int nrAprovados  = 0;
            int nrReprovados = 0;

            // Pré-calcular resultados para mostrar totais correctos no cabeçalho
            var avaliacoes = new (AvaliarCandidato avaliacao, bool apto, List<string> erros)[candidatos.Length];

            for (int i = 0; i < candidatos.Length; i++)
            {
                var avaliacao = new AvaliarCandidato(candidatos[i]);
                bool apto     = avaliacao.Resultado();
                var erros     = avaliacao.Erros;

                avaliacoes[i] = (avaliacao, apto, erros);

                if (apto) nrAprovados++;
                else      nrReprovados++;
            }

            ExibirTituloResumoDosDados();

            Console.WriteLine($"\tTotais aprovados : {nrAprovados}");
            Console.WriteLine($"\tTotais reprovados: {nrReprovados}");

            for (int i = 0; i < avaliacoes.Length; i++)
            {
                var (avaliacao, apto, erros) = avaliacoes[i];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\tCANDIDATO {i + 1}\n");
                Console.ResetColor();

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

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\tRESULTADO FINAL       : ");
                Console.ResetColor();

                if (apto)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("APROVADO");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("REPROVADO");
                    Console.ResetColor();

                    Console.WriteLine("\tMotivos:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int j = 0; j < erros.Count; j++)
                        Console.WriteLine($"\t  Erro {j + 1}: {erros[j]}");
                    Console.ResetColor();
                }

                Utilitario.LinhaSeparadora();

                // Pausa a cada 5 candidatos, excepto após o último
                bool ehMultiploDe5 = (i + 1) % 5 == 0;
                bool naoEOUltimo   = (i + 1) < candidatos.Length;

                if (ehMultiploDe5 && naoEOUltimo)
                {
                    Console.Write("\tPrima ENTER para continuar a ver a lista...");
                    Console.ReadLine();
                }
            }

            Console.Write("\n\tPrima qualquer tecla para sair...");
            Console.ReadKey();
        }

        private static void ExibirTituloResumoDosDados()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                RESUMO FINAL                               ║");
            Console.WriteLine("\t╚═══════════════════════════════════════════════════════════════════════════╝");
            Utilitario.LinhaSeparadora();
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void ExibirCabecalho()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║              SERVIÇO MILITAR OBRIGATÓRIO               ║");
            Console.WriteLine("\t╚════════════════════════════════════════════════════════╝");
            
            Utilitario.LinhaSeparadora();

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}