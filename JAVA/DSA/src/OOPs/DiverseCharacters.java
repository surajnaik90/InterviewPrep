package OOPs;

import java.util.HashSet;

public class DiverseCharacters {
    public int solve(final String A) {

        int charCount = 0, numCount = 0;
        String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        HashSet<Character> map = new HashSet<>();
        for (int i = 0; i < chars.length(); i++) {
            map.add(chars.charAt(i));
        }

        for (int i = 0; i < A.length(); i++) {

            if(map.contains(A.charAt(i))){
                charCount++;
            }
            else {
                numCount++;
            }
        }

        /* This way also could have been done
        for(int i=0; i < A.length();i++) {
            char ch = A.charAt(i);

            if(ch >= 'A' && ch <= 'Z') {
                cnta++;
            }
            else if(ch >= 'a' && ch <= 'z') {
                cnta++;
            }
            else if(ch >= '0' && ch <= '9') {
                cntd++;
            }
        }
        */

        return Math.max(charCount, numCount);
    }
}