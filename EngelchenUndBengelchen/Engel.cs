using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngelchenUndBengelchen
{
    class Engel :GameObject
    {
        public Engel(MainWindow mw) :base("engel.png", mw)
        {
            itemScore = -20;
        }

        protected override void UpdateCounter()
        {
            mw.countE--;
        }

    }
}
