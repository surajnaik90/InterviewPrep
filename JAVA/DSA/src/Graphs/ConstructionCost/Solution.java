package Graphs.ConstructionCost;
import Graphs.GraphsStorage.ConvertGraph;
import Graphs.GraphsStorage.GraphEdge;
import Graphs.GraphsStorage.GraphEdgeComparator;
import Graphs.GraphsStorage.GraphNode;

import java.util.*;
public class Solution {
    public static PriorityQueue<GraphEdge> edges;
    public static int solve(int A, ArrayList<ArrayList<Integer>> B) {

        if(B.size() == 0) { return 0;}

        long ans  = 0, mod = (long) Math.pow(10,9) + 7;
        edges = new PriorityQueue<>(new GraphEdgeComparator());

        //Create the queue to maintain the node traversal
        Queue<Integer> q = new LinkedList<>();
        for (int i = 1; i <= A; i++) {
            q.add(i);
        }

        //Create the priority queue for the graph node edges
        for (int i = 0; i < B.size(); i++) {

            GraphEdge edge = new GraphEdge();

            edge.u = B.get(i).get(0);
            edge.v = B.get(i).get(1);
            edge.cost = B.get(i).get(2);

            edges.add(edge);
        }

        boolean edgeTaken = false;
        while(!q.isEmpty()) {

            GraphEdge edge = edges.remove();

            if(q.contains(edge.u)) {
                q.remove(edge.u);
                edgeTaken = true;
            }
            if(q.contains(edge.v)) {
                q.remove(edge.v);
                edgeTaken = true;
            }

            if(edgeTaken) {
                ans += edge.cost;
                ans %= mod;
                edgeTaken = false;
            }
        }
        return (int) ans;
    }
}