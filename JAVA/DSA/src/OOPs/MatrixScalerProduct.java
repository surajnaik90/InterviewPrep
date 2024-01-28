package OOPs;
import java.util.ArrayList;
public class MatrixScalerProduct {
    public ArrayList<ArrayList<Integer>> solve(ArrayList<ArrayList<Integer>> A, int B) {

        ArrayList<ArrayList<Integer>> outMat = new ArrayList<>();

        for (int i = 0; i < A.size(); i++) {

            ArrayList<Integer> row = new ArrayList<>();
            for (int j = 0; j < A.get(i).size(); j++) {
                row.add(A.get(i).get(j) * B);
            }
            outMat.add(row);
        }

        return outMat;
    }
}
