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
        double[] valores = new double[100];
        double somaDoValorProdutos = 0;
        int atual = 0;
        double maiorValor = 0, menorValor = 100000000000000, mediaValor = 0, somaQuantidadeProdutos = 0, mediaQuantidadeProdutos = 0;
        string maiorNomeProduto = "", menorNomeProduto = "oooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
        bool validaQuantidade = true, validaValor = true;


        public void Produtos()
        {

            bool validaProduto = true;
            while (validaProduto == true)
            {
                try
                {
                    Console.Write("Nome do Produto: ");
                    nomeProduto[atual] = Console.ReadLine();
                    if (nomeProduto[atual].Length >= 4)
                    {
                        validaProduto = false;
                    }
                    else
                    {
                        Console.WriteLine("Nome do Produto deve conter pelo menos 4 carácteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor informe o Nome do Produto novamente, utilizando apenas letras ");
                }
            }

            bool validaTipo = true;
            while (validaTipo == true)
            {
                try
                {
                    Console.Write("Tipo: ");
                    tiposDeProdutos[atual] = Console.ReadLine();
                    if (tiposDeProdutos[atual].Length >= 4)
                    {
                        validaTipo = false;
                    }
                    else
                    {
                        Console.WriteLine("Tipo deve conter pelo menos 4 carácteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor informe o Tipo novamente, utilizando apenas letras ");
                }
            }

            validaQuantidade = true;
            while (validaQuantidade == true)
            {
                try
                {
                    Console.Write("Quantidade de Produtos: ");
                    quantidadeProdutos[atual] = Convert.ToInt32(Console.ReadLine());
                    if (quantidadeProdutos[atual] > 0)
                    {
                        validaQuantidade= false;

                    }
                    else
                    {
                        Console.WriteLine("Quantidade de produtos deve ser maior que 0 ");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Por favor informe Quantidade de Produtos novamente, utilizando apenas números inteiros ");
                }
            }

            validaValor = true;
            while (validaValor == true)
            {
                try
                {
                    Console.Write("Valor: ");
                    valores[atual] = Convert.ToDouble(Console.ReadLine());
                    if (valores[atual] > 0)
                    {
                        validaValor = false;

                    }
                    else
                    {
                        Console.WriteLine("Valor deve ser maior que 0 ");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Por favor informe Valor novamente, utilizando apenas números ");
                }
            }

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
                        "\nNome: {0} \nTipo: {1} \nQuantidade de Produtos: {2}  \nValor: R$ {3}",
                       tiposDeProdutos[i], nomeProduto[i], quantidadeProdutos[i], valores[i]
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
                              "\nNome: {0} \nTipo: {1} \nQuantidade de Produtos: {2} \nValor: R$ {3}",
                        nomeProduto[i], tiposDeProdutos[i], quantidadeProdutos[i], valores[i]

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
             }
             if (posicao != -1)
             {

                bool validaProduto = true;
                while (validaProduto == true)
                {
                    try
                    {
                        Console.Write("Nome do Produto: ");
                        nomeProduto[atual] = Console.ReadLine();
                        if (nomeProduto[atual].Length >= 4)
                        {
                            validaProduto = false;
                        }
                        else
                        {
                            Console.WriteLine("Nome do Produto deve conter pelo menos 4 carácteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Por favor informe o Nome do Produto novamente, utilizando apenas letras ");
                    }
                }

                bool validaTipo = true;
                while (validaTipo == true)
                {
                    try
                    {
                        Console.Write("Tipo: ");
                        tiposDeProdutos[atual] = Console.ReadLine();
                        if (tiposDeProdutos[atual].Length >= 4)
                        {
                            validaTipo = false;
                        }
                        else
                        {
                            Console.WriteLine("Tipo deve conter pelo menos 4 carácteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Por favor informe o Tipo novamente, utilizando apenas letras ");
                    }
                }

                validaQuantidade = true;
                while (validaQuantidade == true)
                {
                    try
                    {
                        Console.Write("Quantidade de Produtos: ");
                        quantidadeProdutos[atual] = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeProdutos[atual] > 0)
                        {
                            validaQuantidade = false;

                        }
                        else
                        {
                            Console.WriteLine("Quantidade de produtos deve ser maior que 0 ");
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Por favor informe Quantidade de Produtos novamente, utilizando apenas números inteiros ");
                    }
                }

                validaValor = true;
                while (validaValor == true)
                {
                    try
                    {
                        Console.Write("Valor: ");
                        valores[atual] = Convert.ToDouble(Console.ReadLine());
                        if (valores[atual] > 0)
                        {
                            validaValor = false;

                        }
                        else
                        {
                            Console.WriteLine("Valor deve ser maior que 0 ");
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Por favor informe Valor novamente, utilizando apenas números ");
                    }
                }

             }
             else
             {
                Console.WriteLine("Registro não encontrado");
                Console.WriteLine();

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
            Console.WriteLine();

        }

        public void MediaDosValoresDosProdutos()
        {
            for (int i = 0; i < valores.Length; i++)
            {
               mediaValor  = somaDoValorProdutos / atual;
            }

            Console.WriteLine("Média do Valor Total dos Produtos: R$ " + mediaValor);
            Console.WriteLine();
            

        }

        public void MaiorValorDeProdutos()
        {
            for (int i = 0; i < atual; i++)
            {                
                if (valores.Length > maiorValor)
                {
                    maiorValor = valores[i];
                }

            }

            Console.WriteLine("Maior valor: R$ " + maiorValor);
            Console.WriteLine();
        }

        public void MenorValorDeProdutos()
        {
            for (int i = 0; i < nomeProduto.Length; i++)
            {


                if (valores.Length < menorValor)
                {
                    menorValor = valores[i];

                }

            }
                Console.Write("Menor valor : R$ " + menorValor);
                Console.WriteLine();
        }

        public void MaiorNomeProduto()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomeProduto[i].Length > maiorNomeProduto.Length)
                {
                    maiorNomeProduto = nomeProduto[i];
                }
            }

            Console.WriteLine("Produto com Maior Nome: " + maiorNomeProduto);
        }


        public void MenorNomeProduto()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomeProduto[i].Length < menorNomeProduto.Length)
                {
                    menorNomeProduto = nomeProduto[i];
                }
            }

            Console.WriteLine("Menor Nome de Produto: " + menorNomeProduto);
        }

        public void TotalQuantidadeProduto()
        {
            for (int i = 0; i < quantidadeProdutos.Length; i++)
            {
                somaQuantidadeProdutos = quantidadeProdutos[i] + somaQuantidadeProdutos;
            }

            Console.WriteLine("Total da Quantidade de Produto: " + somaQuantidadeProdutos);
        }

        public void MediaQuantidadeTotal()
        {
            for (int i = 0; i < quantidadeProdutos.Length; i++)
            {
                mediaQuantidadeProdutos = somaQuantidadeProdutos / atual;
            }

            Console.WriteLine("Média da Quantidade de Produto: " + mediaQuantidadeProdutos);

        }

        public void VoltarMenuProduto()
        {
            Console.Clear();

        }

    }

}
