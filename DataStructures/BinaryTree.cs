using System;

namespace DataStructures.BinaryTree
{
    class Node
    {
        public int data;
        public Node leftNode, rightNode;
        public int rcount, lcount;

        public Node(int data)
        {
            this.data = data;
            rcount = lcount = 0;
            leftNode = rightNode = null;
        }

        public static void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.leftNode);
                Console.Write(root.data + " ");
                InOrder(root.rightNode);
            }
        }
        public static void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                PreOrder(root.leftNode);
                PreOrder(root.rightNode);
            }
        }
        public static void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.leftNode);
                PostOrder(root.rightNode);
                Console.Write(root.data + " ");
            }
        }
        public static bool IsPerfectBinaryTree(int count)
        {
            count = count + 1;

            // Loop to check the count is in
            // the form of 2^(n-1)
            while (count % 2 == 0)
                count = count / 2;
            if (count == 1)
                return true;
            else
                return false;
        }
        public static Node Insert(Node root, int data)
        {

            // Condition when root is NULL
            if (root == null)
            {
                Node n = new Node(data);
                return n;
            }

            // Condition when count of left sub-tree
            // nodes is equal to the count
            // of right sub-tree nodes
            if (root.rcount == root.lcount)
            {
                root.leftNode = Insert(root.leftNode, data);
                root.lcount += 1;
            }

            // Condition when count of left sub-tree
            // nodes is greater than
            // the right sub-tree nodes
            else if (root.rcount < root.lcount)
            {

                // Condition when left Sub-tree is
                // Perfect Binary Tree then Insert
                // in right sub-tree.
                if (IsPerfectBinaryTree(root.lcount))
                {
                    root.rightNode = Insert(root.rightNode, data);
                    root.rcount += 1;
                }

                // If Left Sub-tree is not Perfect
                // Binary Tree then Insert in left sub-tree
                else
                {
                    root.leftNode = Insert(root.leftNode, data);
                    root.lcount += 1;
                }
            }
            return root;
        }

    }

}
