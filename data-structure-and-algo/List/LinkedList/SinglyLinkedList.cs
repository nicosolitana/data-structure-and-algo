using data_structure_and_algo.List.NodeDefinition;
using System;

namespace data_structure_and_algo.List.LinkedList
{
    class SinglyLinkedLst
    {
        private Node head;

        public void insert(int data)
        {
            Node newNode = new Node(data);
            newNode.nextNode = head;
            head = newNode;
        }

        public int length()
        {
            int count = 0;
            Node current = this.head;

            while (current != null)
            {
                count++;
                current = current.nextNode;
            }
            return count;
        }

        public int search(int data)
        {
            int count = 0;
            Node current = this.head;

            while (current != null)
            {
                if (current.Data == data)
                    return count;
                count++;
                current = current.nextNode;
            }
            return -1;
        }


        public void delete()
        {
            head = head.nextNode;
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
