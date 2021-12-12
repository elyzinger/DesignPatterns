using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
   public class EnemyShedowAdapter : EnemyIntrface
    {
        EnemyShedow shedow = new EnemyShedow();

        public EnemyShedowAdapter(EnemyShedow enemyShedow)
        {
            shedow = enemyShedow;
        }
        public void Attck()
        {
            shedow.ShedowAttack();
        }

        public void EnemyName(string name)
        {
            shedow.ShedowName(name);
        }

        public void Walk()
        {
            shedow.ShedowWalk();
        }
    }
}
