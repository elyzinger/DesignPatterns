using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Iterator
{
    interface InventoryItrator
    {
        bool IsDone();
        void Next();
        Item Current();
    }
    class HandHeldItrator : InventoryItrator
    {
        HandHeldInventroy hendHeldInventory;
        int index = 0;
        public HandHeldItrator(HandHeldInventroy newHandHeldInventory)
        {
            hendHeldInventory = newHandHeldInventory;
        }
        public Item Current()
        {
            if(index == 0)
            {
                return hendHeldInventory.Right;
            }
            else if(index == 1)
            {
                return hendHeldInventory.Left;
            }
            else
            {
                return null;
            }
        }

        public bool IsDone()
        {
            return index > 2;
        }

        public void Next()
        {
            index++;
        }
    }
    class BegIterator : InventoryItrator
    {
        
        HandleBagInventory begInventory;
        int Index = 0;
        public BegIterator(HandleBagInventory newBegInventory)
        {
            begInventory = newBegInventory;
        }

        public Item Current()
        {
            if(begInventory.Items[Index] != null)
            {
                return begInventory.Items[Index];
            }
            else
            {
                return null;
            }
        }

        public bool IsDone()
        {
            return Index >= begInventory.Items.Length;
        }

        public void Next()
        {
            Index++;
        }
    }
}
