namespace data_structure_and_algo.List.NodeDefinition
{
    class Node
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

        private Node _nextNode;
        public Node nextNode
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

        public Node(int idata)
        {
            this._data = idata;
        }
    }
}
