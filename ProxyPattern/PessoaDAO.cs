using System;

namespace ProxyPattern
{
    public class PessoaDAO
    {
        public static IPessoa getPessoaByID(string id)
        {
            Console.WriteLine("select * from PESSOA where id=" + id);
            return new PessoaImpl(id, "Pessoa " + id);
        }
    }
}
