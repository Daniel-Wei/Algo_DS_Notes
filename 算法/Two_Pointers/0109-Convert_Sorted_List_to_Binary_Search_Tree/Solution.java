// Time: 0 ms (100.00%), Space: 44.7 MB (43.62%)

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public TreeNode sortedListToBST(ListNode head) {
        return toBST(head, null);
    }
    
    private TreeNode toBST(ListNode start, ListNode end){
        if(start == end){
            return null;
        }
        
        ListNode slow = start;
        ListNode fast = start;
        
        while(fast != end && fast.next != end){
            slow = slow.next;
            fast = fast.next.next;
        }
        
        TreeNode root = new TreeNode(slow.val);
        root.left = toBST(start, slow);
        root.right = toBST(slow.next, end);
        
        return root;
    }
}
