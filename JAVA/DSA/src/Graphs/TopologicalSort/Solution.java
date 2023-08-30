package Graphs.TopologicalSort;
import Graphs.GraphsStorage.ConvertGraph;
import Graphs.GraphsStorage.Indegree;

import java.util.*;
public class Solution {
    public static ArrayList<Integer> solve(int A, ArrayList<ArrayList<Integer>> B) {

        PriorityQueue<Integer> q = new PriorityQueue<>();
        ArrayList<Integer> ans = new ArrayList<>();
        Queue<Integer> disConnectedComponents = new LinkedList<>();

        //Create an adjacency matrix of the graph
        PriorityQueue<Integer>[] list = ConvertGraph.convert(A, B);

        //Create indegree of the graph
        int[] indegree = Indegree.createIndegree(list);

        //Add all the nodes with indegree 0
        for (int i = 1; i < indegree.length; i++) {
            if(indegree[i] == 0) {
                q.add(i);
            }
        }

        //Iterate the queue
        while(!q.isEmpty()) {
            int element = q.remove();
            ans.add(element);

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

        return ans;
    }
}