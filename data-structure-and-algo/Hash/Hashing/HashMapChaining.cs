using data_structure_and_algo.List.LinkedList;

namespace data_structure_and_algo.Hash.Hashing
{
    class HashMapChaining
    {
        private int HashSize = 10;
        private SinglyLinkedLst[] hashList;

        public void init()
        {
            for (int i=0; i< HashSize; i++)
            {
                hashList[i] = new SinglyLinkedLst();
            }
        }

        private int HashCoding(int data)
        {
            return data % HashSize;
        }

        // Time Complexity is O(1)
        // Since the key is already defined using HashCoding function,
        // you already know which location should the data will be stored.
        // Also, since chaining using linkedlist is used, all new 
        // data are added at a specific position which is the tail
        private void put(int data)
        {
            int hashCode = HashCoding(data);
            hashList[hashCode].insert(data);
        }

        // Time Complexity is O(N)
        // Even though, the exact location of the data is known,
        // since chaining algorithm is used, there's a possibility
        // that the entire data is located in one key
        // worst case is, if the data is at the end of the chain
        // which will involved traversing the list n times.
        private bool search(int data)
        {
            int hashCode = HashCoding(data);
            if (hashList[hashCode].search(data) != -1)
                return true;
            return false;
        }

        // Similar with searching,
        // Time Complexity is O(N) since you will still need to traverse the list
        // n times to check if the data exists on that node.
        private void delete(int data)
        {
            int hashCode = HashCoding(data);
            hashList[hashCode].deleteData(data);
        }

    }
}
