using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class MenuFuncionarios
    {
        string[] nomeFuncionario = new string[100];
        int[] codigoDeAcesso = new int[100];
        string[] SetorQueTrabalha = new string[100];
        string[] TurnoQueTrabalha = new string[100];
        int atual = 0;
        double somaDosCodigos = 0, mediadoscodigos = 0;
        string maiorNome = "", menorNome = "KKKKKKKKKKKKKKKKKKKKKKKKKKJJJJJJJJKKKKKKKKKKKKKKKK";
        bool validacaoCodigo = true;
        public void CadastroFuncionarios()
        {
            Console.Clear();
            Console.Write("Nome Do Funcionário: ");
            nomeFuncionario[atual] = Console.ReadLine();
            validacaoCodigo = true;
            while (validacaoCodigo == true)
            {
                try
                {
                    Console.Write("Código De Acesso: ");
                    codigoDeAcesso[atual] = Convert.ToInt32(Console.ReadLine());
                    validacaoCodigo = false;

                }
                catch (Exception)
                {
                    
                    Console.WriteLine("Digite novamente o codigo Por Favor");
                    


                }
            }
            Console.Write("Setor Que Trabalha: ");
            SetorQueTrabalha[atual] = Console.ReadLine();
            Console.Write("Turno Que Trabalha : ");
            TurnoQueTrabalha[atual] = Console.ReadLine();
            atual++;
        }
        public void ListarFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("Lista Funcionário ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nNome Funcionário: {0} \nCódigo De Acesso: {1} \nSetor Que Trabalha: {2} \nTurno Que Trabalha: {3}",
                       nomeFuncionario[i], codigoDeAcesso[i], SetorQueTrabalha[i], TurnoQueTrabalha[i])
                        
                    );
            }
        }

        internal void NomeBuscarFuncionario()
        {
            Console.WriteLine("Digite o nome para busca: ");
            string nomeBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == nomeFuncionario[i])
                {
                    Console.WriteLine(
                        String.Format(
                       "\nNome Funcionário: {0} \nCódigo De Acesso: {1} \nSetor Que Trabalha: {2} \nTurno Que Trabalha: {3}",
                       nomeFuncionario[i], codigoDeAcesso[i], SetorQueTrabalha[i], TurnoQueTrabalha[i]
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
        public void EditarFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para pesquisa");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == nomeFuncionario[i])
                {
                    posicao = i;
                }
            }

            if (posicao != -1)
            {
                
            Console.Clear();
            Console.Write("Nome Funcionário: ");
            nomeFuncionario[atual] = Console.ReadLine();
                validacaoCodigo = true;
                while (validacaoCodigo == true)
                {
                    try
                    {
                        Console.Write("Código De Acesso: ");
                        codigoDeAcesso[atual] = Convert.ToInt32(Console.ReadLine());
                        validacaoCodigo = false;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Digite novamente o código por favor"); 
                    }
                }
            
            Console.Write("Setor Que Trabalha: ");
            SetorQueTrabalha[atual] = Console.ReadLine();
            Console.Write("Turno Que Trabalha : ");
            TurnoQueTrabalha[atual] = Console.ReadLine();
            Console.WriteLine("Dados alterados com sucesso");
            }
            else
            {
                Console.WriteLine("Registro não encontrado");
                
            }
        }

        public void SomaDosCodigos()
        {
            Console.Clear();


            for (int i = 0; i < codigoDeAcesso.Length; i++)
            {
                somaDosCodigos = codigoDeAcesso[i] + somaDosCodigos;
            }

            Console.WriteLine("Soma dos codigos de acesso do funcionario: " + somaDosCodigos);


        }

        public void MediaCodigoDeAcesso()
        {
            for (int i = 0; i < codigoDeAcesso.Length; i++)
            {
                 mediadoscodigos = somaDosCodigos / atual;
            }

            Console.WriteLine("Média das idades: " + mediadoscodigos);
        }

        public void MaiorNome()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomeFuncionario[i].Length > maiorNome.Length)
                {
                    maiorNome = nomeFuncionario[i];
                }
            }

            Console.WriteLine("Funcionario com maior nome: " + maiorNome);
        }

        public void MenorNome()
        {
            for (int i = 0; i < atual; i++)
            {
                if (nomeFuncionario[i].Length < menorNome.Length)
                {
                    menorNome = nomeFuncionario[i];
                }
            }

            Console.WriteLine("Funcionario com menor nome: " + menorNome);
        }
    }
}
 
    