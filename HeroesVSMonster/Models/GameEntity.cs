using HeroesVSMonster.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    public abstract class GameEntity : IDice
    {
        #region Props

        public int Endurance { get; init; }
        public int Force { get; init; }
        public int PV { get; init; }

        #endregion

        #region Constructeurs

        public GameEntity(int endurance, int force, int pv)
        {
            //Modificateurs à appliquer : 
            // si carac < 5 mod = -1 , si < 10 mod = 0 ,si < 15 mod = +1 , else mod = +2

            Endurance = endurance;
            Force = force;
            PV = pv;
        }

        #endregion


        #region Méthodes


        public int CalculStats(Dés d6)
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

            if (best3D6 <5 ) 
            {
                best3D6 -= 1;
            }
            else if (best3D6 >5 && best3D6 <10) 
            {
                best3D6 += 0;
            }
            else if(best3D6 >10 && best3D6 <15) 
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

