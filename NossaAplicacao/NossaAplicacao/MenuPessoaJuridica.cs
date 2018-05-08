using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class MenuPessoaJuridica
    {
        string[] nomesEmpresa = new string[100];
        int[] telefones = new int[100];
        string[] emails = new string[100];
        string[] cidades = new string[100];
        string[] enderecos = new string[100];
        int[] numero = new int[100];
        string[] bairros = new string[100];
        int[] ceps = new int[100];
        int[] quantidadeFuncionarios = new int[100];        
        double somaQuantidadeFuncionarios = 0, mediaDeFuncionarios = 0;        
        string maiorNomeJuridico = "";
        string menorNomeJuridico = "ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
        int atual = 0;
        bool validaNumero = true, validaCep = true, validaTelefone = true, validaQuantidadeFuncionario = true;

        public void CadastrarPessoaJuridica()
        {

            Console.Clear();
            bool validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Nome da Empresa: ");
                    nomesEmpresa[atual] = Console.ReadLine();
                    if (nomesEmpresa[atual].Length >= 4)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Nome da empresa precisa conter pelo menos 4 carácteres ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor informe o Nome da empresa novamente, utilizando apenas letras ");
                }
            }


            validaTelefone = true;
            while (validaTelefone == true)
            {
                try
                {
                    Console.Write("Telefone para contato: ");
                    telefones[atual] = Convert.ToInt32(Console.ReadLine());
                    if (telefones[atual] > 0)
                    {
                        validaTelefone = false;
                    }
                    else
                    {
                        Console.WriteLine("Telefone precisa ser maior que 0 ");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Por favor informe o Telefone  novamente, utilizando apenas números ");
                }
            } 
            
            Console.Write("Email: ");
            emails[atual] = Console.ReadLine().ToLower().Trim();

            bool validaEndereco = true;
            while (validaEndereco == true)
            {
                try
                {
                    Console.Write("Endereço: ");
                    enderecos[atual] = Console.ReadLine();
                    if (nomesEmpresa[atual].Length >= 4)
                    {
                        validaEndereco = false;
                    }
                    else
                    {
                        Console.WriteLine("Endereço deve conter pelo menos 4 carácteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor informe o Endereço novamente, utilizando apenas letras ");
                }
            }


            validaNumero = true;
            while (validaNumero == true)
            {
                try
                {
                    Console.Write("Número: ");
                    numero[atual] = Convert.ToInt32(Console.ReadLine());
                    if (numero[atual] > 0)
                    {
                        validaNumero = false;
                    }
                    else
                    {
                        Console.WriteLine("Número precisa ser maior que 0 ");
                    }
                    
                }
                catch (Exception)
                {

                    Console.WriteLine("Por favor informe o Número novamente, utilizando apenas números inteiros ");
                }
            }

            bool validaCidade = true;
            while (validaCidade == true)
            {
                try
                {
                    Console.Write("Cidade: ");
                    cidades[atual] = Console.ReadLine();
                    if (cidades[atual].Length >= 4)
                    {
                        validaCidade = false;
                    }
                    else
                    {
                        Console.WriteLine("Cidade deve conter pelo menos 4 carácteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor informe a Cidade novamente, utilizando apenas letras ");
                }
            }

            bool validaBairro = true;
            while (validaBairro == true)
            {
                try
                {
                    Console.Write("Bairro: ");
                    bairros[atual] = Console.ReadLine();
                    if (bairros[atual].Length >= 4)
                    {
                        validaBairro = false;
                    }
                    else
                    {
                        Console.WriteLine("Bairro deve conter pelo menos 4 carácteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor informe o Bairro novamente, utilizando apenas letras ");
                }
            }


            validaCep = true;
            while (validaCep == true)
            {
                try
                {
                    Console.Write("CEP : ");
                    ceps[atual] = Convert.ToInt32(Console.ReadLine());
                    validaCep = false;
                                     
                }
                catch (Exception )
                {

                    Console.WriteLine("Por favor informe CEP novamente, utilizando apenas números ");
                }
            }

            validaQuantidadeFuncionario = true;
            while (validaQuantidadeFuncionario == true)
            {
                try
                {
                     Console.Write("Quantidade de Funcionários: ");
                     quantidadeFuncionarios[atual] = Convert.ToInt32(Console.ReadLine());                     
                     validaQuantidadeFuncionario = false;

                }
                catch (Exception)
                {

                    Console.WriteLine("Por favor informe Quantidade de Funcionários novamente, utilizando apenas números inteiros ");
                }
            }

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
                        "\nNome da Empresa: {0} \nTelefone para Contato: {1} \nEmail: {2} \nEndereço: {3} \nNúmero: {4} \nCidade: {5} " +
                       "\nBairro: {6} \nCEP: {7} \nQuantidade de Funcionários: {8} ",
                       nomesEmpresa[i], telefones[i], emails[i], enderecos[i], numero[i], cidades[i], bairros[i], ceps[i],
                       quantidadeFuncionarios[i]
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
                              "\nNome da Empresa: {0} \nTelefone para Contato: {1} \nEmail: {2} \nEndereço: {3} \nNúmero: {4} \nCidade: {5} " +
                       "\nBairro: {6} \nCEP: {7} \nQuantidade de Funcionários: {8} ",
                       nomesEmpresa[i], telefones[i], emails[i], enderecos[i], numero[i], cidades[i], bairros[i], ceps[i],
                       quantidadeFuncionarios[i]

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
            Console.Write("Digite um nome para pesquisa ");
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

                bool validarTexto = true;
                while (validarTexto == true)
                {
                    try
                    {
                        Console.Write("Nome da Empresa: ");
                        nomesEmpresa[atual] = Console.ReadLine();
                        if (nomesEmpresa[atual].Length >= 4)
                        {
                            validarTexto = false;
                        }
                        else
                        {
                            Console.WriteLine("Nome da empresa precisa conter pelo menos 4 carácteres ");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Por favor informe o Nome da empresa novamente, utilizando apenas letras ");
                    }
               }


                validaTelefone = true;
                while (validaTelefone == true)
                {
                    try
                    {
                        Console.Write("Telefone para contato: ");
                        telefones[atual] = Convert.ToInt32(Console.ReadLine());
                        if (telefones[atual] > 0)
                        {
                            validaTelefone = false;
                        }
                        else
                        {
                            Console.WriteLine("Telefone precisa ser amior que 0 ");
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Por favor informe o Telefone  novamente, utilizando apenas números ");
                    }
                }

                Console.Write("Email: ");
                emails[atual] = Console.ReadLine().ToLower().Trim();

                bool validaEndereco = true;
                while (validaEndereco == true)
                {
                    try
                    {
                        validaEndereco = true;
                        Console.Write("Endereço: ");
                        enderecos[atual] = Console.ReadLine();
                        if (nomesEmpresa[atual].Length >= 4)
                        {
                            validaEndereco = false;
                        }
                        else
                        {
                            Console.WriteLine("Endereço deve conter pelo menos 10 carácteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Por favor informe o Endereço novamente, utilizando apenas letras ");
                    }
                }


                validaNumero = true;
                while (validaNumero == true)
                {
                    try
                    {
                        Console.Write("Número: ");
                        numero[atual] = Convert.ToInt32(Console.ReadLine());
                        validaNumero = false;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Por favor informe o Número novamente, utilizando apenas números inteiros ");
                    }
                }

                bool validaCidade = true;
                while (validaCidade == true)
                {
                    try
                    {
                        Console.Write("Cidade: ");
                        cidades[atual] = Console.ReadLine();
                        if (cidades[atual].Length >= 4)
                        {
                            validaCidade = false;
                        }
                        else
                        {
                            Console.WriteLine("Cidade deve conter pelo menos 4 carácteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Por favor informe a Cidade novamente, utilizando apenas letras ");
                    }
                }

                bool validaBairro = true;
                while (validaBairro == true)
                {
                    try
                    {
                        Console.Write("Bairro: ");
                        bairros[atual] = Console.ReadLine();
                        if (bairros[atual].Length >= 4)
                        {
                            validaBairro = false;
                        }
                        else
                        {
                            Console.WriteLine("Bairro deve conter pelo menos 4 carácteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Por favor informe o Bairro novamente, utilizando apenas letras ");
                    }
                }


                validaCep = true;
                while (validaCep == true)
                {
                    try
                    {
                        Console.Write("CEP: ");
                        ceps[atual] = Convert.ToInt32(Console.ReadLine());
                        if (ceps[atual] > 0)
                        {
                            validaCep = false;
                        }
                        else
                        {
                            Console.WriteLine("Número precisa ser maior que 0 ");
                        }
                       
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Por favor informe CEP novamente, utilizando apenas números ");
                    }
                }

                validaQuantidadeFuncionario = true;
                while (validaQuantidadeFuncionario == true)
                {
                    try
                    {
                        Console.Write("Quantidade de Funcionários: ");
                        quantidadeFuncionarios[atual] = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeFuncionarios[atual] > 0)
                        {
                            validaQuantidadeFuncionario = false;

                        }
                        else
                        {
                            Console.WriteLine("Quantidade de Funcionários precisa ser maior que 0 ");
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Por favor informe Quantidade de Funcionários novamente, utilizando apenas números inteiros ");
                    }
                }
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

        public void VoltarMenuJuridico()
        {
            Console.Clear();
        }
    }
}
