package StacksQueues;
import java.util.*;
public class Turnstile {
    public static List<Integer> getTimes(List<Integer> time, List<Integer> direction) {

        int[] res =new int[time.size()];
        Queue<Integer> entryQ = new LinkedList<>();
        Queue<Integer> exitQ = new LinkedList<>();
        HashMap<Integer, ArrayList<Integer>> map = new HashMap<>();
        //Set the initial direction
        int gateState = 1, personID = 0;

        //Prepare the (time, persons) map
        for (int i = 0; i < time.size(); i++) {

            int key = time.get(i);;
            if(map.containsKey(key)) {
                ArrayList<Integer> val = map.get(key);
                val.add(i);
                map.put(key, val);
            }
            else {
                ArrayList<Integer> values = new ArrayList<>();
                values.add(i);
                map.put(key,values);
            }
        }



        //Iterate the time
        for (int i = 0; i < Integer.MAX_VALUE; i++) {
            if(map.containsKey(i)){
                for (int j = 0; j < map.get(i).size(); j++) {
                    personID = map.get(i).get(j);                    
                    if(direction.get(personID) == 1) {
                        exitQ.add(personID);
                    }
                    else {
                        entryQ.add(personID);
                    }
                }

                if(!entryQ.isEmpty() || !exitQ.isEmpty()) {
                    if (!entryQ.isEmpty() &&  gateState == direction.get(entryQ.peek())) {
                        personID = entryQ.peek();
                        res[personID] = i;
                        entryQ.remove();
                    }
                    else if(!exitQ.isEmpty() && gateState == direction.get(exitQ.peek())) {
                        personID = exitQ.peek();
                        res[personID] = i;
                        exitQ.remove();
                    }
                }
            }
            else {
                //Decide what gate to process
                if(!entryQ.isEmpty()){
                    personID = entryQ.peek();
                    res[personID] = i;
                    entryQ.remove();
                    gateState = 0;
                    continue;
                }
                if(!exitQ.isEmpty()) {
                    personID = exitQ.peek();
                    res[personID] = i;
                    exitQ.remove();
                    gateState = 1;
                }
            }
        }

        ArrayList<Integer> ans = new ArrayList<>();
        for (int i = 0; i < res.length; i++) {
            ans.add(res[i]);
        }

        return ans;
    }
}