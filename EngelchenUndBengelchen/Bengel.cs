using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngelchenUndBengelchen
{
    class Bengel : GameObject
    {
        public Bengel (MainWindow mw) : base ( "bengel.png",mw)
        {
            itemScore = 30;
         }

        protected override void UpdateCounter()
        {
            mw.countB--;
        }
    }
}
