package Graphs.GraphsStorage;

import java.util.ArrayList;
import java.util.PriorityQueue;

public class ConvertGraph {

    //Create the list such that each item in the list points to a
    //list of connected nodes from that item
    public static PriorityQueue<Integer>[] convert(int A, ArrayList<ArrayList<Integer>> list) {

        PriorityQueue<Integer> arrList[] = new PriorityQueue[A+1];

        for (int i = 0; i < list.size(); i++) {

            for (int j = 0; j < list.get(i).size() - 1; j++) {

                int srcNode = list.get(i).get(0),
                        destNode = list.get(i).get(1);

                if(arrList[srcNode] != null) {
                    arrList[srcNode].add(destNode);
                }
                else {
                    PriorityQueue<Integer> connectedNodes = new PriorityQueue<>();
                    connectedNodes.add(destNode);

                    arrList[srcNode] = connectedNodes;
                }
            }

        }
        return arrList;
    }
}