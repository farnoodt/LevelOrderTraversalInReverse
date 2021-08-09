using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOrderTraversalInReverse
{
    class TraversalInReverse
    {
        public Stack<int> InReverse(Node root)
        {
            Queue<Node> Q = new Queue<Node>();
            Stack<int> S = new Stack<int>();
            Q.Enqueue(root);

            while(Q.Count != 0)
            {
                root = Q.Dequeue();
                S.Push(root.data);
                if(root.right != null)
                {
                    Q.Enqueue(root.right);
                }

                if (root.left != null)
                {
                    Q.Enqueue(root.left);
                }
            }
            return S;

        }

    }
}
