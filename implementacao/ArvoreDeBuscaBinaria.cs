
// using TrabalhoP12AED.estrutura;
// namespace TrabalhoP12AED.logica
// {
    

//     public class ArvoreDeBuscaBinaria
//     {
//         private No Raiz = null;


//         public void Inserir(char valor)
//         {
//             Raiz = InserirRecursao(valor, Raiz);
//         }

//         public void Percorrer()
//         {
//             EmOrdem(Raiz);
//         }

//         private static No InserirRecursao(char valor, No no)
//         {
//             if(no == null)
//                 return new No(valor);



//             if (valor < no.Valor)
//             {
//                 no.Esquerdo = InserirRecursao(valor, no.Esquerdo);
//             }
//             else if(valor > no.Valor)
//             {
//                 no.Direito = InserirRecursao(valor, no.Direito);
//             }

//             return no;
//         }

//         private void PreOrdem(No no)
//         {
//             if (no == null) return;

//             Console.Write(no.Valor + ", ");
//             PreOrdem(no.Esquerdo);
//             PreOrdem(no.Direito);
//         }

//         private void EmOrdem(No no)
//         {
//             if (no == null) return;

//             EmOrdem(no.Esquerdo);
//             Console.Write(no.Valor + ", ");
//             EmOrdem(no.Direito);
//         }

//         private static void PosOrdem(No no)
//         {
//             if (no == null) return;

//             PosOrdem(no.Esquerdo);
//             PosOrdem(no.Direito);
//             Console.Write(no.Valor + ", ");
//         }

//     }

// }
