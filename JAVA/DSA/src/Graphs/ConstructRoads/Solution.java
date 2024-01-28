package Graphs.ConstructRoads;
import Graphs.GraphsStorage.ConvertGraph;
import Graphs.GraphsStorage.GraphNode;

import java.util.*;
public class Solution {
    public static HashMap<Integer, ArrayList<GraphNode>> neighbours;
    public static boolean[] visited;
    public static int[] colors;
    public static int solve(int A, ArrayList<ArrayList<Integer>> B) {

        long mod = (long) Math.pow(10,9) + 7;

        //Init visited array
        visited = new boolean[A+1];

        //Init colors array
        colors = new int[A+1];

        //Create the adjacency list for the given graph
        neighbours = ConvertGraph.convert5(A, B);

        //Iterate the adjacency list to color the nodes
        Iterator iterator = neighbours.keySet().iterator();
        while (iterator.hasNext()) {

            Integer srcNodeVal = (Integer) iterator.next();

            if(neighbours.get(srcNodeVal) == null) { continue; }

            int color = colors[srcNodeVal];
            if(color == 0) { colors[srcNodeVal] = 1; }

            //Color the graph
            colorGraph(srcNodeVal);
        }

        //Calculate the nodes in set A & set B
        long nodesInA = 0, nodesInB = 0;
        for (int i = 0; i < colors.length; i++) {

            if(colors[i] == 1) { nodesInA++; }

            else if(colors[i] == 2) { nodesInB++; }
        }

        //Calculate the total possible roads
        long totalPossibleRoads = (nodesInA * nodesInB);

        //Find the max roads that can be constructed
        long res = ((totalPossibleRoads - (long)B.size()) % mod);

        return (int) res;
    }

    public static void colorGraph(int u) {

        for (GraphNode v: neighbours.get(u)) {

            if(!visited[v.val]) {
                visited[v.val] = true;
                colors[v.val] = 3 - colors[u];
                colorGraph(v.val);
            }
        }
    }
}