﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class CadastrarProdutos
    {
        
        string[] tiposDeProdutos = new string[100];
        string[] nomeProduto = new string[100];
        int[] quantidadeProdutos = new int[100];
        string[] validade = new string[100];
        double[] valores = new double[100];
        int atual = 0;

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
        }

        public void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Produtos ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nNome: {0} \nTipo: {1} \nQuantidade de Produtos: {2} \nValidade: {3} \nValor: {4}",
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
                              "\nNome: {0} \nTipo: {1} \nQuantidade de Produtos: {2} \nValidade: {3} \nValor: {4}",
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
            Console.WriteLine("Digite o nome para busca: ");
            string nomeProdutoBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeProdutoBuscado == nomeProduto[i])
                {
                    Console.WriteLine(
                        String.Format(
                            "\nNome: {0} \nTipo: {1} \nQuantidade de Produtos: {2} \nValidade: {3} \nValor: {4}",
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

    }
}
