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
        MenuPessoaJuridica menuPessoaJuridica = new MenuPessoaJuridica();
        MenuDeProdutos menuProdutos = new MenuDeProdutos();
        CadastroFuncionariosDoRestaurante cadastroDeFuncionarios = new CadastroFuncionariosDoRestaurante();
        public Sistema()
        {

            GerirMenu();

        }

        public void Menu()
        {

            Console.WriteLine("Escolha a Opção Desejada\n");
            Console.WriteLine(@"
          
1  - Pessoa Jurídica
2  - Pessoa Física 
3  - Produtos
4  - Funcionarios 
5  - Sair");


        }

        /*A partir daki tudo que vc fazer tem que ser dentro do primeiro switch */

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
1 - Cadastrar Pessoa Juídica
2 - Editar Pessoa Jurídica
3 - Listar Pessoa Jurídica
4 - Buscar Pessoa Jurídica
5 - Total De Funcionarios
6 - Média De Funcionario
7 - Cadastro Com Maior Nome De Empresa
8 - Cadastro Com Menor Nome De Empresa
10 - Sair");

                        escolhaMenu = Convert.ToInt32(Console.ReadLine());


                        switch (escolhaMenu)
                        {

                            case 1:
                                Console.Clear();
                                menuPessoaJuridica.CadastrarPessoaJuridica();
                                break;
                            case 2:
                                menuPessoaJuridica.ListarPessoaJuridica();
                                break;
                            case 3:
                                menuPessoaJuridica.BuscarPessoaJuridica();
                                break;
                            case 4:
                                menuPessoaJuridica.EditarPessoaJuridica();
                                break;
                            case 5:
                                // Total De Funcionarios
                                break;
                            case 6:
                                // Média De Funcionario
                                break;
                            case 7:
                                // Cadastro Com Maior Nome De Empresa
                                break;
                            case 8:
                                // Cadastro Com Menor Nome De Empresa
                                break;
                            case 10:
                                Console.Clear();
                                break;


                        }

                        /*Já deixei separado onde vc tem que fazer o seu dmr so faz como eu fiz ali que é gg  pode apagar esse comentario i*/

                        break;
                    case 2:
                        Console.Clear();


                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(@"
1 - Cadastrar Produto
2 - Editar Pruduto
3 - Listar Procuto
4 - Buscar Produto 
5 - Total Dos Valores Dos Produtos
6 - Média Dos Valores Dos Produtos
7 - Produto Com Maior Valor
8 - Produto Com Menor Valor
9 - Sair");

                        escolhaMenu = Convert.ToInt32(Console.ReadLine());


                        switch (escolhaMenu)
                        {

                            case 1:
                                menuProdutos.Produtos();
                                break;
                            case 2:
                                menuProdutos.ListarProdutos();
                                break;

                            case 3:
                                menuProdutos.BuscarProduto  ();
                                break;
                            case 4:
                                menuProdutos.EditarProdutos();
                                break;
                            case 5:
                                menuProdutos.TotalDosValoresDosProdutos();
                                break;
                            case 6:
                                //  Média dos Valores dos Produtos
                                break;
                            case 7:
                                // Produto com Maior Valor
                                break;
                            case 8:
                                // Produto com Menor Valor
                                break;
                            case 9:
                                Console.Clear();
                                break;







                        }

                        /*Já deixei separado onde vc tem que fazer o seu dmr so faz como eu fiz ali que é gg  pode apagar esse comentario i*/
                        break;
                    case 4:
                        Console.Clear();
                        break;









                }/*Primeiro Switch chave fechada*/
                Menu();
                escolhaMenu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}


       