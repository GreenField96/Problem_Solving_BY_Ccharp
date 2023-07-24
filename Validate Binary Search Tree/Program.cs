public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null){
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
            return true;

        if (root.right != null)
            if (root.val >= root.right.val)
                return false;

        if (root.left != null)
            if (root.val < root.left.val)
                return false;

        IsValidBST(root.left);

        IsValidBST(root.right);

        return true;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        TreeNode node = new TreeNode(0);
        node.left = new TreeNode(1);
        node.right = new TreeNode(2);

        node.left.left = new TreeNode(3);
        node.left.right = new TreeNode(4);

        node.right.right = new TreeNode(5);
        node.right.left = new TreeNode(6);

        Solution sol = new Solution();
        sol.IsValidBST(node);

    }
}
/*
 public class Solution {
    public bool IsValidBST(TreeNode root) {
        int? l = null;
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        while(cur!=null || s.Count() > 0) {
            while(cur!=null) {
                s.Push(cur);
                cur = cur.left;
            }
            cur = s.Pop();
            if(l != null && l >= cur.val) return false;
            l = cur.val;
            cur = cur.right;
        }
        
        return true;
    }
}
 */