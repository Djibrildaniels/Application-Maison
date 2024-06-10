// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
      static string demander_nom()
      // static string "demander_nom"  
      {


        string nom = "";
            while (nom == "")
            {
            
            Console.WriteLine("Quel est votre nom? ");
            nom = Console.ReadLine();
            nom = nom.Trim();

        

            if (nom == "")
            {

            System.Console.WriteLine("Le nom ne doit pas être vide. "); 


            }





            }
            return nom;

      }


        static void Main(string[] args)
        {


           string nom = demander_nom();

            
        
          

          




int age_num = 0;

      while (age_num <=0)
      /* Pour une boucle while, il faut deja mentionner le  "int" avec sa valeur. 
Donc ex : int i = 0;
Ensuite il faut creer le while + la valeur {} sans mettre le ; 
Ex: while i == 0 (cela veut dire que i est égal à 0)
i < 0 (Cela veut dire que i est inferieur à 0)
Mais une fois qu'on a mit le console.Writeline("") on peut rajouter la valeur de i en l'additionnant au chiffre que l'on souhaite sur la boucle(jme comprends :))

Ex: Console Writeline(" Valeur de i = " + i)
i = i+2; (j'ai mit 2 mais on peut mettre n'importe quel chiffre cela depend de la boucle que tu veux mettre en place)
 */

      {
          Console.WriteLine(" Quel age avez-vous ? ");
          string age_str = Console.ReadLine();


          try
          {
            
          age_num = int.Parse(age_str);
        /* Pour transformer un string en int, utiliser toujours int.Parse(Le nom du string que tu as donner 
        Ex: string ballon_str
        Si on veut le transformer en chiffre entier on codera:
        int ballon_num = int.parse(ballon_str); */
      
        if (age_num < 0)
        {
            Console.WriteLine("Erreur, l'age ne doit pas etre negatif");

        }
        if (age_num == 0)
         {
          
          System.Console.WriteLine("L'age ne doit pas etre egal à 0.");

        }
        
}
catch (System.Exception)
{
  Console.WriteLine("Erreur, veuillez taper un age valide. ");

}         

        
      
      }
    

    Console.WriteLine("Vous vous appelez " + nom + " et vous avez " + age_num + " ans. ");
        int age_pro = age_num +1;
        Console.WriteLine("L'année prochaine vous aurez " + age_pro + " ans. ") ;
       
    


        


         






        }
    }
}
