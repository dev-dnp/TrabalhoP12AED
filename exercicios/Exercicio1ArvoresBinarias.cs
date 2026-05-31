using TrabalhoP12AED.estrutura;
using TrabalhoP12AED.implementacao;

namespace TrabalhoP12AED.exercicios
{

    public class Exercicio1ArvoresBinarias
    {
        public static void Executar()
        {
            while(true)
            {
                Console.Clear();

                // Nivel 0
                var raiz = new No('a');

                // Nivel 1

                raiz.Esquerdo = new No('b');
                raiz.Direito = new No('c');

                // Nivel 2
                raiz.Esquerdo.Esquerdo = new No('d');
                raiz.Esquerdo.Direito = new No('e');

                raiz.Direito.Direito = new No('f');

                // Nivel 3
                raiz.Direito.Direito.Esquerdo = new No('g');
                

                ExibirCabecalho();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\tESCOLHA UMA OPÇÃO:\n");
                Console.ResetColor();

                Console.WriteLine("\t 1 - Percurso Pré-ordem");
                Console.WriteLine("\t 2 - Percurso Em-ordem");
                Console.WriteLine("\t 3 - Percurso Pós-ordem");
                Console.WriteLine("\t 4 - Mostrar todos os Percursos");
                Console.WriteLine("\t 5 - Ajuda");
                Console.WriteLine("\t 0 - Sair");
                
                Console.Write("\n\n\tEscolha uma opção: ");

                string opcao = Console.ReadLine().Trim();

                switch(opcao)
                {
                    case "1":
                        ExibirPreOrdem(raiz);
                        break;
                    case "2":
                        ExibirEmOrdem(raiz);
                        break;
                    case "3":
                        ExibirPosOrdem(raiz);
                        break;
                    case "4":
                        ExibirTodosPercusos(raiz);
                        break;
                    case "5":
                        ExibirMenuDeAjuda();
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

        private static void ExibirPreOrdem(No raiz)
        {
            Console.Clear();
            ExibirCabecalho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tEste é o percurso PRÉ-ORDEM da Árvore Binária exibida: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PreOrdem(raiz);
            Console.WriteLine("\n\t" + ArvoreBinariaPercurso.ExibirPercurso());

            Utilitario.LinhaSeparadora();
            Utilitario.MensagemParaVoltar();  
        }

        private static void ExibirEmOrdem(No raiz)
        {
            Console.Clear();
            ExibirCabecalho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tEste é o percurso EM-ORDEM da Árvore Binária exibida: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.EmOrdem(raiz);
            Console.WriteLine("\n\t" + ArvoreBinariaPercurso.ExibirPercurso());

            Utilitario.LinhaSeparadora();
            Utilitario.MensagemParaVoltar(); 
        }

        private static void ExibirPosOrdem(No raiz)
        {
            Console.Clear();
            ExibirCabecalho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tEste é o percurso POS-ORDEM da Árvore Binária exibida: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PosOrdem(raiz);
            Console.WriteLine("\n\t" + ArvoreBinariaPercurso.ExibirPercurso());

            Utilitario.LinhaSeparadora();
            Utilitario.MensagemParaVoltar();
        }

        private static void ExibirTodosPercusos(No raiz)
        {
            Console.Clear();
            ExibirCabecalho();
            
            // EXIBIR EM PRE-ORDEM

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tPRÉ-ORDEM: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PreOrdem(raiz);
            Console.WriteLine("\t" + ArvoreBinariaPercurso.ExibirPercurso());
            Console.WriteLine("\n");


            // EXIBIR EM EM-ORDEM

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tEM-ORDEM: ");
            Console.ResetColor();


            ArvoreBinariaPercurso.EmOrdem(raiz);
            Console.WriteLine("\t" + ArvoreBinariaPercurso.ExibirPercurso());
            Console.WriteLine("\n");


            // EXIBIR EM POS-ORDEM

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tPOS-ORDEM: ");
            Console.ResetColor();

            ArvoreBinariaPercurso.PosOrdem(raiz);
            Console.WriteLine("\t" + ArvoreBinariaPercurso.ExibirPercurso());
            Console.WriteLine("\n");

            Utilitario.LinhaSeparadora();
            Utilitario.MensagemParaVoltar();
        }


        

        private static void ExibirCabecalho()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t╔═════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                       ÁRVORE BINÁRIA                    ║");
            Console.WriteLine("\t╚═════════════════════════════════════════════════════════╝");

            Console.WriteLine(@"
                                    a
                                  /   \
                                 b     c
                                / \     \
                               d   e     f
                                        /
                                       g
            ");
            
            Utilitario.LinhaSeparadora();
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void ExibirMenuDeAjuda2()
        {
            Console.Clear();

            Console.WriteLine(@"
                                    a
                                  /   \
                                 b     c
                                / \     \
                               d   e     f
                                        /
                                       g
            ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tINFORMAÇÕES DE AJUDA:\n");
            Console.ResetColor();

            Console.WriteLine("\tUma árvore binária é uma estrutura usada na programação ");
            Console.WriteLine("\tpara  organizar dados. Ela funciona como uma árvore, onde ");
            Console.WriteLine("\tcada elemento, chamado de nó, pode ter até dois filhos: um ");
            Console.WriteLine("\tà esquerda e outro à direita. O primeiro nó é chamado de raiz. \n");

            Console.WriteLine("\tEsses percursos servem para acessar os dados da árvore em diferentes ordens: \n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\tPré-ordem: ");
            Console.ResetColor();

            Console.Write("visita primeiro a raiz, depois a esquerda e por último a direita. \n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\tEm ordem: ");
            Console.ResetColor();

            Console.Write("visita esquerda, raiz e direita. \n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\tPós-ordem: ");
            Console.ResetColor();
            Console.Write("visita esquerda, direita e depois a raiz. \n");

            Utilitario.MensagemParaVoltar();
            
        }

        private static void ExibirMenuDeAjuda()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
            ╔═════════════════════════════════════════════════════════╗
            ║                 AJUDA - ÁRVORES BINÁRIAS                ║
            ╚═════════════════════════════════════════════════════════╝
            ");
            Console.ResetColor();


            Console.WriteLine(@"
            Uma árvore binária é uma estrutura de dados formada por
            nós ligados entre si.

            Cada nó pode possuir:

            • Um valor
            • Um filho à esquerda
            • Um filho à direita

            ──────────────────────────────────────────────────────────

            ESTRUTURA BÁSICA
            
            ");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                       10
                      /  \
                     5    20
                    / \   / \
                   2   7 15  30
            ");
            Console.ResetColor();

            Console.WriteLine(@"
            • 10 -> raiz
            • 5  -> filho esquerdo de 10
            • 20 -> filho direito de 10

            ──────────────────────────────────────────────────────────

            CONCEITOS IMPORTANTES

            • Raiz:
            Primeiro nó da árvore.

            • Nó:
            Elemento que armazena um valor.

            • Folha:
            Nó que não possui filhos.

            • Subárvore:
            Parte da árvore ligada a um nó.

            • Altura:
            Quantidade de níveis da árvore.

            ──────────────────────────────────────────────────────────

            ÁRVORE BINÁRIA DE BUSCA (BST)

            Em uma BST:

            • Valores menores ficam à esquerda
            • Valores maiores ficam à direita

            Exemplo:
            ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                          50
                         /  \
                       30    70
                      / \    / \
                    20  40  60  80
            ");
            Console.ResetColor();


            Console.WriteLine(@"
            ──────────────────────────────────────────────────────────

            PERCURSOS NA ÁRVORE

            1) PRÉ-ORDEM
            Raiz -> Esquerda -> Direita

            2) EM ORDEM
            Esquerda -> Raiz -> Direita

            3) PÓS-ORDEM
            Esquerda -> Direita -> Raiz

            ──────────────────────────────────────────────────────────

            EXEMPLO DE PERCURSOS

            Árvore:

            ");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                        10
                       /  \
                      5    20
            ");
            Console.ResetColor();

            Console.WriteLine(@"
            Pré-Ordem:
            10 5 20

            Em Ordem:
            5 10 20

            Pós-Ordem:
            5 20 10

            ──────────────────────────────────────────────────────────

            VANTAGENS

            • Busca eficiente
            • Organização hierárquica
            • Inserção rápida

            ──────────────────────────────────────────────────────────

            DESVANTAGENS

            • Pode ficar desbalanceada
            • Em alguns casos a busca pode ficar lenta

            ──────────────────────────────────────────────────────────
            (VÁ ATÉ AO TOPO DA PÁGINA)
            ");

            Utilitario.MensagemParaVoltar();
        }

        


    }

}
