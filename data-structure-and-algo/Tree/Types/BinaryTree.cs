using data_structure_and_algo.Tree.TreeNodeDefinition;

// NOT YET DONE
namespace data_structure_and_algo.Tree.Types
{
    class BinaryTree
    {
        private TreeNode root;
        public void insert(int data)
        {
            if (root == null)
                root = new TreeNode(data);
            else
                root.insert(data);
        }

        // iterative
        public bool ifind(int data)
        {
            while (true)
            {
                if (root.data == data)
                    return true;
                else
                {
                    if ((root.data > data) && (root.left != null))
                        root = root.left;
                    else
                    {
                        if (root.right == null)
                            break;
                        root = root.right;
                    }
                }
            }
            return false;
        }

        // Recursive
        public TreeNode rfind(int data)
        {
            TreeNode result = root.find(data);
            if (result != null)
                return result;
            return null;
        }

        public void softDelete(int data)
        {
            TreeNode node = rfind(data);
            node.isDeleted = true;
        }

        public void delete(int data)
        {
            if (root == null)
                return;

            TreeNode current = root;
            while (current != null)
            {
                if (current.data == data)
                    break;

                if ((current.left != null) && (current.data > data))
                    current = current.left;
                else
                    current = current.right;
            }

            // Case 1 : No right and left childs
            if ((current.left == null) && (current.right == null))
                current = null;
            else
            {
                // Case 2 : Only has one child
                if(current == root)
                {
                    root = current.left;
                } else if(current.left == null)
                {
                    current = current.right;
                } else
                {
                    current = current.left;
                }
            }


        }
    }
}
