package OOPs;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;

public class CountDuplicate {
    public int solve(ArrayList<Integer> A) {

        HashSet<Integer> map = new HashSet<>();

        for (int i = 0; i < A.size(); i++) {
            map.add(A.get(i));
        }

        return map.size();
    }
}
