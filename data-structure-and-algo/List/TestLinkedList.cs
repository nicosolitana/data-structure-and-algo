using data_structure_and_algo.List.LinkedList;
using System;

namespace data_structure_and_algo.List
{
    class TestLinkedList
    {
        public static void Test()
        {
            Console.WriteLine("\nSingly LinkedList Simulation");
            SinglyLinkedLst lst = new SinglyLinkedLst();
            lst.insert(5);
            lst.insert(4);
            lst.insert(3);
            lst.insert(2);
            lst.insert(1);

            lst.display();
            Console.WriteLine("Length of the list is " + lst.length());

            lst.delete();
            lst.display();

            Console.WriteLine("-5 is on index " + lst.search(-5));
            Console.WriteLine("5 is on index " + lst.search(5));

            Console.WriteLine("\nDoubly LinkedList Simulation");
            DoublyLinkedLst dLst = new DoublyLinkedLst();
            dLst.insertTail(6);
            dLst.insertTail(7);
            dLst.insertTail(8);
            dLst.insertTail(9);
            dLst.insertTail(10);
            dLst.display();

            Console.WriteLine("\nDoubly LinkedNodeList Simulation");
            DoublyLinkedNodeLst dnLst = new DoublyLinkedNodeLst();
            dnLst.insert(11);
            dnLst.insert(12);
            dnLst.insert(13);
            dnLst.insert(14);
            dnLst.insert(15);
            dnLst.display();
            Console.WriteLine("Length of the doubly linkednodelist is " + dnLst.length());
        }
    }
}
