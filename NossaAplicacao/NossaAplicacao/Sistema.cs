﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class Sistema
    {
        CadastroPessoaFisica cadastroDePessoasFisica = new CadastroPessoaFisica();
        CadastroPessoaJuridica cadastroPessoaJuridica = new CadastroPessoaJuridica();
        CadastroFuncionariosDoRestaurante cadastroDeFuncionarios = new CadastroFuncionariosDoRestaurante();
        
          
        public Sistema()
        {
            GeriMenu();
        }
        public void Menu()
        {
            Console.WriteLine(
                @"
1 - Cadastro de pessoa Física 
2 - Cadastro de pessoa Jurídica
3 - Produtos
4 - Cadastro Funcionarios do Restaurante 
5 - Listar Cadastros de pessoas Físicas
6 - 
7 -
8 - Sair");
        }
        public void GeriMenu()
        {

            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            while (menuEscolha != 7)
            {
                switch (menuEscolha)
                {
                    case 1:
                        cadastroDePessoasFisica.CadastroDePessoas();
                        break;
                    case 2:
                        cadastroPessoaJuridica.CadastroPessoaJuridica();
                        break;
                    case 3:

                        break;
                    case 4:
                        cadastroDeFuncionarios.CadastroFuncionarios();
                        break;
                    case 5:
                        cadastroDePessoasFisica.ListarFisicas();
                        break;
                    case 6:

                        break;

                }
                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
           }
         }









      }
   }

