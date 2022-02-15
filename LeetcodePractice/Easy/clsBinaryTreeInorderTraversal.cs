using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodePractice.Easy
{
    /*94. Binary Tree Inorder Traversal
     * Given the root of a binary tree, return the inorder traversal of its nodes' values.
        Example 1:
        Input: root = [1,null,2,3]
        Output: [1,3,2]

        Example 2:
        Input: root = []
        Output: []

        Example 3:
        Input: root = [1]
        Output: [1]
 
        Constraints:
        The number of nodes in the tree is in the range [0, 100].
        -100 <= Node.val <= 100

        Follow up: Recursive solution is trivial, could you do it iteratively?
    */
    class clsBinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> lstResult = new List<int>();
            helper(root, lstResult);
            return lstResult;
        }

        public void helper(TreeNode root, IList<int> lst)
        {
            if (root != null)
            {
                helper(root.left, lst);
                lst.Add(root.val);
                helper(root.right, lst);
            }
        }
    }
}
