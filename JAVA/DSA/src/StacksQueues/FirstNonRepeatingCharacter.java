package StacksQueues;

import java.util.HashMap;
import java.util.LinkedList;
import java.util.Queue;

public class FirstNonRepeatingCharacter {

    public static String solve(String A) {

        StringBuilder builder = new StringBuilder();
        HashMap<Character,Integer> map = new HashMap<>();
        Queue<Character> q = new LinkedList<>();

        for (int i = 0; i < A.length(); i++) {

            char c = A.charAt(i);

            if(map.containsKey(c)){
                map.put(c, map.get(c) + 1);

                if(q.contains(c)){
                    q.remove(c);
                }
            }
            else {
                map.put(c,1);
                q.add(c);
            }

            if(q.isEmpty()){
                builder.append('#');
            }
            else {
                builder.append(q.peek());
            }
        }

        return builder.toString();
    }
}