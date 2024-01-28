package Graphs.Dijkstra;

import Graphs.GraphsStorage.GraphNode;
import Graphs.GraphsStorage.GraphNodeComparator;

import java.util.PriorityQueue;

public class Test {

    public static void test(){

        PriorityQueue<GraphNode> pq = new PriorityQueue<>(new GraphNodeComparator());

        GraphNode n1 = new GraphNode();
        n1.val = 1;
        n1.cost = 5;
        pq.add(n1);

        GraphNode n2 = new GraphNode();
        n2.val = 2;
        n2.cost = 10;
        pq.add(n2);

        n1 = new GraphNode();
        n1.val = 4;
        n1.cost = 8;
        pq.add(n1);

        GraphNode nr = new GraphNode();
        nr.val = 2;
        nr.cost = 10;

        pq.remove(n2);

        //pq.add(n1);

        System.out.println(pq);

        System.out.println("done");
    }
}