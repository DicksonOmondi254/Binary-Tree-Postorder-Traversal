/++
* Definition for a binary tree node.
* public class TreeNode {
*     public class in val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*       this. val = val;
*       this. left = left;
*       this. right = right;
*    }
* }
*/
public class solution {
    public Ilist<int> PostorderTraversal(TreeNode) {
        stack<TreeNode> stack1 = new stack<TreeNode root>();
        stack<TreeNode> stack2 = new stack<TreeNode root>();
        list<int> results = new list<int>();
        if(root == null) return result;
        stack1.Push(root);
        while(stack1.count > 0)
        {
            var current = stack1.Pop();
            stack2.Push(current);
            if(current.left !=null)
            {
                stack1.Push(current.left);
            }
            if(current.right ! = null)
            {
                stack1.Push(current.right);
            }
        }
        while(stack2.count>0){
            var current = stack2.Pop();
            results.Add(current.val);
        }
        return results;
    }
}