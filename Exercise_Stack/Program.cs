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
            

        }
        
    }
}
