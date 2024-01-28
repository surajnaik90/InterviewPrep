package Graphs.GraphsStorage;

import java.util.Comparator;

public class GraphNodeComparator implements Comparator<GraphNode> {
    @Override
    public int compare(GraphNode o1, GraphNode o2) {

        if(o1.cost < o2.cost) {
            return -1;
        }
        else if(o1.cost == o2.cost) {
            return 0;
        }
        else {
            return 1;
        }
    }
}