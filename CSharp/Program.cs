using System;
using System.Collections.Generic;
using System.Text;
using CSharp;
using Interface;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Magno";
            person.Idade = 54;
            person.Estado = "SP";

            Animal animal = new Animal();
            animal.Nome = "Rex";
            animal.Dono = "Magno";
            animal.Especie = "Cachorro";
          
            Console.WriteLine("Hello World!");
        }
    }
}
