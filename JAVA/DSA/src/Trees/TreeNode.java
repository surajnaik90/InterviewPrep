package Trees;
import com.sun.source.tree.Tree;
public class TreeNode {
    int val;
    public TreeNode left;
    public TreeNode right;
    TreeNode(int x){
        val = x;
        left = null;
        right = null;
    }
}
