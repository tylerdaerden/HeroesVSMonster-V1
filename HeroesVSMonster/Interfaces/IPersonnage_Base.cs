using HeroesVSMonster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace HeroesVSMonster.Interfaces
{
     public abstract class Personnage_Base
    {

        private int _baseEnd;
        private int _baseFor;
        public int PV { get; private set; }

        public Race? Race { get; private set; }

        public Personnage_Base()
        {
            _baseEnd = Dés.CalculStats();
            _baseFor = Dés.CalculStats();
            Repos();



        }

        protected void Repos()
        {
            PV = _baseEnd + Modificateur(_baseEnd);            
        }

        private int Modificateur(int end) 
        {
            return (end < 5) ? -1 : (end < 10) ? 0 : (end < 15) ? 1 : 2; 
        }



        public string frappe() // mis en string temporairement!!!
        {
            //à implémenter

            //Les personnages ont une action Frappe. Lorsqu’un personnage frappe sur un autre, les dégâts sont déterminés par le jet d’un dé à 4 faces auquel on ajoute un modificateur1 basé sur la caractéristique de Force. Une fois calculé, les dégâts sont retirés des points de vies de la cible.
            return "frappe";
        }

    }

   
}
