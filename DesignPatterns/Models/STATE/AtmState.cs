using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.STATE
{
    interface AtmState
    {
        void InsertCard();
        void EjectCard();
        void InsertPin(int pin);
        void RequestCash(int cashToWithdraw);
    }
}
