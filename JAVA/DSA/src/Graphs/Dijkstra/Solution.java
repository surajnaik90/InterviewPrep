package Graphs.Dijkstra;
import Graphs.GraphsStorage.ConvertGraph;
import Graphs.GraphsStorage.GraphNode;
import Graphs.GraphsStorage.GraphNodeComparator;

import java.util.*;
public class Solution {
    public static ArrayList<Integer> solve(int A, ArrayList<ArrayList<Integer>> B, int C) {

        //Creat the output list
        ArrayList<Integer> output = new ArrayList<>();

        //Create the adjacency list for the graph
        HashMap<Integer, ArrayList<GraphNode>> neighbours = ConvertGraph.convert4(A,B);

        //Create the visited array
        boolean visited[] = new boolean[A];

        //Create the priority queue to extract the shortest cost node
        PriorityQueue<GraphNode> pq = new PriorityQueue<>(new GraphNodeComparator());

        //Create the output array i.e, cost array
        int[] cost = new int[A];
        Arrays.fill(cost,Integer.MAX_VALUE);

        //Create the hashmap to hold the addresses of the nodes in the priority queue
        //This is to update the nodes in the priority queue if we encounter low cost
        HashMap<Integer,GraphNode> map = new HashMap<>();

        //Set the pre-requisite to start the Dijkstra's algo
        //Add the source node to the priority queue
        GraphNode srcNode = new GraphNode();
        srcNode.val = C; srcNode.cost = 0;
        cost[srcNode.val] = 0;
        pq.add(srcNode);

        //Iterate the priority queue until it's empty
        while(!pq.isEmpty()) {

            //Pop the node
            GraphNode u = pq.remove();
            visited[u.val] = true;

            if(neighbours.get(u.val) == null) { continue; }

            //Iterate the neighbours of popped node
            for (GraphNode v: neighbours.get(u.val)) {
                if(!visited[v.val] &&
                        ((cost[v.val] > cost[u.val] + v.cost))) {
                    cost[v.val] = cost[u.val] + v.cost;
                    v.cost = cost[v.val];
                    pq.add(v);
                }
            }
        }

        //Create the output list
        for (int i = 0; i < cost.length; i++) {

            if(cost[i] == Integer.MAX_VALUE) {
                output.add(-1);
                continue;
            }
            output.add(cost[i]);
        }

        return output;
    }
}