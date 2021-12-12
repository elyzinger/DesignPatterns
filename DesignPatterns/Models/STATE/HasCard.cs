using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.STATE
{
    class HasCard : AtmState
    {
        AtmMachine atmMachine;

        public HasCard(AtmMachine newAtmMachine)
        {
            atmMachine = newAtmMachine;
        }
        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            atmMachine.AtmState = atmMachine.NoCard;
        }

        public void InsertCard()
        {
            Console.WriteLine("You Can't Enter More Than One Card");
        }

        public void InsertPin(int pin)
        {

            if(pin == 1234)
            {
                Console.WriteLine("Currect Pin Was Enter");
                atmMachine.CorrentPinEnterd = true;
                atmMachine.AtmState = atmMachine.HasPin;
            }
            else
            {
                Console.WriteLine("Wrong Pin!");
                atmMachine.CorrentPinEnterd = false;
                Console.WriteLine("Card Ejected");
                atmMachine.AtmState = atmMachine.NoCard;
            }
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter Pin First");
        }
    }
}
