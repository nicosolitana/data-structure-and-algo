namespace data_structure_and_algo.Hash.HashNodeDefinition
{
    class HashNode
    {
        private int _data;
        public int Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        private HashNode _nextNode;
        public HashNode nextNode
        {
            get
            {
                return _nextNode;
            }
            set
            {
                _nextNode = value;
            }
        }

        public HashNode(int idata)
        {
            this._data = idata;
        }
    }
}
