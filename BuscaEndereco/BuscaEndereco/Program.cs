using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaEndereco
{
    using servCEP;

    class Program
    {
        static void Main(string[] args)
        {
            var cep = Console.ReadLine();

            if (!string.IsNullOrEmpty(cep))
            {
                consultarCEP(cep);
            }
        }
        private static void consultarCEP (string cep)
        {
            using(var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);
                Console.Clear();
                Console.WriteLine(String.Format("Endereço: {0}", resposta.end));
                Console.WriteLine(String.Format("Bairro: {0}", resposta.bairro));
                Console.WriteLine(String.Format("Cidade: {0}", resposta.cidade));
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
