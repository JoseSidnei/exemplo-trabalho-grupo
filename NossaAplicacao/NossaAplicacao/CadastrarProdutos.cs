using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class CadastrarProdutos
    {
        
        string[] tipos = new string[100];
        string[] nomes = new string[100];
        int[] quantidadeProdutos = new int[100];
        string[] validade = new string[100];
        double[] valores = new double[100];
        int atual = 0;

        public void CadastrarProdutos()
        {
            Console.Write("Tipo: ");
            tipos[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Nome do Produto: ");
            nomes[atual] = Console.ReadLine().ToLower().Trim();
            Console.Write("Quantidade de Produtos: ");
            quantidadeProdutos[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Validade: ");
            validade[atual] = Console.ReadLine();
            Console.Write("Valor: ");
            valores[atual] = Convert.ToDouble(Console.ReadLine());
            

        } 
    }
}
