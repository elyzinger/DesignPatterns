using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.STATE
{
    class NoCard : AtmState
    {
        AtmMachine atmMachine;

        public NoCard(AtmMachine newAtmMachine)
        {
            atmMachine = newAtmMachine;
        }
        public void EjectCard()
        {
            Console.WriteLine("Insert A Card First");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please Enter Pin");
            atmMachine.AtmState = atmMachine.HasCard;
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("First Insert A Card");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("First Insert A Card");
        }
    }
}
