package Graphs.GraphsStorage;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.PriorityQueue;
import java.util.Queue;

public class Indegree {
    public static int[] createIndegree(PriorityQueue<Integer>[] list) {

        int[] inDegree = new int[list.length];

        for (int i = 0; i < list.length; i++) {
            if(list[i] == null) { continue;}

            Iterator iterator = list[i].iterator();
            while(iterator.hasNext()){
                int node = (Integer) iterator.next();
                inDegree[node] += 1;
            }
        }

        return inDegree;
    }

    public static int[] createIndegree2(Queue<Integer>[] list) {

        int[] inDegree = new int[list.length];

        for (int i = 0; i < list.length; i++) {
            if(list[i] == null) { continue;}

            Iterator iterator = list[i].iterator();
            while(iterator.hasNext()){
                int node = (Integer) iterator.next();
                inDegree[node] += 1;
            }
        }

        return inDegree;
    }
}