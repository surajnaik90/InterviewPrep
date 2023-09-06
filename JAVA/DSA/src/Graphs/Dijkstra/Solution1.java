package Graphs.Dijkstra;
import Graphs.GraphsStorage.*;

import java.lang.reflect.Array;
import java.lang.reflect.GenericArrayType;
import java.util.*;
public class Solution1 {
    public static ArrayList<Integer> solve(int A, ArrayList<ArrayList<Integer>> B, int C) {

        //Create the adjaceny matrix of the graph with weights
        /*ArrayList<GraphNode>[] graph = ConvertGraph.convert4(A, B);
        for (int i = 0; i < graph.length; i++) {

            //System.out.println("Graph NOde: " + i );

            if(graph[i] == null) {
                continue;
            }
            for (int j = 0; j < graph[i].size(); j++) {

                //System.out.println("Neighbour node: " + graph[i].get(j).val + " cost: " + graph[i].get(j).cost);
            }

        }


        //Create a visited array
        boolean[] visited = new boolean[A+1];

        //Create a dijkstra cost
        int[] cost = new int[A+1];
        Arrays.fill(cost, Integer.MAX_VALUE);

        //Create a priority queue
        PriorityQueue<GraphNode> dijkstraRow = new PriorityQueue<>(new GraphNodeComparator());

        //Create a hashmap
        HashMap<Integer, GraphNode> map =new HashMap<>();

        //Initialize the pre-requisites
        GraphNode node = new GraphNode();
        node.val = C; node.cost = 0;
        dijkstraRow.add(node);
        map.put(C, node);
        cost[C] = 0;

        //int minCost = 0;
        while(!dijkstraRow.isEmpty()){

            //GraphNode gNode = dijkstraRow.remove();

            System.out.println("Printing current PQ");
            Iterator iterator = dijkstraRow.iterator();
            while(iterator.hasNext()){
                GraphNode n = (GraphNode) iterator.next();
                System.out.println("Node: " + n.val + " cost: " + n.cost);
            }
            System.out.println("Printing current PQ - Done");


            GraphNode gNode = dijkstraRow.poll();
            System.out.println("Popped out node: " + gNode.val + " cost: " + gNode.cost);



            if(graph[gNode.val] == null) {
                visited[gNode.val] = true;
                continue;
            }

            if(gNode.val == 9 ) {
                System.out.println("Debug Node: " + gNode.val);
            }

            if(visited[gNode.val]) {continue;}

            //minCost += cost[gNode.val];
            for (int i = 0; i < graph[gNode.val].size(); i++) {

                //GraphNode graphNode = graph[gNode.val].get(i);
                int connectedNode = graph[gNode.val].get(i).val,
                        connectedNodeCost = graph[gNode.val].get(i).cost;

                GraphNode graphNode = map.get(connectedNode);

                //if(connectedNode == 9 || connectedNode == 10) {
                   System.out.println("Neighbour node: " + connectedNode + " and its cost : " + connectedNodeCost);
                //}

                if(gNode.val == 30 && connectedNode == 9) {
                    System.out.println("Debugging node 30");
                }

                if(visited[connectedNode] == true) {
                    continue;
                }
                else {
                    dijkstraRow.remove(graphNode);

                    if(graphNode == null) {
                        graphNode = new GraphNode();
                    }

                    graphNode.val = connectedNode;
                    graphNode.cost = connectedNodeCost;
                }

                int tempCost = cost[gNode.val] + connectedNodeCost;

                if(cost[connectedNode] > tempCost) {
                    cost[connectedNode] = tempCost;
                    graphNode.cost = tempCost;
                }

                dijkstraRow.add(graphNode);
                map.put(connectedNode, graphNode);
            }
            visited[gNode.val] = true;
            System.out.println("Visited:" + gNode.val);

            System.out.println("Cost Array:");
            for (int i = 0; i < cost.length - 1; i++) {

                System.out.print(cost[i] + " ");
            }
            System.out.println("\n Cost Array done");
        }

        ArrayList<Integer> ans = new ArrayList<>();
        for (int i = 0; i < cost.length - 1; i++) {

            if(cost[i] == Integer.MAX_VALUE) {
                cost[i] = -1;
            }
            ans.add(cost[i]);
        }

         */
        return null;
    }
}