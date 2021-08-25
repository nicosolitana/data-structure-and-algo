using data_structure_and_algo.List.NodeDefinition;
using System;

namespace data_structure_and_algo.List.LinkedList
{
    class DoublyLinkedNodeLst
    {
        private DoublyLinkedNode head;

        public void insert(int data)
        {
            DoublyLinkedNode newNode = new DoublyLinkedNode(data);
            newNode.nextNode = head;
            if (head != null)
                head.prevNode = newNode;
            head = newNode;
        }

        public int length()
        {
            int length = 0;
            if (head == null)
                return length;

            DoublyLinkedNode current = this.head;

            while (current != null)
            {
                length++;
                current = current.nextNode;
            }
            return length;
        }

        public void display()
        {
            string data = string.Empty;
            DoublyLinkedNode current = head;

            while (current != null)
            {
                data += (current.Data.ToString() + ", ");
                current = current.nextNode;
            }
            Console.WriteLine(data);
        }
    }
}
