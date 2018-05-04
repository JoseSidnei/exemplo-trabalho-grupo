using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class Sistema
    {
        CadastroPessoaFisica cadastroDePessoasFisica = new CadastroPessoaFisica();
        CadastroPessoaJuridica cacadastrarPessoaJuridica = new CadastroPessoaJuridica();
        CadastrarProdutos cadatrarProdutos = new CadastrarProdutos();
        CadastroFuncionariosDoRestaurante cadastroDeFuncionarios = new CadastroFuncionariosDoRestaurante();
        
        
          
        public Sistema()
        {
            GeriMenu();
        }
        public void Menu()
        {
            Console.WriteLine(
                @"
1  - Cadastra de pessoa Física 
2  - Cadastrar de pessoa Jurídica
3  - Cadastrar Produtos
4  - Cadastrar Funcionarios do Restaurante 
5  - Listar Cadastros de pessoas Físicas
6  - Listar Cadastros de Funcionarios
7  - Listar Cadastros Produtos
8  - Listar cadastros Pessoa Jurídica 
9  - Buscar cadastro Pessoa Física
10 - Buscar cadastro Pessoa jurídica
11 - Buscar Produtos
12 - Buscar Cadastro Funcionários
13 - Sair");
        }
        public void GeriMenu()
        {

            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            while (menuEscolha != 13)
            {
                switch (menuEscolha)
                {
                    case 1:
                        cadastroDePessoasFisica.CadastroDePessoas();
                        break;
                    case 2:
                        cacadastrarPessoaJuridica.CadastroPessoaJuridica();
                        break;
                    case 3:
                        cadatrarProdutos.CadastrarProdutos();
                        break;
                    case 4:
                        cadastroDeFuncionarios.CadastroFuncionarios();
                        break;
                    case 5:
                        cadastroDePessoasFisica.ListarFisicas();
                        break;
                    case 6:
                        cadastroDeFuncionarios.ListarFuncionarios();
                        break;
                    case 7:
                        cadatrarProdutos.ListarProdutos();
                        break;
                    case 8:
                        cacadastrarPessoaJuridica.ListarPessoaJuridica();
                        break;
                    case 9:

                        break;
                    case 10:
                        cacadastrarPessoaJuridica.BuscarPessoaJuridica();
                        break;
                    case 11:
                        cadatrarProdutos.BuscarProduto();
                        break;
                    case 12:

                        break;
                    

                }
                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
           }
         }









      }
   }

