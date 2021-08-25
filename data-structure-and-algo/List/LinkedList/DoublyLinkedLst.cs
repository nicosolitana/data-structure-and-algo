using data_structure_and_algo.List.NodeDefinition;
using System;

namespace data_structure_and_algo.List.LinkedList
{
    class DoublyLinkedLst
    {
        private Node head;
        private Node tail;

        public void insertTail(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.nextNode = newNode;
                tail = newNode;
            }
        }


        public void display()
        {
            string data = string.Empty;
            Node current = this.head;

            while (current != null)
            {
                data += (current.Data.ToString() + ", ");
                current = current.nextNode;
            }
            Console.WriteLine(data);
        }
    }
}
