using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Maison
{
    public class Character
    {
        public string _nom;
    int _pointDeVie;
    public int Attack { get; set; }
    public int Defense { get; set; }
    public bool IsAlive { get { return _pointDeVie>0;}  }

    public Character(string nomParam, int pointDeVieParam, int attack, int defenseParam)
    {
      _nom = nomParam;
      _pointDeVie = pointDeVieParam;
      Attack = attack;
      Defense = defenseParam;

    }

    public void Afficher ()
    {

      Console.WriteLine("Nom du personnage : " + _nom);
      Console.WriteLine("   Point de vie : " + Defense);
      Console.WriteLine("   Defense : "+ Defense);
      Console.WriteLine("   Attaque : " + Attack);
      Console.WriteLine("");

      



    }

    public void Attaquer(Character character)
    {
      _pointDeVie -= Attack;
      
      character._pointDeVie = (character._pointDeVie) - (Attack - character.Defense) ;

      if (_pointDeVie < 0){

        Console.WriteLine("Vous ne pouvez plus attaquer. ");
      }

    }

  }
    }