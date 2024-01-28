package OOPs;
import java.util.ArrayList;
public class CheckArraySorted {
    public static int solve(ArrayList<Integer> A) {

        for (int i = 1; i < A.size(); i++) {

            if(!(A.get(i) >= A.get(i-1))) {
                return 0;
            }
        }

        return 1;
    }
}
