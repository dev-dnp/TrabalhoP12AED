
// using TrabalhoP12AED.estrutura;

// namespace TrabalhoP12AED.implementacao;

// public enum ESexo {
//     Masculino = 1, 
//     Feminino
// };

// public class Saude
// {
//     public double Altura { get; set; } 
//     public bool ResExameRastreioMedico { get; set; }
//     public bool ResExamesPsicotecnicos { get; set; }
//     public bool ResProvaAptidaoFisica {get; set;}
//     public bool TemAntecedentesGraves {get; set;}
// }


// public class Pessoa
// {
//     public string Nome {get; set;}
//     public ESexo Sexo {get; set;}
//     public DateTime DataNascimento {get; set;}
//     public Saude Saude {get; set;}
//     public string BilheteIdentidade {get; set;}
// }

// public class ResultadoAvaliacao
// {
//     public Pessoa Candidato { get; set; }
//     public List<string> Erros { get; set; } = new List<string>();
//     public bool Apto { get; set; }
// }

// public class ServicoMilitarObrigatorio
// {
//     public byte IdadeMinimaGeral = 20;
//     public byte IdadeMaximaGeral = 45;
//     public double AlturaMinimaMasculino = 1.70;
//     public double AlturaMinimaFeminino = 1.65;

//     public List<Pessoa> Candidatos = new List<Pessoa>();
//     public List<string> ErrosEncontrados = new List<string>();

//     public static void Avaliar()
//     {

//         Console.Clear();
        
//         int n;

//         while (true)
//         {

//             Console.Write("\tInsira o número de candidatos a registar:");

//             if (int.TryParse(Console.ReadLine(), out n) && n > 0)  break;

//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.Write("\tErro: informe um número inteiro positivo.");
//             Console.ResetColor();
//             Console.ReadKey();
//             Console.Clear();
//         }

//         List<Pessoa> candidatos = new List<Pessoa>();

//         for (int i = 0; i < n; i++)
//         {
//             Pessoa Candidato = new Pessoa();
//             Console.Clear();
            

//             // Inserir o nome do candidato
//             while (true)
//             {
//                 Console.Clear();
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.WriteLine($"\tCANDIDATO {i+1}");
//                 Console.ResetColor();

//                 Utilitario.LinhaSeparadora();

//                 Console.Write($"\tInforme o nome completo: ");
                
//                 string nomeInserido = Console.ReadLine().Trim();

//                 if (!string.IsNullOrWhiteSpace(nomeInserido))
//                 {
//                     Candidato.Nome = nomeInserido;
//                     break;
//                 }

//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.Write("\tErro: informe um nome válido.");
//                 Console.ResetColor();
//                 Console.ReadKey();
//                 Console.Clear();
//             }


//             // Inserir o número do bilhete de identidade
//             while (true)
//             {
//                 Console.Clear();
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.WriteLine($"\tCANDIDATO {i+1}");
//                 Console.ResetColor();

//                 Console.WriteLine($"\tNome: {Candidato.Nome}");
//                 Utilitario.LinhaSeparadora();

//                 Console.Write($"\tInforme o número do bilhete de identidade: ");

//                 string bilheteInserido = Console.ReadLine().Trim();

//                 if (!string.IsNullOrWhiteSpace(bilheteInserido))
//                 {
//                     Candidato.BilheteIdentidade = bilheteInserido;
//                     break;
//                 }

//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.Write("\tErro: informe um número válido no formato: 000000000AB000");
//                 Console.ResetColor();
//                 Console.ReadKey();
//                 Console.Clear();
//             }

//             // Inserir a data de nascimento
//             while (true)
//             {
//                 Console.Clear();
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.WriteLine($"\tCANDIDATO {i+1}");
//                 Console.ResetColor();
                
//                 Console.WriteLine($"\tNome                           : {Candidato.Nome}");
//                 Console.WriteLine($"\tNúmero do bilhete de identidade: {Candidato.BilheteIdentidade}");
//                 Utilitario.LinhaSeparadora();
                

//                 DateTime dataNascimentoCandidato;

//                 Console.Write($"\tInforme a data de nascimento: ");

//                 if (DateTime.TryParse(Console.ReadLine(), out dataNascimentoCandidato)) {
//                     Candidato.DataNascimento = dataNascimentoCandidato;
//                     break;
//                 }

//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.Write("\tErro: informe uma data válida no formato 01-04-2026");
//                 Console.ResetColor();
//                 Console.ReadKey();
//                 Console.Clear();
//             }

//             // Inserir o género

//             while (true)
//             {
//                 Console.Clear();
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.WriteLine($"\tCANDIDATO {i+1}");
//                 Console.ResetColor();
                
//                 Console.WriteLine($"\tNome                           : {Candidato.Nome}");
//                 Console.WriteLine($"\tData de Nascimento             : {Candidato.DataNascimento}");
//                 Console.WriteLine($"\tNúmero do bilhete de identidade: {Candidato.BilheteIdentidade}");
//                 Utilitario.LinhaSeparadora();


//                 DateTime dataNascimentoCandidato;

//                 Console.WriteLine("\t1 - Masculino");
//                 Console.WriteLine("\t2 - Feminino");
//                 Console.Write("\tInforme o género: ");

//                 string opcao = Console.ReadLine().Trim();

//                 if(opcao == "1")
//                 {
//                     Candidato.Sexo = ESexo.Masculino;
//                     break;
//                 } else if(opcao == "2")
//                 {
//                     Candidato.Sexo = ESexo.Feminino;
//                     break;
//                 } 
//                 else
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.Write("\tErro: informe um genéro válido");
//                     Console.ResetColor();
//                     Console.ReadKey();
//                     Console.Clear();
//                 } 
            
//             }

//             Saude saude = new Saude();

//             // Altura
//             while (true)
//             {
//                 Console.Clear();
//                 Console.Write("\tInforme a altura (em metros): ");

//                 if (double.TryParse(Console.ReadLine(), out double altura) && altura > 0)
//                 {
//                     saude.Altura = altura;
//                     break;
//                 }

//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("\tErro: informe uma altura válida.");
//                 Console.ResetColor();
//                 Console.ReadKey();
//             }

//             saude.ResExameRastreioMedico = PerguntarSimNao("Passou no exame de rastreio médico");

//             saude.ResExamesPsicotecnicos = PerguntarSimNao("Passou nos exames psicotécnicos");

//             saude.ResProvaAptidaoFisica = PerguntarSimNao("Passou na prova de aptidão física");

//             saude.TemAntecedentesGraves = PerguntarSimNao("Possui antecedentes graves");

//             Candidato.Saude = saude;

//             ResumoDados(Candidato);

//             candidatos.Add(Candidato);

//         }

//         ExibirListaCandidatos(candidatos);


//         Console.ReadKey();
//         return;

//     }

//     public void AvaliarQualificacao(Pessoa pessoa)
//     {
//         int idade = DateTime.Now.Year - pessoa.DataNascimento.Year;
        
//         if(idade < IdadeMinimaGeral || idade > IdadeMaximaGeral)
//         {
//             pessoa.Add($"O candidato tem {idade} anos de idade. A idade mínima é {IdadeMinimaGeral} e a idade máxima é {IdadeMaximaGeral}");
//         }

//         if(pessoa.Sexo == ESexo.Masculino && pessoa.Saude.Altura < AlturaMinimaMasculino)
//         {
//             pessoa.Add($"O candidato tem {pessoa.Saude.Altura} m de altura, mas o mínimo aceitável para o sexo masculino é {AlturaMinimaMasculino} m");
//         }
// p.Add($"O candid
//         if(pessoa.Sexo == ESexo.Feminino && pessoa.Saude.Altura < AlturaMinimaFeminino)
//         {
//             pessoa.Add($"O candidato tem {pessoa.Saude.Altura} m de altura, mas o mínimo aceitável para o sexo feminino é {AlturaMinimaFeminino} m");
//         }

//         if (!pessoa.Saude.ResExameRastreioMedico)
//         {
//             pessoa.Add("Não foi aprovada no exame de rastreio médico.");
//         }

//         if (!pessoa.Saude.ResExamesPsicotecnicos)
//         {
//             pessoa.Add("Não foi aprovada nos exames psicotécnicos.");
//         }

//         if (!pessoa.Saude.ResProvaAptidaoFisica)
//         {
//             pessoa.Add("Não foi aprovada na prova de aptidão física.");
//         }

//         if (pessoa.Saude.TemAntecedentesGraves)
//         {
//             pessoa.Add("Possui antecedentes graves incompatíveis com o serviço.");
//         }
//     }

//     public static bool PerguntarSimNao(string pergunta)
//     {
//         while (true)
//         {
//             Console.Write($"\t{pergunta} (S/N): ");

//             string resposta = Console.ReadLine().Trim().ToLower();

//             if (resposta == "s")
//                 return true;

//             if (resposta == "n")
//                 return false;

//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("\tErro: responda apenas S ou N.");
//             Console.ResetColor();
//         }
//     }

//     public static void ResumoDados(Pessoa candidato)
//     {
//         Console.Clear();

//         string data = candidato.DataNascimento.ToString("dd/MM/yyyy");

//         int idade = DateTime.Now.Year - candidato.DataNascimento.Year;

//         if (candidato.DataNascimento.Date >
//             DateTime.Today.AddYears(-idade))
//         {
//             idade--;
//         }

//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.WriteLine("\tRESUMO DO CANDIDATO");
//         Console.ResetColor();

//         Utilitario.LinhaSeparadora();

//         Console.WriteLine("\n\tDADOS PESSOAIS\n");

//         Console.WriteLine($"\tNome..................: {candidato.Nome}");
//         Console.WriteLine($"\tGénero................: {candidato.Sexo}");
//         Console.WriteLine($"\tData de Nascimento....: {data}");
//         Console.WriteLine($"\tIdade.................: {idade}");
//         Console.WriteLine($"\tBilhete de Identidade.: {candidato.BilheteIdentidade}");

//         Console.WriteLine("\n\tDADOS DE SAÚDE\n");

//         Console.WriteLine($"\tAltura................: {candidato.Saude.Altura:F2} m");
//         Console.WriteLine($"\tRastreio Médico.......: {(candidato.Saude.ResExameRastreioMedico ? "Apto" : "Não Apto")}");
//         Console.WriteLine($"\tExames Psicotécnicos..: {(candidato.Saude.ResExamesPsicotecnicos ? "Apto" : "Não Apto")}");
//         Console.WriteLine($"\tProva Física..........: {(candidato.Saude.ResProvaAptidaoFisica ? "Apto" : "Não Apto")}");
//         Console.WriteLine($"\tAntecedentes Graves...: {(candidato.Saude.TemAntecedentesGraves ? "Sim" : "Não")}");

//         Utilitario.LinhaSeparadora();

//         Console.Write("\n\tPrima qualquer tecla para continuar...");
//         Console.ReadKey();
//     }

//     public static void ExibirListaCandidatos(List<Pessoa> candidatos)
//     {
//         Console.Clear();

//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.WriteLine("\tLISTA DE CANDIDATOS");
//         Console.ResetColor();

//         Utilitario.LinhaSeparadora();

//         for (int i = 0; i < candidatos.Count; i++)
//         {
//                 Pessoa candidato = candidatos[i];

//                 Console.WriteLine($"\n\tCANDIDATO {i + 1}");

//                 Console.WriteLine($"\tNome..................: {candidato.Nome}");
//                 Console.WriteLine($"\tGénero................: {candidato.Sexo}");
//                 Console.WriteLine($"\tData de Nascimento....: {candidato.DataNascimento:dd/MM/yyyy}");
//                 Console.WriteLine($"\tBilhete de Identidade.: {candidato.BilheteIdentidade}");

//                 Console.WriteLine();

//                 Console.WriteLine($"\tAltura................: {candidato.Saude.Altura:F2} m");
//                 Console.WriteLine($"\tRastreio Médico.......: {(candidato.Saude.ResExameRastreioMedico ? "Apto" : "Não Apto")}");
//                 Console.WriteLine($"\tExames Psicotécnicos..: {(candidato.Saude.ResExamesPsicotecnicos ? "Apto" : "Não Apto")}");
//                 Console.WriteLine($"\tProva Física..........: {(candidato.Saude.ResProvaAptidaoFisica ? "Apto" : "Não Apto")}");
//                 Console.WriteLine($"\tAntecedentes Graves...: {(candidato.Saude.TemAntecedentesGraves ? "Sim" : "Não")}");

//                 bool apto =
//                     candidato.Saude.ResExameRastreioMedico &&
//                     candidato.Saude.ResExamesPsicotecnicos &&
//                     candidato.Saude.ResProvaAptidaoFisica &&
//                     !candidato.Saude.TemAntecedentesGraves;

//                 Console.WriteLine();
//                 Console.WriteLine($"\tSituação..............: {(apto ? "APTO" : "INAPTO")}");

//                 Utilitario.LinhaSeparadora();
//         }

//             Console.Write("\n\tPrima qualquer tecla para sair...");
//         Console.ReadKey();
//     }
// }

