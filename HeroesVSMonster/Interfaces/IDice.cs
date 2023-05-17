using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Interfaces
{
    public interface IDice
    {
        #region Props
        public int Minimum { get; }
        public int Maximum { get; }

        #endregion



        public int LanceDes()
        {
            Random RngDes = new Random();
            return RngDes.Next(Minimum, Maximum + 1);
        }
        public IEnumerable<int> LancerMultiple(int nbDes);

    }
}
