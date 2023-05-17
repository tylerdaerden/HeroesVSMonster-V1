using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace HeroesVSMonster.Interfaces
{
    public interface IPersonnage_Base
    {
        public int Endurance { get; }
        public int Force { get; }
        public int PV { get; }


        public string frappe()
        {
            //à implémenter

            //Les personnages ont une action Frappe. Lorsqu’un personnage frappe sur un autre, les dégâts sont déterminés par le jet d’un dé à 4 faces auquel on ajoute un modificateur1 basé sur la caractéristique de Force. Une fois calculé, les dégâts sont retirés des points de vies de la cible.
            return "frappe";
        }

    }

   
}
