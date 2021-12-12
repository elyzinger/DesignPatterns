using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class EnemyShedow
    {
        Random rnd = new Random();
        public void ShedowAttack()
        {
            int damage = rnd.Next(10, 20);
            Console.WriteLine($"EnemyShedow Dowes:{damage} Damage.");
        }
        public void ShedowName(string name)
        {
            Console.WriteLine($"Enemy Shedow Name is {name}.");
        }
        public void ShedowWalk()
        {
            int move = rnd.Next(2, 8);
            Console.WriteLine($"Enemy Shedow Walk {move} Spaces");
        }
    }
}
