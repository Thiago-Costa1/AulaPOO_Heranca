namespace POO_Heranca.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;
        
        public bool  ValidarCPF(string documento)
         {
            if(documento != "" && documento.Length > 10){
                

            return true;
            }
            return false;
    }
         
    }
}