
using TrabalhoP12AED.estrutura;

namespace TrabalhoP12AED.implementacao
{
    public enum ESexo {
        Masculino = 1, 
        Feminino
    };

    public class Saude
    {
        public double Altura { get; set; } 
        public bool ResExameRastreioMedico { get; set; }
        public bool ResExamesPsicotecnicos { get; set; }
        public bool ResProvaAptidaoFisica {get; set;}
        public bool TemAntecedentesGraves {get; set;}
    }

    public class Pessoa
    {
        public string Nome {get; set;}
        public ESexo Sexo {get; set;}
        public DateTime DataNascimento {get; set;}
        public Saude Saude {get; set;}
        public string BilheteIdentidade {get; set;}
    }

    public class AvaliarCandidato
    {
        public Pessoa Candidato { get; set; }
        public List<string> Erros { get; set; } = new List<string>();
        public bool Apto { get; set; }

        public byte IdadeMinimaGeral = 20;
        public byte IdadeMaximaGeral = 45;
        public double AlturaMinimaMasculino = 1.70;
        public double AlturaMinimaFeminino = 1.65;

        public AvaliarCandidato(Pessoa candidato)
        {
            Candidato = candidato;

            int idade = DateTime.Now.Year - Candidato.DataNascimento.Year;
            
            if(idade < IdadeMinimaGeral || idade > IdadeMaximaGeral)
            {
                Erros.Add($"O candidato tem {idade} anos de idade. A idade mínima é {IdadeMinimaGeral} e a idade máxima é {IdadeMaximaGeral}");
            }

            if(Candidato.Sexo == ESexo.Masculino && Candidato.Saude.Altura < AlturaMinimaMasculino)
            {
                Erros.Add($"O candidato tem {Candidato.Saude.Altura} m de altura, mas o mínimo aceitável para o sexo masculino é {AlturaMinimaMasculino} m");
            }
            
            if(Candidato.Sexo == ESexo.Feminino && Candidato.Saude.Altura < AlturaMinimaFeminino)
            {
                Erros.Add($"O candidato tem {Candidato.Saude.Altura} m de altura, mas o mínimo aceitável para o sexo feminino é {AlturaMinimaFeminino} m");
            }

            if (!Candidato.Saude.ResExameRastreioMedico)
            {
                Erros.Add("Não foi aprovada no exame de rastreio médico.");
            }

            if (!Candidato.Saude.ResExamesPsicotecnicos)
            {
                Erros.Add("Não foi aprovada nos exames psicotécnicos.");
            }

            if (!Candidato.Saude.ResProvaAptidaoFisica)
            {
                Erros.Add("Não foi aprovada na prova de aptidão física.");
            }

            if (Candidato.Saude.TemAntecedentesGraves)
            {
                Erros.Add("Possui antecedentes graves incompatíveis com o serviço.");
            }

            if(Erros.Count > 0)
            {
                Apto = false;
            } 
            else
            {
                Apto = true;
            }
        }

        public bool Resultado()
        {
            return Apto;
        }
    }

}
