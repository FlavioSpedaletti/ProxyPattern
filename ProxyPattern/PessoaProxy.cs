namespace ProxyPattern
{
    public class PessoaProxy : IPessoa
    {
        private string id;
        private IPessoa pessoa;//mesma interface

        public PessoaProxy(string id)
        {
            this.id = id;
        }
        
        public string GetId()
        {
            return this.id;
        }

        public string GetNome()
        {
            if (pessoa == null)
            {
                //Apenas cria o objeto real quando chamar este método
                pessoa = PessoaDAO.getPessoaByID(this.id);
            }
            /** Delega para o objeto real **/
            return pessoa.GetNome();
        }
    }
}
