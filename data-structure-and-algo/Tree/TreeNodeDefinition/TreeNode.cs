// NOT YET DONE
namespace data_structure_and_algo.Tree.TreeNodeDefinition
{
    class TreeNode
    {
        private int _data;
        public int data
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

        private TreeNode _left;
        public TreeNode left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }

        private TreeNode _right;
        public TreeNode right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }

        private bool _isDeleted;
        public bool isDeleted
        {
            get
            {
                return _isDeleted;
            }
            set
            {
                _isDeleted = value;
            }
        }

        public TreeNode(int idata)
        {
            data = idata;
        }

        public TreeNode find(int idata)
        {
            if ((data == idata) && (!isDeleted))
                return this;

            if ((idata < data) && (left != null))
                return left.find(idata);

            if (right != null)
                return right.find(idata);

            return null;
        }

        public void insert(int idata)
        {
            TreeNode newNode = new TreeNode(idata);
            if (data >= idata)
            {
                if (left == null)
                    left = newNode;
                else
                    left.insert(idata);
            }
            else
            {
                if (right == null)
                    right = newNode;
                else
                    right.insert(idata);
            }
        }
    }
}
