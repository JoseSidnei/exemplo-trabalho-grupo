﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class Menufisica
    {
        string[] nomesPessoa = new string[100];
        int[] numeroCasa = new int[100];
        int[] idade = new int[100];
        string[] cidade = new string[100];
        int[] cep = new int[100];
        string[] bairro = new string[100];
        string[] rua = new string[100];
        string[] email = new string[100];
        int atual = 0;
        double somaDasIdades = 0, mediaDaIdade = 0;
        string menornome = "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK", maiornome = "";
        bool validacaoNumero = true, validacaoIdade = true, validacaoCep = true;

        public void CadastroDePessoas()
        {
            Console.Clear();
            Console.Write("Nome : ");
            nomesPessoa[atual] = Console.ReadLine();
            validacaoNumero = true;
            while (validacaoNumero == true)
            {
                try
                {
                    Console.Write("Nº: ");
                    numeroCasa[atual] = Convert.ToInt32(Console.ReadLine());
                    validacaoNumero = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Digite novamente o Numero por favor");
                }
            }
            validacaoIdade = true;
            while (validacaoIdade == true)
            {
                try
                {
                    Console.Write("Idade: ");
                    idade[atual] = Convert.ToInt32(Console.ReadLine());
                    validacaoIdade = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Digite novamente a Idade por favor");
                }
            }

            
            Console.Write("Cidade: ");
            cidade[atual] = Console.ReadLine();
            validacaoCep = true;
            while (validacaoCep == true)
            {
                try
                {
                    Console.Write("Cep: ");
                    cep[atual] = Convert.ToInt32(Console.ReadLine());
                    validacaoCep = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Digite novamente o CEP por favor");
                }
            }
            
            Console.Write("Bairro: ");
            bairro[atual] = Console.ReadLine();
            Console.Write("Rua: ");
            rua[atual] = Console.ReadLine();
            Console.Write("E-mail: ");
            email[atual] = Console.ReadLine();
            atual++;
        }
        public void ListarFisicas()
        {
            Console.Clear();
            Console.WriteLine("Lista de Pessoas Físicas ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nNome: {0} \nNº: {1} \nIdade: {2} \nCidade: {3} \nCep: {4} \nBairro: {5} \nRua: {6} \nE-mail: {7}",
                        nomesPessoa[i], numeroCasa[i], idade[i], cidade[i], cep[i], bairro[i], rua[i], email[i]
                        )
                    );
            }
        }

        internal void NomeBuscar()
        {
            Console.WriteLine("Digite o nome para busca: ");
            string nomeBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == nomesPessoa[i])
                {
                    Console.WriteLine(
                        String.Format(
                       "\nNome: {0} \nNº: {1} \nIdade: {2} \nCidade: {3} \nCep: {4} \nBairro: {5} \nRua: {6} \nE-mail: {7}",
                       nomesPessoa[i], numeroCasa[i], idade[i], cidade[i], cep[i], bairro[i], rua[i], email[i]
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

        public void EditarFisica()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para pesquisa");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == nomesPessoa[i])
                {
                    posicao = i;
                }
            }

            if (posicao != -1)
            {

                Console.Clear();
                Console.Write("Nome : ");
                nomesPessoa[atual] = Console.ReadLine();
                Console.Write("Nº: ");
                numeroCasa[atual] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Idade: ");
                idade[atual] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cidade: ");
                cidade[atual] = Console.ReadLine();
                Console.Write("Cep: ");
                cep[atual] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bairro: ");
                bairro[atual] = Console.ReadLine();
                Console.Write("Rua: ");
                rua[atual] = Console.ReadLine();
                Console.Write("E-mail: ");
                email[atual] = Console.ReadLine();
                Console.WriteLine("Dados alterados com sucesso");
            }
            else
            {
                Console.WriteLine("Registro não encontrado");

            }
        }
        public void SomaIdade()
        {
            Console.Clear();


            for (int i = 0; i < idade.Length; i++)
            {
                somaDasIdades = idade[i] + somaDasIdades;
            }

            Console.WriteLine("Soma das idades das pessoas Físicas: " + somaDasIdades);


        }

        public void MediaIdade()
        {
            for (int i = 0; i < idade.Length; i++)
            {
                mediaDaIdade = somaDasIdades / atual;
            }

            Console.WriteLine("Média das idades: " + mediaDaIdade);
        }

        public void MaiorNome()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomesPessoa[i].Length > maiornome.Length)
                {
                    maiornome = nomesPessoa[i];
                }
            }

            Console.WriteLine("Pessoa Física com maior nome: " + maiornome);
        }

        public void MenorNome()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomesPessoa[i].Length < menornome.Length)
                {
                    menornome = nomesPessoa[i];
                }
            }

            Console.WriteLine("Pessoa com menor nome: " + menornome);
        }
    }
}
