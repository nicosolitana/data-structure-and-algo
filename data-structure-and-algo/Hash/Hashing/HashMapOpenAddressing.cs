namespace data_structure_and_algo.Hash.Hashing
{
    class HashMapOpenAddressing
    {
        private int HashSize = 10;
        private int[] HashArr;

        public void init()
        {
            for (int i = 0; i < HashSize; i++)
            {
                HashArr[i] = -1;
            }
        }

        private int HashCoding(int data, int collision)
        {
            return (data % HashSize) + collision;
        }

        private int Probe(int data)
        {
            int collision = 0;
            while (collision < HashSize)
            {
                int index = HashCoding(data, collision);
                if(HashArr[index] == -1)
                {
                    return index;
                } else
                {
                    collision++;
                }
            }
            return -1;
        }

        // Time Complexity is O(N)
        // Since you need to prevent collision by continuously checking for free locations,
        // in the hashmap, then, the processing would require traversing the entire list
        // until you find an empty location to add the value
        private void insert(int data)
        {
            int index = Probe(data);
            HashArr[index] = data;
        }


        // Time Complexity is O(N)
        // Utilizes the same function as insert and search which operates
        // on a time complexity of O(N)
        private void delete(int data)
        {
            int index = Probe(data);
            HashArr[index] = -1;
        }


        // Time Complexity is O(N)
        // Utilizes the same function as insert and delete which operates
        // on a time complexity of O(N)
        private bool search(int data)
        {
            int index = Probe(data);
            if (HashArr[index] == data)
                return true;
            else return false;
        }
    }
}
