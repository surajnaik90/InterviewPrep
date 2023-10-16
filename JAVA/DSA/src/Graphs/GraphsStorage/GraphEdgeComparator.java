package Graphs.GraphsStorage;

import java.util.Comparator;

public class GraphEdgeComparator implements Comparator<GraphEdge> {
    @Override
    public int compare(GraphEdge o1, GraphEdge o2) {
        return o1.cost - o2.cost;
    }
}
