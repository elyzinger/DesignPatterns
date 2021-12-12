using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.STATE
{
    class HasPin : AtmState
    {
        AtmMachine atmMachine;

        public HasPin(AtmMachine newAtmMachine)
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
            Console.WriteLine("Already Enter Pin");
        }

        public void RequestCash(int cashToWithdraw)
        {
            if(cashToWithdraw <= atmMachine.CashInMachine && cashToWithdraw > 0)
            {
                Console.WriteLine($"Amount {cashToWithdraw} Was Drawn From The Account");
                atmMachine.CashInMachine -= cashToWithdraw;
                Console.WriteLine("Card Ejected");
                atmMachine.AtmState = atmMachine.NoCard;
            }
            else
            {
                Console.WriteLine("Dont have That Amount Of Cash");
                Console.WriteLine("Card Ejected");
                atmMachine.AtmState = atmMachine.NoCard;
                if (atmMachine.CashInMachine == 0) atmMachine.AtmState = atmMachine.AtmOutOfMoney;
            }
        }
    }
}
