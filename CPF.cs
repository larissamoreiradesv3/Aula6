namespace Aula6
{
    public class CPF : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public bool ValidarCpf(){
            if(Cpf ! == ""){
                return true;
            }
            return false;
        }
    }
}