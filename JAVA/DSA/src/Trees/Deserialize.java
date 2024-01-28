package Trees;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;

public class Deserialize {
    public static TreeNode solve(ArrayList<Integer> A) {

        TreeNode root = new TreeNode(A.get(0));
        Queue<TreeNode> q = new LinkedList<>();
        q.add(root);
        int i = 1;
        while(q.size() != 0){
            TreeNode cur = q.peek();
            q.remove();
            if(cur == null){
                continue;
            }
            int val_left = A.get(i);
            int val_right = A.get(i+1);

            i += 2;

            if(val_left == -1){
                cur.left = null;
            }
            else{
                cur.left = new TreeNode(val_left);
            }
            if(val_right == -1){
                cur.right = null;
            }
            else{
                cur.right = new TreeNode(val_right);
            }
            q.add(cur.left);
            q.add(cur.right);
        }

        return root;

    }
}
