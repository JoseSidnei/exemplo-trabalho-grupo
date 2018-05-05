﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class MenuPessoaJuridica
    {
        string[] nomesEmpresa = new string[100];
        string[] telefones = new string[100];
        string[] emails = new string[100];
        string[] cidades = new string[100];
        string[] enderecos = new string[100];       
        string[] bairros = new string[100];
        string[] ceps = new string[100];
        int[] quantidadeFuncionarios = new int[100];
        string[] horariosEntrega = new string[100];
        double somaQuantidadeFuncionarios = 0, mediaDeFuncionarios = 0;        
        string maiorNomeJuridico = "";
        string menorNomeJuridico = "ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
        int atual = 0;

        public void CadastrarPessoaJuridica()
        {
            Console.Clear();
            Console.Write("Nome da empresa: ");
            nomesEmpresa[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Telefone para contato: ");
            telefones[atual] =Console.ReadLine();
            Console.Write("Email: ");
            emails[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Ebdereço: ");
            enderecos[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Cidade: ");
            cidades[atual] = Console.ReadLine().ToLower().Trim();            
            Console.Write("Bairro: ");
            bairros[atual] = Console.ReadLine().ToLower().Trim();           
            Console.Write("CEP: ");
            ceps[atual] = Console.ReadLine();
            Console.Write("Quantidade de Funcionários: ");
            quantidadeFuncionarios[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Horário para entrega: ");
            horariosEntrega[atual] = Console.ReadLine();
            atual++;
                             
        }

        public void ListarPessoaJuridica()
        {
            Console.Clear();
            Console.WriteLine("Lista de pessoas Jurídicas cadastradas ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nNome da Empresa:: {0} \nTelefone para Contato: {1} \nEmail: {2} \nEndereço: {3} \nCidade: {4} " +
                       "\nBairro: {5} \nCEP: {6} \nQuantidade de Funcionários: {7} \nHorário para Entrega: {8}",
                       nomesEmpresa[i], telefones[i], emails[i], enderecos[i], cidades[i], bairros[i], ceps[i],
                       quantidadeFuncionarios[i], horariosEntrega[i]
                        )
                    );
            }
        }

        internal void BuscarPessoaJuridica()
        {
            Console.Write("Digite o nome para busca: ");
            string nomePessoaJuridicaBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomePessoaJuridicaBuscado == nomesEmpresa[i])
                {
                    Console.WriteLine(
                        String.Format(
                             "\nNome da Empresa:: {0} \nTelefone para Contato: {1} \nEmail: {2} \nEndereço: {3} \nCidade: {4} " +
                       "\nBairro: {5} \nCEP: {6} \nQuantidade de Funcionários: {7} \nHorário para Entrega: {8}",
                       nomesEmpresa[i], telefones[i], emails[i], enderecos[i], cidades[i], bairros[i], ceps[i],
                       quantidadeFuncionarios[i], horariosEntrega[i]

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

        public void EditarPessoaJuridica()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para pesquisa");
            string nomePessoaJuridicaPesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePessoaJuridicaPesquisado == nomesEmpresa[i])
                {
                    posicao = i;
                }
            }

            if (posicao != -1)
            {
                
                Console.Write("Nome da empresa: ");
                nomesEmpresa[atual] = Console.ReadLine().ToLower().Trim();
                Console.Write("Telefone para contato: ");
                telefones[atual] = Console.ReadLine();
                Console.Write("Email: ");
                emails[atual] = Console.ReadLine().ToLower().Trim();
                Console.Write("Ebdereço: ");
                enderecos[atual] = Console.ReadLine().ToLower().Trim();               
                Console.Write("Cidade: ");
                cidades[atual] = Console.ReadLine().ToLower().Trim();
                Console.Write("Bairro: ");
                bairros[atual] = Console.ReadLine().ToLower().Trim();
                Console.Write("CEP: ");
                ceps[atual] = Console.ReadLine();
                Console.Write("Quantidade de Funcionários: ");
                quantidadeFuncionarios[atual] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Horário para entrega: ");
                horariosEntrega[atual] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Registro não encontrado");

            }
        }

       public void TotalDeFuncionario()
       {
            for (int i = 0; i < quantidadeFuncionarios.Length; i++)
            {
                somaQuantidadeFuncionarios = quantidadeFuncionarios[i] +  somaQuantidadeFuncionarios;
            }

            Console.WriteLine("Quantidade Total de Funcionario: " + somaQuantidadeFuncionarios);
            Console.WriteLine();
       }

        public void MediaDeFuncionarios()
        {
            for (int i = 0; i < quantidadeFuncionarios.Length; i++)
            {
                mediaDeFuncionarios = somaQuantidadeFuncionarios / atual;
            }

            Console.WriteLine("Média da Quantidade de Funcionarios: " + mediaDeFuncionarios);
        }

        public void EmpresaMaiorNome()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomesEmpresa[i].Length > maiorNomeJuridico.Length)
                {
                    maiorNomeJuridico = nomesEmpresa[i];
                }
            }

            Console.WriteLine("Empresa com Maior Nome: " + maiorNomeJuridico);
        }

        public void EmpresaMenorNome()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomesEmpresa[i].Length < menorNomeJuridico.Length)
                {
                    menorNomeJuridico = nomesEmpresa[i];
                }
            }

            Console.WriteLine("Empresa com Maior Nome: " + menorNomeJuridico);
        }

    }
}
