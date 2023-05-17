using HeroesVSMonster.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    public class Héros : Personnage_Base
    {
        #region Props

        public int Endurance { get; init; }
        public int Force { get; init; }
        public int PV { get; init; }
        public Race Race { get; init; }

        #endregion

        #region Constructeurs

        public Héros() // mis 0 de manière temp pour avancer
        {
            Endurance =0;
            Force =0;
            PV = 0;
        }
        #endregion


        #region Méthodes





        #endregion
    }
}
