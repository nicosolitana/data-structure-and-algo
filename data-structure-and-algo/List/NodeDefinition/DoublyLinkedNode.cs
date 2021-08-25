namespace data_structure_and_algo.List.NodeDefinition
{
    class DoublyLinkedNode
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

        private DoublyLinkedNode _nextNode;
        public DoublyLinkedNode nextNode
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

        private DoublyLinkedNode _prevNode;
        public DoublyLinkedNode prevNode
        {
            get
            {
                return _prevNode;
            }
            set
            {
                _prevNode = value;
            }
        }

        public DoublyLinkedNode(int idata)
        {
            this._data = idata;
        }
    }
}
