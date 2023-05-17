using HeroesVSMonster.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    public class Dés : IDice
    {
        #region Props
        public int Minimum { get; init; }
        public int Maximum { get; init; }


        #endregion

        #region Constructeurs

        public Dés(int minimum, int maximum)
        {
            Maximum = maximum;
            Minimum = minimum;
        }
        #endregion

        #region Méthode
        public int LanceDes()
        {
            Random RngDes = new Random();
            return RngDes.Next(Minimum, Maximum + 1);
        }


        public IEnumerable<int> LancerMultiple(int nbDes)
        {
            List<int> deslist = new List<int>(); for (int i = 0; i <= nbDes; i++) { deslist.Add(Random.Shared.Next(Minimum, Maximum)); }
            return deslist;

        }
        #endregion
    }

}
        // Suggestion de Chris

        //public class Dice : IDice
        //{
        //    private int _Minimum { get; } private int _Maximum { get; }
        //    public Dice(int minimum, int maximum) { _Minimum = minimum; _Maximum = maximum; }
        //    public int Throw() { return new Random().Next(_Minimum, _Maximum); }
        //    public IEnumerable<int> Throw(int nbDice) { List<int> dicesList = new List<int>(); for (int i = 0; i <= nbDice; i++) { dicesList.Add(Random.Shared.Next(_Minimum, _Maximum)); } return dicesList; } }
        //}   
        //interface
        //public interface IDice { public int Throw(); public IEnumerable<int> Throw(int nbDice); 
