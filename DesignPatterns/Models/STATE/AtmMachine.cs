using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.STATE
{
    class AtmMachine
    {
        AtmState hasCard;
        AtmState noCard;
        AtmState hasPin;
        AtmState atmOutOfMoney;
        int cashInMachine = 2000;
       public bool CorrentPinEnterd = false;

        private AtmState atmState;
        public AtmState HasCard
        {
            get
            {
                return hasCard;
            }
            set
            {
                hasCard = value;
            }
        }
        public AtmState NoCard
        {
            get
            {
                return noCard;
            }
            set
            {
                noCard = value;
            }
        }
        public AtmState HasPin
        {
            get
            {
                return hasPin;
            }
            set
            {
                hasPin = value;
            }
        }
        public AtmState AtmOutOfMoney
        {
            get
            {
                return atmOutOfMoney;
            }
            set
            {
                atmOutOfMoney = value;
            }
        }
        public AtmState AtmState 
        {
            get
            {
                return atmState;
            }
            set 
            {
                atmState = value ;
            } 
        }
        public int CashInMachine
        {
            get
            {
                return cashInMachine;
            }
            set
            {
                cashInMachine = value;
            }
        }

        public AtmMachine()
        {
            HasCard = new HasCard(this);
            HasPin = new HasPin(this);
            NoCard = new NoCard(this);
            AtmOutOfMoney = new AtmOutOfMoney(this);

            AtmState = NoCard;

            if(CashInMachine <= 0 )
            {
                AtmState = atmOutOfMoney;
            }
        }

        public void insertCard()
        {
            AtmState.InsertCard();
        }
        public void EjectCard()
        {
            AtmState.EjectCard();
        }
        public void RequestCash(int cashToWithdraw)
        {
            AtmState.RequestCash(cashToWithdraw);
        }
        public void InsertPin(int pin)
        {
            AtmState.InsertPin(pin);
        }
    }
}
