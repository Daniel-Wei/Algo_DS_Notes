/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

// Time: 69 ms (96.56%), Space: 45.2 MB (53.17%)

public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null){
            return false;
        }
        return Helper(root, 0, targetSum);
    }
    
    private bool Helper(TreeNode curr, int sum, int targetSum){
        if(curr.left == null & curr.right == null){
            return sum + curr.val == targetSum;
        }
        
        sum += curr.val;
        
        bool res = false;
        
        if(curr.left != null){
            res = res || Helper(curr.left, sum, targetSum);
        }
       
        
        if(res){
            return res;
        }
        
        if(curr.right != null){
            res = res || Helper(curr.right, sum, targetSum);
        }
        
        
        return res;
    }
}
