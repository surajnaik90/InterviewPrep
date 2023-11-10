package OOPs;
import java.util.ArrayList;
public class RowSum {
    public ArrayList<Integer> solve(ArrayList<ArrayList<Integer>> A) {

        ArrayList<Integer> outArr = new ArrayList<>();

        int sum;
        for (int i = 0; i < A.size(); i++) {

            sum = 0;

            for (int j = 0; j < A.get(i).size(); j++) {
                sum += A.get(i).get(j);
            }

            outArr.add(sum);
        }

        return outArr;
    }
}
