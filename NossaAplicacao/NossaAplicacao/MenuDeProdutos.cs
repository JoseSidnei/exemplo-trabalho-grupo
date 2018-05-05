using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class MenuDeProdutos
    {
        
        string[] tiposDeProdutos = new string[100];
        string[] nomeProduto = new string[100];
        int[] quantidadeProdutos = new int[100];        
        string[] validade = new string[100];
        double[] valores = new double[100];
        double somaDoValorProdutos = 0;
        int atual = 0;
        double maiorValor = 0, menorValor = 100000000000000, mediaValor = 0;


        public void Produtos()
        {         
                Console.Write("Nome do Produto: ");
                nomeProduto[atual] = Console.ReadLine().ToLower().Trim();
                Console.Write("Tipo: ");
                tiposDeProdutos[atual] = Console.ReadLine().ToLower().Trim();
                Console.Write("Quantidade de Produtos: ");
                quantidadeProdutos[atual] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Validade: ");
                validade[atual] = Console.ReadLine();
                Console.Write("Valor: ");
                valores[atual] = Convert.ToDouble(Console.ReadLine());
                atual++;
                Console.Clear();
            
           
        }

        public void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Produtos ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nNome: {0} \nTipo: {1} \nQuantidade de Produtos: {2} \nValidade: {3} \nValor: R$ {4}",
                       tiposDeProdutos[i], nomeProduto[i], quantidadeProdutos[i], validade[i], valores[i]
                        )
                    );
            }
        }

        internal void BuscarProduto()
        {
            Console.Write("Digite o nome para busca: ");
            string nomeProdutoBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeProdutoBuscado == nomeProduto[i])
                {
                    Console.WriteLine(
                        String.Format(
                              "\nNome: {0} \nTipo: {1} \nQuantidade de Produtos: {2} \nValidade: {3} \nValor: R$ {4}",
                       tiposDeProdutos[i], nomeProduto[i], quantidadeProdutos[i], validade[i], valores[i]

                        )
                    );
                    achou = true;
                    break;
                }
            }
            if (!achou)
            {
                Console.WriteLine("Nome não encontrado");
            }
        }

        internal void EditarProdutos()
        {
             Console.Clear();
             Console.Write("Digite um nome para pesquisa : ");
             string nomePesquisado = Console.ReadLine().ToLower().Trim();
             int posicao = -1;
             for (int i = 0; i < atual; i++)
             {
                 if (nomePesquisado == nomeProduto[i])
                 {
                     posicao = i;
                 }

                 if (posicao != -1)
                 {
                     
                    Console.Write("Nome do Produto: ");
                    nomeProduto[atual] = Console.ReadLine().ToLower().Trim();
                    Console.Write("Tipo: ");
                    tiposDeProdutos[atual] = Console.ReadLine().ToLower().Trim();
                    Console.Write("Quantidade de Produtos: ");
                    quantidadeProdutos[atual] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Validade: ");
                    validade[atual] = Console.ReadLine();
                    Console.Write("Valor: ");
                    valores[atual] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Dados alterados com sucesso");
                 }
                 else
                 {
                     Console.WriteLine("Registro não encontrado");

                 }

             }
        }

        public void TotalDosValoresDosProdutos()
        {
            Console.Clear();


            for (int i = 0; i < valores.Length; i++)
            {
                somaDoValorProdutos = valores[i] + somaDoValorProdutos;
            }

            Console.WriteLine("Valor Total dos Produtos: R$ " + somaDoValorProdutos);


        }

        public void MediaDosValoresDosProdutos()
        {
            for (int i = 0; i < valores.Length; i++)
            {
               mediaValor  = somaDoValorProdutos / atual;
            }

            Console.WriteLine("Média do Total dos Produtos: R$ " + mediaValor);
            

        }

        public void MaiorValorDeProdutos()
        {
            for (int i = 0; i < valores.Length; i++)
            {                
                if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                }

            }

            Console.WriteLine(" Valor do Produto: R$ " + maiorValor + " Produto com Maior Valor: " + nomeProduto[atual]);
        }

        public void MenorValorDeProdutos()
        {
            for (int i = 0; i < valores.Length; i++)
            {


                if (valores.Length < menorValor)
                {
                    menorValor = valores[i];
                }

                Console.Write("Produto com Menor Valor: " + nomeProduto[i] + "Valor do Produto: " + valores[i]);
                Console.WriteLine();
            }
        }

    }
}
