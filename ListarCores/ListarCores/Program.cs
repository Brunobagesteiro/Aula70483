using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarCores
{
    class Program
    {
        static List<string> ListarCores = new List<string>();

        static void Main(string[] args)
        {
            MensagemInicial();

            var menuEscolhido = "0";

            while (menuEscolhido != "2") 
            {
                menuEscolhido = MostrarMenu();

                switch (menuEscolhido)
                {
                    case "1":
                        RegistrarCor();
                        break;
                    case "2":
                        ListarCor();
                        break;

                    default:
                        Console.WriteLine("Menu Inválido");
                        Console.ReadKey(true);
                        break;
                }

                Console.Clear();


            }

            Console.ReadKey(true);

        }
        static void MensagemInicial()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**MensagemInicial**");
            Console.WriteLine("***********************");
        }

        static void ListarCor()
        {
            Console.WriteLine("Listagem de cores Selecionado");

            ListarCores.ForEach(x => Console.WriteLine($"Cores: {x}"));

            Console.WriteLine("Listagem  de Cores finalizados.");
            Console.ReadKey(true);
        }

        static void RegistrarCor()
        {
            Console.WriteLine("Registro de Cores Selecionado");
            Console.WriteLine("Informe uma Cor");
            var nomeInformado = Console.ReadLine();

            ListarCores.Add(nomeInformado);

            Console.WriteLine("Cor informado com sucesso!");
            Console.ReadKey(true);
        }

        static string MostrarMenu()
        {
            Console.WriteLine("Digite o numero para opção desejada");
            Console.WriteLine("1 - Registrar Cor");
            Console.WriteLine("2 - Listar Cor");
           

            return Console.ReadLine();
        }

        
    
    }
}
