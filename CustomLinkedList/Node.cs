using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node<T>
    {
        public Node<T> PreviousNode { get; set; }
        public Node<T> NextNode { get; set; }
        public T NodeValue { get; set; }

    }

    public class Node{}
}
