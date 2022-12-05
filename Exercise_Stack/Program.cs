using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Stack
{
    class node
    {
        public int info;
        public node next;
        public node prev;
        

        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
    class Stack
    {
        public char[] adit = new char[60];

        node top;

        public Stack()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(char element)
        {
            node baru;
            baru = new node(element, null);


            baru.next = top;
            top = baru;
            for (int i = 0; i < adit.Length; i++)
            {
                adit[i] = element;
            }
            Console.WriteLine("\n" + element + "Pushed");

        }
        public void pop()
        {
            Console.WriteLine("\n The Poped Element is: " + top.info);
            top = top.next;
        }
        public void display()
        {

            node tmp;
            if (empty())
                Console.WriteLine("\nStack is empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }
        
    }
}
