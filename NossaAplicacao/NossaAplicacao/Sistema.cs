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
5 - Sair");
        }
        public void GeriMenu()
        {

            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            while (menuEscolha != 5)
            {
                switch (menuEscolha)
                {
                    case 1:
                        cadastroDePessoasFisica.CadastroDePessoas();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
           }
         }









      }
   }

