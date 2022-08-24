using System;
using System.Collections.Generic;
using System.Linq;

namespace ReizTechAssignment
{
    public class Program
    {
        public static void Main()
        {
            var nodeRight_2_2_1 = new Branch();
            var nodeRight_2_2 = new Branch(0, new List<Branch> { nodeRight_2_2_1 });
            var nodeRight_2_1 = new Branch();
            var nodeRight_1_1 = new Branch();
            var nodeRight_3 = new Branch();
            var nodeRight_2 = new Branch(0, new List<Branch> { nodeRight_2_1, nodeRight_2_2 });
            var nodeRight_1 = new Branch(0, new List<Branch> { nodeRight_1_1 });
            var nodeRight = new Branch(0, new List<Branch> { nodeRight_1, nodeRight_2, nodeRight_3 });
            var nodeLeft_1 = new Branch();
            var nodeLeft = new Branch(0, new List<Branch> { nodeLeft_1 });
            var branch = new Branch(0, new List<Branch> { nodeLeft, nodeRight });


            Console.WriteLine("Depth = " + MaxDepth.Depth(branch, 1));

            Console.ReadKey();
        }

        public class MaxDepth
        {
            public static int Depth(Branch root, int depth)
            {
                if (root.children == null)
                {
                    return depth;
                }


                return root.children.Max(x => Depth(x, depth + 1));
            }
        }

        public class Branch
        {
            public int val;
            public List<Branch> children;

            public Branch()
            {
            }

            public Branch(int _val, List<Branch> _children)
            {
                val = _val;
                children = _children;
            }

        }
    }
}
