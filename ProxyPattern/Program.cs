using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPessoa> pessoas = new List<IPessoa>();

            //Cria cada Proxy para encapsular o acesso a classe "PessoaImpl"
            pessoas.Add(new PessoaProxy("A"));
            pessoas.Add(new PessoaProxy("B"));
            pessoas.Add(new PessoaProxy("C"));

            Console.WriteLine("Nome: " + pessoas[0].GetNome());
            // busca do banco de dados
            Console.WriteLine("Nome: " + pessoas[1].GetNome());
            // busca do banco de dados
            Console.WriteLine("Nome: " + pessoas[0].GetNome());
            // já buscou esta pessoa... apenas retorna do cache...

            // A terceira pessoa nunca será consultada no banco de dados 
            //melhor performance - lazy loading
            Console.WriteLine("Id da 3ª - " + pessoas[2].GetId());
            //pode imprimir o ID do objeto, e o proxy nao será inicializado.
        }
    }
}
