using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94.Binary_Tree_Inorder_Traversal
{
    internal class Solution
    {
        IList<int> resultList = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            InorderTraversal(root.left);
            resultList.Add(root.val);
            InorderTraversal(root.right);

            return resultList;
        }
    }
}
