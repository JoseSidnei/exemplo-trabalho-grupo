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
            nomesEmpresa[atual] = Console.ReadLine();
            Console.Write("Telefone para contato: ");
            telefones[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            emails[atual] = Console.ReadLine();
            Console.Write("Cidade: ");
            cidades[atual] = Console.ReadLine();
            Console.Write("Ebdereço: ");
            enderecos[atual] = Console.ReadLine();
            Console.Write("Nº: ");
            numeros[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bairro: ");
            bairros[atual] = Console.ReadLine();
            Console.Write("CEP: ");
            ceps[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de funcionarios: ");
            quantidadeFuncionarios[atual] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Horário para entrega: ");
            horariosEntrega[atual] = Convert.ToDouble(Console.ReadLine());
    }
}
