package Strings;

import java.util.HashMap;

public class LongestSubstringWithoutRepeat {
    public static  int lengthOfLongestSubstring(String A) {

        int ans = Integer.MIN_VALUE;
        HashMap<Character,Integer> map = new HashMap<>();

        int l = A.length();
        int count = 0, start = 0;
        for (int i = 0; i < A.length(); i++) {

            char c = A.charAt(i);

            if(map.containsKey(A.charAt(i))){
                int previosIndex = map.get(c);
                ans = Math.max(count, ans);
                map.put(c, i);
                start = previosIndex + 1;
                count = i - start + 1;
                ans = Math.max(count, ans);
            }
            else{
                map.put(c, i);
                count++;
            }
        }

        if(ans == Integer.MIN_VALUE){
            ans = 1;
        }

        ans  = Math.max(ans, count);
        return ans;
    }
}
