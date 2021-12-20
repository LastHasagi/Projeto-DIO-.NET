// See https://aka.ms/new-console-template for more information
using System;

namespace Projeto_DIO_Dotnet
{  

    class program
    {
        static void Main(string[] args)
        {
            int numerodevezes = 5;
    
            for (int i=0; i < numerodevezes; i++)
            {
                Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
            }
        }
    }
}