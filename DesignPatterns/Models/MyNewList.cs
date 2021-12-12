using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class MyNewList<T> // how to create your own connected list
    {
        
        public Node<T> First { get; private set; }

        public int listCount = 0;
        public void AddItem (T item)
        {
            int index = 0;
            if(First == null)
            {
                First = new Node<T>();
                First.Value = item;
                listCount++; 
            }
            else if(item.GetType() == typeof(int)) // if its a list of numbers
            {
                Node<T> next = First;
                while(listCount >= index)
                {
                    if(Convert.ToInt32(item) > Convert.ToInt32(next.Value))
                    {
                        if(next.Next == null)
                        {
                           
                            next.Next = new Node<T>();
                            next.Next.Prev = next;
                            next.Next.Value = item;                     
                            listCount++;
                            break;
                        }
                        else if( Convert.ToInt32(item) < Convert.ToInt32(next.Next.Value))
                        {
                            T newNode = next.Next.Value;
                            next.Next.Value = item;
                            next.Next.Prev = next;
                            AddItem(newNode);
                            break;
                        }
                        else
                        {
                            next = next.Next;
                            index++;
                        }
                
                    }
                    else if(Convert.ToInt32(item) < Convert.ToInt32(next.Value))
                    {
                        if(next.Prev == null)
                        {
                            next.Prev = new Node<T>();
                            next.Prev.Value = item;
                            next.Prev.Next = next;
                            listCount++;
                            break;
                        }
                        else if(Convert.ToInt32(item) > Convert.ToInt32(next.Prev.Value))
                        {
                            T newNode = next.Prev.Value;
                            next.Prev.Value = item;
                            next.Prev.Next = next;
                            AddItem(newNode);
                            break;
                        }
                        else
                        {
                            next = next.Prev;
                            index++;
                        }
                    
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else // if its a list of string
            {
                if(First == null)
                {
                    First = new Node<T>();
                    First.Value = item;
                    listCount++;
                }
                else
                {
                    Node<T> next = First;
                    index = 0;
                    while(index <= listCount)
                    {
                        if(next.Next == null)
                        {
                            next.Next = new Node<T>();
                            next.Next.Value = item;
                            listCount++;
                            break;
                        }
                        else
                        {
                            next = next.Next;
                            index++;
                        }
                    }
                }
            }
            
        }
        public void Remove(T item)
        {
            Node<T> next = First;
            int index = 0;           
            if(next == null)
            {
                Console.WriteLine($"Item Not Exist {item}");
            }
            else
            {
                while (next.Prev != null)
                {
                    next = next.Prev;
                }
                while (listCount >= index)
                {
                  
                    if(item.GetType() == typeof(int))
                    {
                        if(Convert.ToInt32(item) == Convert.ToInt32(next.Value))
                        {
                            if(next.Next != null && next.Prev != null)
                            {
                                next.Next.Prev = next.Prev;
                                next.Prev.Next = next.Next;
                                next = next.Next;
                                listCount--;
                                break;
                            }
                            else if(next.Next != null)
                            {
                                next.Next.Prev = next.Prev;
                                next = next.Next;
                                listCount--;
                                break;
                            }
                            else if (next.Prev != null)
                            {
                                next.Prev.Next = next.Next;
                                next = next.Prev;
                                listCount--;
                                break;
                            }
                            else
                            {
                                First = null;
                                listCount--;
                                break;
                            }
                      
                        }
                        else
                        {
                            next = next.Next;
                            index++;
                        }
                    }
                    else
                    {
                        if(Convert.ToString(item) == Convert.ToString(next.Value))
                        {
                            if(next.Next != null)
                            {
                                next = next.Next;
                                listCount--;
                                break;
                            }
                            else
                            {
                                next = null;
                                listCount--;
                                break;
                            }
                        }
                        else
                        {
                            next = next.Next;
                            index++;
                        }
                    }
                }

               if(index > listCount) Console.WriteLine($"Item Not Exist:  `{item}`");
            }
        }
        public void ClearList()
        {
            First = null;
            listCount = 0;
        }
        public void LogList()
        {
            if(First == null)
            {
                Console.WriteLine("List Is Empty");
            }
            else
            {
                Node<T> next = First;
                while(next.Prev != null)
                {
                    next = next.Prev;
                }
                
                for(int i=0; i < listCount; i++)
                {
                    Console.WriteLine($"Item Number {i+1} Is: {next.Value}.");
                    next = next.Next;
                }
            }
        }
        public T[] MyListToArray()
        {
            T[] newList = new T[listCount];
            Node<T> next = First;
            if (First != null)
            {
                while (next.Prev != null)
                {
                    next = next.Prev;
                }

                for (int i = 0; i < listCount; i++)
                {
                    if (next != null)
                    {
                        newList[i] = next.Value;
                        next = next.Next;
                    }
                }

                return newList;
            }
            else
            {
                return newList;
            }

        } 
    }
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
        public T Value { get; set; }
    }
}
