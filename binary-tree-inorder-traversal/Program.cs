
 public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
 }
 
public class Solution{
    IList<int> ints = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {
        Inorder(root);
        return ints;
    }
    public void Inorder(TreeNode root)
    {
        if (root == null)
            return;

        InorderTraversal(root.left);

        // Console.WriteLine(root.val);
        ints.Add(root.val);

        InorderTraversal(root.right);
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
        IList<int> ints = sol.InorderTraversal(node);
        
        for (int i = 0; i < ints.Count; i++) {
            Console.WriteLine(ints[i]);
          }

    }
}

/**
 * From Solution Section
 * 
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (stack.Count != 0 || root != null) {
            if (root != null) {
                stack.Push(root);
                root = root.left;
            } else {
                root = stack.Pop();
                result.Add(root.val);
                root = root.right;
            }
        }
        return result;
    }
} 
 */