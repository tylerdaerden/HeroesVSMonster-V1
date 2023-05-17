using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Interfaces
{
    public interface IDice // à voir si je garde
    {
        #region Props
        public int Maximum { get; }

        #endregion



        public int LanceDes()
        {
            return Random.Shared.Next(Maximum) + 1;
        }
        public IEnumerable<int> LancerMultiple(int nbDes);

    }
}
