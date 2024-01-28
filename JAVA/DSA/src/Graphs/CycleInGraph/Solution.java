package Graphs.CycleInGraph;
import Graphs.GraphsStorage.ConvertGraph;
import Graphs.GraphsStorage.GraphNode;
import Heaps.ConnectRopes.ConnectRopes;

import java.util.*;
public class Solution {
    public static boolean[] visited;
    public static HashMap<Integer, ArrayList<GraphNode>> neighbours;
    public static int solve(int A, ArrayList<ArrayList<Integer>> B) {

        int output = 0;

        //Initialize the visited array
        visited = new boolean[A+1];

        //Create the adjacency list for the graph
        neighbours = ConvertGraph.convert5(A, B);

        //Iterate the adjacency list to find the cycle in the graph (DFS)
        Iterator iterator = neighbours.keySet().iterator();
        while (iterator.hasNext()) {

            int srcNodeVal = (Integer) iterator.next();

            visited[srcNodeVal] = true;
            output = findCycleInGraph(srcNodeVal, srcNodeVal, 1);

            if(output == 1) { break; }

            visited = new boolean[A+1];
        }

        return output;
    }

    public static int findCycleInGraph(int u, int srcNode, int count) {

        int ans = 0;

        for (GraphNode v: neighbours.get(u)) {

            if(v.val == srcNode && count > 2 && visited[v.val]) {
                //There is a cycle
                ans = 1;
                break;
            }
            if(!visited[v.val]) {
                visited[v.val] = true;
                int newCount = count + 1;
                ans = findCycleInGraph(v.val, srcNode, newCount);
                if(ans == 1) { break; }
            }
        }
        return ans;
    }
}