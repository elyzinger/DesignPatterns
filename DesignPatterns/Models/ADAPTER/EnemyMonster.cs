using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
   public class EnemyMonster : EnemyIntrface
    {
        Random rnd = new Random();
        public void Attck()
        {
            int damage = rnd.Next(1, 10);
            Console.WriteLine($"Enemy Monster Does: {damage} Damage.");
        }

        public void EnemyName(string name)
        {
            Console.WriteLine($"Enemy Monster Name Is {name}.");
        }

        public void Walk()
        {
            int move = rnd.Next(1, 5);
            Console.WriteLine($"Enemy Monster Moves: {move} Spaces.");
        }
    }
}
