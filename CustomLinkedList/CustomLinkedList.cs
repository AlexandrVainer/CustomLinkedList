using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomLinkedList
{
    public class CustomLinkedList<T>
    {
        public Node<T>? First { get; private set; }
        public Node<T>? Last;
        private Node<T>? Current;
        private Node<T>? prev;

        public CustomLinkedList(){}
        public void Add(T str)
        {
            Last = new Node<T>();
            Last.NodeValue = str;
            Last.NextNode = null;
            Last.PreviousNode = prev;

            if (prev == null)
                First = Last;
            else
                SetNextNodeInBeforeNode(Last);

            prev = Last;

        }
        private void SetNextNodeInBeforeNode(Node<T> last)
        {
            Current = First;
            while (Current.NextNode != null)
            {
                Current = Current.NextNode;
            }

            Current.NextNode = last;
        }

        public IEnumerator GetEnumerator()
        {
            Current = First;

            while (Current != null)
            {
                yield return Current.NodeValue;
                Current = Current.NextNode;
            }
        }

        public IEnumerable GetEnumerableDESC()
        {
            Current = Last;

            while (Current != null)
            {
                yield return Current.NodeValue;
                Current = Current.PreviousNode;
            }
        }
    }

}
