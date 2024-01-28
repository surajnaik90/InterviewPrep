package Graphs.RottenOranges;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;
public class Solution {

    public static int ans = 0;
    public static int count1s = 0;
    public static Queue<int[]> nodes;

    public static ArrayList<ArrayList<Integer>> list;
    public static int solve(ArrayList<ArrayList<Integer>> A) {

        ans = 0; count1s = 0; nodes = new LinkedList<>();
        list = new ArrayList<>(A);

        //Count the number of 1s in the matrix
        for (int i = 0; i < A.size(); i++) {

            for (int j = 0; j < A.get(0).size(); j++) {

                if(A.get(i).get(j) == 1) {
                    count1s++;
                }

                if(A.get(i).get(j) == 2) {
                    int[] item = new int[2];
                    item[0] = i;
                    item[1] = j;
                    nodes.add(item);
                }
            }
        }

        nodes.add(null);


        while(nodes.size() != 0) {

            if(nodes.peek() == null) {
                nodes.remove();

                if(nodes.size() != 0) {
                    nodes.add(null);
                    ans++;
                }

                continue;
            }

            int[] node = nodes.remove();
            int i = node[0], j = node[1];

            makeRotten(i, j);
        }

        if(count1s > 0) {
            ans = -1;
        }

        return ans;
    }

    public static void makeRotten(int i, int j) {

        //Left cell
        if(j-1 >= 0) {
            if(list.get(i).get(j-1) == 1) {
                list.get(i).set(j-1,2);
                count1s--;
                int[] item = new int[2];
                item[0] = i;
                item[1] = j-1;
                nodes.add(item);
            }
        }

        //Right cell
        if(j+1 < list.get(0).size()) {
            if(list.get(i).get(j+1) == 1) {
                list.get(i).set(j+1,2);
                count1s--;
                int[] item = new int[2];
                item[0] = i;
                item[1] = j+1;
                nodes.add(item);
            }
        }

        //Top cell
        if(i-1 >= 0) {
            if(list.get(i-1).get(j) == 1) {
                list.get(i-1).set(j,2);
                count1s--;
                int[] item = new int[2];
                item[0] = i-1;
                item[1] = j;
                nodes.add(item);
            }
        }

        //Bottom cell
        if(i+1 < list.size()) {
            if(list.get(i+1).get(j) == 1) {
                list.get(i+1).set(j,2);
                count1s--;
                int[] item = new int[2];
                item[0] = i+1;
                item[1] = j;
                nodes.add(item);
            }
        }
    }
}