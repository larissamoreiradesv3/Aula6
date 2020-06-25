using System;

namespace Aula6
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Saudar(){
            return "Seja Bem-Vinda" +Nome;
        }
    }
}