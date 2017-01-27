using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamzTreez
{
    delegate void TreeVisitor<T>(T nodeData);

    //Assigned T Data as a return value for all instances; this provides a reference to the root of the tree.

    class TreeNode<T>
    {
        private T data;
        private LinkedList<TreeNode<T>> children;

        public TreeNode(T Data)
        {
            this.data = Data;
            children = new LinkedList<TreeNode<T>>();
        }

        //Establishing the root of the tree inside the class.

        public void AddChild(T Data)
        {
            children.AddFirst(new TreeNode<T>(data));
        }

        //The Insertion method of the tree; adding a child to the root node.

        public TreeNode<T> GetChild(int i)
        {
            foreach (TreeNode<T> n in children)
                if (--i == 0)
                    return n;
            return null;
        }

        //The Search method of the tree; checks to see if each node has a child and returns "n" if so or "null" if not.

        public void Traverse(TreeNode<T> node, TreeVisitor<T> visitor)
        {
            visitor(node.data);
            foreach (TreeNode<T> child in node.children)
                Traverse(child, visitor);
        }

        //The Traverse method of the tree; looping through the tree (in an undefined order) using recursion.
    }
}
