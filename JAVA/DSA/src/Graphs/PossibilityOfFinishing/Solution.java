package Graphs.PossibilityOfFinishing;
import Graphs.GraphsStorage.ConvertGraph;
import Graphs.GraphsStorage.Indegree;

import java.util.*;
public class Solution {
    public static int solve(int A, ArrayList<Integer> B, ArrayList<Integer> C) {

        int ans = 1;
        Queue<Integer> q = new LinkedList<>();
        ArrayList<Integer> tpSortList = new ArrayList<>();

        //Create an adjacency matrix of the graph
        Queue<Integer>[] list = ConvertGraph.convert2(A, B, C);

        //Create indegree of the graph
        int[] indegree = Indegree.createIndegree2(list);

        //Add all the nodes with indegree 0
        for (int i = 1; i < indegree.length; i++) {
            if(indegree[i] == 0) {
                q.add(i);
            }
        }

        //Iterate the queue
        while(!q.isEmpty()) {
            int element = q.remove();
            tpSortList.add(element);

            if(list[element] == null) { continue; }

            Iterator iterator = list[element].iterator();
            while(iterator.hasNext()){
                int node = (Integer) iterator.next();
                indegree[node] -= 1;

                if(indegree[node] == 0) {
                    q.add(node);
                }
            }
        }

        if(tpSortList.size() != A) {
            return 0;
        }

        return ans;
    }
}