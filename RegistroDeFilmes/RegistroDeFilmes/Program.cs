using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeFilmes
{
    class Program
    {
        static List<string> listaDeFilmes = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**SISTEMA DE REGISTRO**");
            Console.WriteLine("***********************");

            var menuEscolhido = "0";

            while (menuEscolhido != "3")
            {
                Console.WriteLine("Digite o numero para opção desejada");
                Console.WriteLine("1 - Registrar nome de filme");
                Console.WriteLine("2 - Listar Filmes");
                Console.WriteLine("3 - Sair do Sistema");

                menuEscolhido = Console.ReadLine();

                switch (menuEscolhido)
                {
                    case "1":
                        Console.WriteLine("Registro de Filme Selecionado");
                        Console.WriteLine("Informe um Filme");
                        var nomeInformado = Console.ReadLine();

                        listaDeFilmes.Add(nomeInformado);

                        Console.WriteLine("Filme informado com sucesso!");
                        Console.ReadKey(true);
                        break;
                    case "2":
                        Console.WriteLine("Listagem de Filme Selecionado");

                        listaDeFilmes.ForEach(x => Console.WriteLine($"Filme: {x}"));

                        Console.WriteLine("Listagem  de Filmes finalizados.");

                        Console.ReadKey(true);
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
    }
}
