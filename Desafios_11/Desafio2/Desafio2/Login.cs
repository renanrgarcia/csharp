namespace Desafio2
{
    internal class Login
    {
        public string Senha { get; private set; }

        public Login(string senha)
        {
            Senha = senha;
        }

        public bool TesteSenha(string senha)
        {
            senha = senha.ToUpper();
            if (senha == "SENHA")
                return true;
            else
                return false;
        }            
    }
}
