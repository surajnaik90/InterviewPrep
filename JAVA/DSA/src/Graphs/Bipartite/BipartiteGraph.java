package Graphs.Bipartite;
import Graphs.GraphsStorage.ConvertGraph;
import Graphs.GraphsStorage.GraphNode;

import java.util.*;
public class BipartiteGraph {
    public static HashMap<Integer, ArrayList<GraphNode>> neighbours;
    public static boolean[] visited;
    public static int[] colors;
    public static int solve(int A, ArrayList<ArrayList<Integer>> B) {

        int output = 1;

        //Create the adjacency matrix for the given graph
        neighbours = ConvertGraph.convert5(A, B);

        //Create the visited array
        visited = new boolean[A];

        //Create the array to maintain the color of the nodes
        colors = new int[A];

        //Iterate the nodes of the graph
        Iterator iterator = neighbours.keySet().iterator();
        while(iterator.hasNext()){

            Integer srcNodeVal = (Integer) iterator.next();

            if(colors[srcNodeVal] == 0) { colors[srcNodeVal] = 1; }

            output = colorGraph(srcNodeVal);

            if(output == 0) { break; }
        }

        return output;
    }

    public static int colorGraph(int u) {

        if(neighbours.get(u) == null) { return 1; }

        int res = 1;
        int color = colors[u];

        for (GraphNode v: neighbours.get(u)) {

            if(colors[v.val] == color) {
                if(colors[v.val] != 0 && color != 0) { return  0; }
            }

            if(!visited[v.val]) {
                visited[v.val] = true;
                colors[v.val] = 3 - color;
                res = colorGraph(v.val);
            }

            if(res == 0) { break;}
        }

        return res;
    }
}