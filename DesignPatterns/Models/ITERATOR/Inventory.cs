using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Iterator
{
    interface Inventory
    {
        InventoryItrator GetIterator();
    }
    class HandHeldInventroy : Inventory
    {
        public Item Right { get; set; }
        public Item Left { get; set; }

        public HandHeldInventroy(Item right, Item left)
        {
            Right = right;
            Left = left;
        }

        public InventoryItrator GetIterator()
        {
            return new HandHeldItrator(this);
        }
    }
     class HandleBagInventory : Inventory
    {
        private Item[] items = new Item[10];
        public Item[] Items { get 
            {
                return items;
            }
            private set
            {
                value = items;
            }
        }

        public void AddItem(Item item)
        {
           
            for(int i = 0; i<items.Length; i++)
            {
                if(items[i] == null)
                {
                    items[i] = item;
                    break;
                }
               
            }
           
        }

        public InventoryItrator GetIterator()
        {
            return new BegIterator(this);
        }
    }
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemPower { get; set; }
        public Item(string itemName, string itemPower)
        {
            ItemName = itemName;
            ItemPower = itemPower;
        }

        public override string ToString()
        {
            return $"item name {ItemName}, item power {ItemPower} ";
        }
    }
}
