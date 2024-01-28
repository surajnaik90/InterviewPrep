package OOPs;
import java.util.ArrayList;
public class Divisibility {
    public static ArrayList<Integer> solve(ArrayList<Integer> arr) {

        ArrayList<Integer> outArr = new ArrayList<>();

        for (int i = 0; i < arr.size(); i++) {

            if(arr.get(i) % 5 == 0 && arr.get(i) % 7 == 0) {

                outArr.add(arr.get(i));
            }
        }

        return outArr;
    }
}
