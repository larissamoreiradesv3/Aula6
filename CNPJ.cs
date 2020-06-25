namespace Aula6
{
    public class CNPJ : Pessoa
    {
        public string Cnpj { get; set; }
        public bool ValidarCnpj(){
            if( Cnpj != ""){
                return true;
            }
            return false;
        }
    }
}