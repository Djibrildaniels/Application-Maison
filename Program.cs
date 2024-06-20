// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Application_Maison
{
  internal class Program
  {
    static void Main(string[] args)
    {

      Character character1 = new Character("Edouard", 200, 50, 100);
      Character character2 = new Character("Julio",200,30,100);

      character1.Afficher();
      character2.Afficher();


      while (character1.IsAlive && character2.IsAlive)
      {
        if (character1.IsAlive)
        {
          character1.Attaquer(character2);
        

        }

       if (character2.IsAlive)
        {
          character2.Attaquer(character1);
        }

      
      }

      if (!character1.IsAlive)
      {
        Console.WriteLine( character2._nom + " a gagné le combat. ");
      }
      if (!character2.IsAlive)
      {
        Console.WriteLine(character1._nom + " a gagné le combat. " );
      }

      

     

      

     
    }
  }
}