using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class Sistema
    {
        MenuFísicas cadastroDePessoasFisica = new MenuFísicas();
        MenuPessoaJuridica menuPessoaJuridica = new MenuPessoaJuridica();
        MenuDeProdutos menuProdutos = new MenuDeProdutos();
        MenuFuncionarios cadastroDeFuncionarios = new MenuFuncionarios();
        public Sistema()
        {

            GerirMenu();

        }

        public void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha a Opção Desejada\n");
            Console.WriteLine(@"
          
1  - Pessoa Jurídica
2  - Pessoa Física 
3  - Produtos
4  - Funcionários 
5  - Sair");


        }

        

        public void GerirMenu()
        {
            Menu();
            int escolhaMenu = Convert.ToInt32(Console.ReadLine());


            while (escolhaMenu != 5)
            {
                switch (escolhaMenu)
                { /*Primeiro switch chave aberta*/
                    case 1:
                        Console.Clear();
                        Console.WriteLine(@"
1 - Cadastrar 
2 - Editar 
3 - Listar
4 - Buscar 
5 - Total De Funcionários
6 - Média De Funcionários
7 - Cadastro Com Maior Nome De Empresa
8 - Cadastro Com Menor Nome De Empresa
10 - Sair");

                        escolhaMenu = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        switch (escolhaMenu)
                        {

                            case 1:
                                Console.Clear();
                                menuPessoaJuridica.CadastrarPessoaJuridica();
                                break;
                            case 2:
                                menuPessoaJuridica.EditarPessoaJuridica();
                                break;
                            case 3:
                                menuPessoaJuridica.ListarPessoaJuridica();
                                break;
                            case 4:
                                menuPessoaJuridica.BuscarPessoaJuridica();
                                break;
                            case 5:
                                menuPessoaJuridica.TotalDeFuncionario();
                                break;
                            case 6:
                                menuPessoaJuridica.MediaDeFuncionarios();
                                break;
                            case 7:
                                menuPessoaJuridica.EmpresaMaiorNome();
                                break;
                            case 8:
                                menuPessoaJuridica.EmpresaMenorNome();
                                break;
                            case 10:
                                Console.Clear();
                                break;


                        }

                        

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(@"
1 - Cadastrar 
2 - Editar 
3 - Listar 
4 - Buscar  
5 - Total Das Idades de Pessoas Físicas
6 - Média Das Idades de Pessoas Físicas
7 - Pessoa Física Com Maior Idade
8 - Pessoa Física Com Menor Idade
9 - Sair");
                        escolhaMenu = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        switch (escolhaMenu)
                        {

                            case 1:
                                cadastroDePessoasFisica.CadastroDePessoas();
                                break;
                            case 2:
                                cadastroDePessoasFisica.EditarFisica();
                                break;
                            case 3:
                                cadastroDePessoasFisica.ListarFisicas();
                                break;
                            case 4:
                                cadastroDePessoasFisica.NomeBuscar();
                                break;
                            case 5:
                                cadastroDePessoasFisica.SomaIdade();
                                break;
                            case 6:
                                cadastroDePessoasFisica.MediaIdade();
                                break;
                            case 7:
                                cadastroDePessoasFisica.MaiorIdade();
                                break;
                            case 8:
                                cadastroDePessoasFisica.Menoridade();
                                break;
                            case 9:
                                Console.Clear();
                                break;







                        }


                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(@"
1 - Cadastrar 
2 - Editar 
3 - Listar 
4 - Buscar 
5 - Total Dos Valores Dos Produtos
6 - Média Dos Valores Dos Produtos
7 - Maior Valor
8 - Menor Valor
9  - Cadastro com Maior Nome de Produto
10 - Cadastro com Menor Nome de Produto
11 - Total de quantidade de Produto
12 - Média da Quantidade Total de Produto
13 - Sair");
                        escolhaMenu = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        switch (escolhaMenu)
                        {

                            case 1:
                                menuProdutos.Produtos();
                                break;
                            case 2:
                                menuProdutos.EditarProdutos();
                                break;
                            case 3:
                                menuProdutos.ListarProdutos();
                                break;
                            case 4:
                                menuProdutos.BuscarProduto  ();
                                break;
                            case 5:
                                menuProdutos.TotalDosValoresDosProdutos();                           
                                break;
                            case 6:
                                menuProdutos.MediaDosValoresDosProdutos();
                                break;
                            case 7:
                                menuProdutos.MaiorValorDeProdutos();
                                break;
                            case 8:
                                menuProdutos.MenorValorDeProdutos();
                                break;
                            case 9:
                                menuProdutos.MaiorNomeProduto();
                                break;
                            case 10:
                                menuProdutos.MenorNomeProduto();
                                break;
                            case 11:
                                menuProdutos.TotalQuantidadeProduto();
                                break;
                            case 12:
                                menuProdutos.MediaQuantidadeTotal();
                                break;
                            case 13:
                                Console.Clear();
                                break;

                        }

                        
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(@"
1 - Cadastrar
2 - Editar 
3 - Listar 
4 - Buscar 
5 - Total Dos Codigos Dos Funcionário
6 - Média Dos Codigos Dos Funcionário
7 - Funcionario Com Maior Código 
8 - Funcionario Com Menor Código
9 - Sair");
                        escolhaMenu = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        switch (escolhaMenu)
                        {

                            case 1:
                                cadastroDeFuncionarios.CadastroFuncionarios();
                                break;
                            case 2:
                                cadastroDeFuncionarios.EditarFuncionarios();
                                break;
                            case 3:
                                cadastroDeFuncionarios.ListarFuncionarios();
                                break;
                            case 4:
                                cadastroDeFuncionarios.NomeBuscarFuncionario();
                                break;
                            case 5:
                                cadastroDeFuncionarios.SomaDosCodigos();
                                break;
                            case 6:
                                cadastroDeFuncionarios.MediaDosCodigos();
                                break;
                            case 7:
                                cadastroDeFuncionarios.MaiorCodigo();
                                break;
                            case 8:
                                cadastroDeFuncionarios.MenorCodigo();
                                break;
                            case 9:
                                Console.Clear();
                                break;







                        }

                        break;









                }/*Primeiro Switch chave fechada*/
                Menu();
                escolhaMenu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}


       