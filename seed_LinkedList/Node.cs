using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seed_LinkedList
{
    class Node
    {
        public string data;
        public Node next;
        public Node(string dataIn)
        {
            data = dataIn;
            next = null;
        }
    }
}
