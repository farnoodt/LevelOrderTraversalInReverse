using System;

namespace LevelOrderTraversalInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(10);
            tree.left = new Node(20);
            tree.left.left = new Node(40);
            tree.left.right = new Node(50);
            tree.left.right.left = new Node(70);
            tree.left.right.right = new Node(800);
            tree.right = new Node(30);
            tree.right.right = new Node(60);
            tree.right.right.left = new Node(90);

            TraversalInReverse TIR = new TraversalInReverse();
            Console.WriteLine(string.Join(" , " , TIR.InReverse(tree)));
            Console.ReadLine();
        }
    }
}
