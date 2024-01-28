package Strings.HashMaps;

import java.util.HashMap;
import java.util.HashSet;

public class PermutationsAinB {
    public static int solve(String A, String B) {

        int ans = 0;
        HashMap<Character,Integer> aMap = new HashMap<>();
        HashMap<Character,Integer> bMap = new HashMap<>();

        for (int i = 0; i < A.length(); i++) {

            if(aMap.containsKey(A.charAt(i))){
                aMap.put(A.charAt(i), aMap.get(A.charAt(i)) + 1);
            }
            else {
                aMap.put(A.charAt(i),1);
            }
        }
        
        int aMapCount = aMap.size();

        for (int i = 0; i < A.length(); i++) {
            if(bMap.containsKey(B.charAt(i))){
                bMap.put(B.charAt(i), bMap.get(B.charAt(i)) + 1);
            }
            else {
                if(aMap.containsKey(B.charAt(i))) {
                    bMap.put(B.charAt(i), 1);
                }
            }
        }

        if(bMap.size() == aMap.size()) {
            ans++;
        }

        for (int i = 0; i < B.length() - A.length(); i++) {

            //Remove the ith element
            Character key = B.charAt(i);
            if(bMap.containsKey(key)){
                bMap.put(key, bMap.get(key) - 1);

                if(bMap.get(key) == 0) {
                    bMap.remove(key);
                }
            }

            //add the i+A.length() element
            Character c = B.charAt(i+A.length());
            if(bMap.containsKey(c)){
                bMap.put(c, bMap.get(c) + 1);
            }
            else{
                if(aMap.containsKey(c)) {
                    bMap.put(c,1);
                }
            }

            if(bMap.size()==aMap.size()){
                ans++;
            }
        }

        return ans;
    }
}
