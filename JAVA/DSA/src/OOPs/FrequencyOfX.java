package OOPs;
import java.util.ArrayList;
import java.util.HashMap;

public class FrequencyOfX {
    public static int solve(ArrayList<Integer> A, int B) {

        HashMap<Integer, Integer> freqMap = new HashMap<>();

        for (int i = 0; i < A.size(); i++) {

            if(freqMap.containsKey(A.get(i))){
                freqMap.put(A.get(i), freqMap.get(A.get(i)) + 1 );
            }
            else {
                freqMap.put(A.get(i), 1);
            }
        }

        if(freqMap.containsKey(B)){
            return freqMap.get(B);
        }
        else {
            return 0;
        }
    }
}
