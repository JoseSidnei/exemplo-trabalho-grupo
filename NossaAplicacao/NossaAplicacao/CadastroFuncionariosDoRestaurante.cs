using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicacao
{
    class CadastroFuncionariosDoRestaurante
    {
        string[] nomeFuncionario = new string[100];
        int[] codigoDeAcesso = new int[100];
        string[] SetorQueTrabalha = new string[100];
        string[] TurnoQueTrabalha = new string[100];
        int atual = 0;

        public void CadastroFuncionarios()
        {
            Console.Clear();
            Console.Write("Nome Funcionario: ");
            nomeFuncionario[atual] = Console.ReadLine();
            Console.Write("CodigoDeAcesso: ");
            codigoDeAcesso[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Setor Que Trabalha: ");
            SetorQueTrabalha[atual] = Console.ReadLine();
            Console.Write("Turno Que Trabalha : ");
            TurnoQueTrabalha[atual] = Console.ReadLine();          
            atual++;
        }
    }
}
