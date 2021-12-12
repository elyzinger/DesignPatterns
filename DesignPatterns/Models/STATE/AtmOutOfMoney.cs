using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.STATE
{
    class AtmOutOfMoney : AtmState
    {
        AtmMachine atmMachine;

        public AtmOutOfMoney(AtmMachine newAtmMachine)
        {
            atmMachine = newAtmMachine;
        }
        public void EjectCard()
        {
            Console.WriteLine("Machine Dont Have Money");
        }

        public void InsertCard()
        {
            Console.WriteLine("Machine Dont Have Money");
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("Machine Dont Have Money");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Machine Dont Have Money");
        }
    }
}
