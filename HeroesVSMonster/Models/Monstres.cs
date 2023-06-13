using HeroesVSMonster.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    internal abstract class Monstres : Personnage_Base
    {
        #region Props

        public int Endurance { get; init; }
        public int Force { get; init; }
        public int PV { get; init; }

        #endregion

        #region Constructeurs

        public Monstres()
        {
            Dés d6 = new Dés(6);
            Endurance = CalculStats(d6);
            Force = CalculStats(d6);
            PV = CalculStats(d6);
        }
        #endregion


        #region Méthodes

        int CalculStats(Dés d6)
        {
            List<int> _4D6 = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                int d6Result = d6.LanceDes();
                _4D6.Add(d6Result);
            }

            _4D6.Sort();
            _4D6.RemoveAt(0); // Comme ça je supprime le plus petit résultat

            int best3D6 = _4D6.Sum();

            //Modificateurs à appliquer : 
            // si carac < 5 mod = -1 , si < 10 mod = 0 ,si < 15 mod = +1 , else mod = +2

            if (best3D6 < 5)
            {
                best3D6 -= 1;
            }
            else if (best3D6 > 5 && best3D6 < 10)
            {
                best3D6 += 0;
            }
            else if (best3D6 > 10 && best3D6 < 15)
            {
                best3D6 += 1;
            }
            else
            {
                best3D6 -= 2;
            }
            return best3D6;
        }

        #endregion
    }
}