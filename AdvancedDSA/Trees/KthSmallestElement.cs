using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAANG.AdvancedDSA.Trees
{
    public class KthSmallestElementTree
    {
        public static List<int> nodes;
        public static int solve(TreeNode A, int B)
        {
            nodes = new List<int>();

            kthsmallest(A);

            return nodes[B - 1];
        }
        public static void kthsmallest(TreeNode node)
        {
            if(node == null) {
                return;
            }

            if(node.left != null) {
                kthsmallest(node.left);
            }

            nodes.Add(node.val);

            if(node.right != null) {
                kthsmallest(node.right);
            }
        }
    }
}