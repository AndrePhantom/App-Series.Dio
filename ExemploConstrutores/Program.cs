using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
     class Program
     {
         static void Main (String[] args)
         {
            Pessoa p1 = new Pessoa("André", "Faria"); 
            p1.Apresentar();
         }
     }
}
