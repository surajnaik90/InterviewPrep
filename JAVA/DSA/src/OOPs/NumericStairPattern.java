package OOPs;
import java.util.ArrayList;
public class NumericStairPattern {
    public ArrayList<ArrayList<Integer>> solve(int A) {

        ArrayList<ArrayList<Integer>> outMat = new ArrayList<>();

        for (int i = 1; i <= A; i++) {

            ArrayList<Integer> row = new ArrayList<>();
            for (int j = 1; j <= i; j++) {
                row.add(j);
            }
            outMat.add(row);
        }

        return outMat;
    }
}