package OOPs;
import java.util.ArrayList;
public class MatrixAddition {
    public ArrayList<ArrayList<Integer>> solve(ArrayList<ArrayList<Integer>> A, ArrayList<ArrayList<Integer>> B) {

        ArrayList<ArrayList<Integer>> outMat = new ArrayList<>();

        for (int i = 0; i < A.size(); i++) {

            ArrayList<Integer> row = new ArrayList<>();
            for (int j = 0; j < A.get(i).size(); j++) {

                int sum = A.get(i).get(j) + B.get(i).get(j);

                row.add(sum);
            }

            outMat.add(row);
        }

        return outMat;
    }
}
