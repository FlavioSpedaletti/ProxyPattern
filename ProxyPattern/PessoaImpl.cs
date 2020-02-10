using System;

namespace ProxyPattern
{
    public class PessoaImpl : IPessoa
    {
        private string nome;
        private string id;

        public PessoaImpl(string id, string nome)
        {
            this.id = id;
            this.nome = nome;
            // apenas para simular algo...
            Console.WriteLine("Retornou a pessoa do banco de dados ->  " + nome);
        }

        public string GetId()
        {
            return this.id;
        }

        public string GetNome()
        {
            return this.nome;
        }
    }
}
