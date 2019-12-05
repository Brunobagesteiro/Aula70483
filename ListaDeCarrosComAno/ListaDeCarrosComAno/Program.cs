using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarrosComAno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListaDeCarrosComAno = new List<string>
            {
                

                 "corcel 1968",
                 "fusca  1979",
                 "brasilia 1975",
                 "combi 1984",
                 "calhambec 1934"
            };

            ListaDeCarrosComAno.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);

               



        }
    }
}
