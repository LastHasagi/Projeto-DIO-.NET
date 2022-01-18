using System;

//ABSTRAÇÃO

namespace ExemplosPOO.Models
{
    public class Pessoa
    {
        public string nome {get; set;}

        public int idade {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }

        
    }
}

