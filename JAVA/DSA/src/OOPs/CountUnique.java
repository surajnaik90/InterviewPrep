package OOPs;
import java.util.ArrayList;
import java.util.HashMap;

public class CountUnique {
    public int solve(ArrayList<Integer> A) {

        int ans = 0;
        HashMap<Integer,Integer> map = new HashMap<>();

        for (int i = 0; i < A.size(); i++) {

            if(map.containsKey(A.get(i))){
                map.put(A.get(i), map.get(A.get(i)) + 1);
            }
            else {
                map.put(A.get(i), 1);
            }
        }

        for (int i = 0; i < A.size(); i++) {

            if(map.get(A.get(i)) == 1) {
                ans++;
            }
        }

        return ans;
    }
}
