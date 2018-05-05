﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class MenuFísicas
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
        double somaDasIdades = 0;
        int menoridade = 99999999, maioridade = 0;

        public void CadastroDePessoas()
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
                somaDasIdades = somaDasIdades / idade.Length;
            }

            Console.WriteLine("Média Das Idades das pessoas Físicas: " + somaDasIdades);

        }

        public void MaiorIdade()
        {
            for (int i = 0; i < idade.Length; i++)
            {
                if (idade.Length > maioridade)
                {
                    maioridade = idade[atual];
                }

                Console.WriteLine(" A maior Idade é: " + idade[atual] + "Nome da Pessoa Física com maior Idade: " + nomesPessoa[atual]);
            }
        }

        public void Menoridade()
        {
            for (int i = 0; i < idade.Length; i++)
            {
                if (idade.Length < menoridade)
                {
                   menoridade = idade[atual];
                }

                Console.WriteLine(" A menor Idade é: " + idade[atual] + "Nome da Pessoa Física com menor Idade: " + nomesPessoa[atual]);
            }

        }
    }
}


 
    
