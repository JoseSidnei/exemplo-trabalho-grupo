using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class CadastroPessoaJuridica
    {
        string[] nomesEmpresa = new string[100];
        int[] telefones = new int[100];
        string[] emails = new string[100];
        string[] cidades = new string[100];
        string[] enderecos = new string[100];
        int[] numeros = new int[100];
        string[] bairros = new string[100];
        int[] ceps = new int[100];
        int[] quantidadeFuncionarios = new int[100];
        double[] horariosEntrega = new double[100];
        int atual = 0;

        public void CadastroPessoaJuridica()
        {
            Console.Clear();
            Console.Write("Nome da empresa: ");
            nomesEmpresa[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Telefone para contato: ");
            telefones[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            emails[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Ebdereço: ");
            enderecos[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Cidade: ");
            cidades[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Nº: ");
            numeros[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bairro: ");
            bairros[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("CEP: ");
            ceps[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de Funcionários: ");
            quantidadeFuncionarios[atual] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Horário para entrega: ");
            horariosEntrega[atual] = Convert.ToDouble(Console.ReadLine());
        }

        public void ListarPessoaJuridica()
        {
            Console.Clear();
            Console.WriteLine("Lista de pessoas Jurídicas cadastradas ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nNome da Empresa:: {0} \nTelefone para Contato: {1} \nEmail: {2} \nEndereço: {3} \nCidade: {4} \nN°: {5}" +  
                       "\nBairro: {6} \nCEP: {7} \nQuantidade de Funcionários: {8} \nHorário para Entrega: {8}",
                       nomesEmpresa[i], telefones[i], emails[i], enderecos[i], cidades[i], numeros[i], numeros[i], bairros[i], ceps[i],
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
                             "\nNome da Empresa:: {0} \nTelefone para Contato: {1} \nEmail: {2} \nEndereço: {3} \nCidade: {4} \nN°: {5}" +
                       "\nBairro: {6} \nCEP: {7} \nQuantidade de Funcionários: {8} \nHorário para Entrega: {8}",
                       nomesEmpresa[i], telefones[i], emails[i], enderecos[i], cidades[i], numeros[i], numeros[i], bairros[i], ceps[i],
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
    }
}
