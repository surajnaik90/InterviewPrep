package OOPs;
import java.util.ArrayList;
import java.util.List;
public class IdentityMatrix {
    public int solve(final List<ArrayList<Integer>> A) {

        for (int i = 0; i < A.size(); i++) {

            for (int j = 0; j < A.get(i).size(); j++) {

                if(i == j) {
                    if(A.get(i).get(j) != 1) {
                        return 0;
                    }
                }
                else {
                    if(A.get(i).get(j) != 0) {
                        return 0;
                    }
                }
            }

        }

        return 1;
    }
}
