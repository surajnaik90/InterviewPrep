package OOPs;
import java.util.ArrayList;
import java.util.HashMap;

public class UniqueElements {
    public static  int solve(ArrayList<Integer> A) {

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

            int count = 1;
            if(map.get(A.get(i)) == 1){
                continue;
            }
            else{
                int num = A.get(i);
                while(map.get(num) > 1) {
                    while(map.containsKey(num)){
                        num++;ans++;
                    }
                    map.put(num, 1);
                    map.put(A.get(i), map.get(A.get(i)) - 1);
                }
            }
        }

        return ans;
    }
}
