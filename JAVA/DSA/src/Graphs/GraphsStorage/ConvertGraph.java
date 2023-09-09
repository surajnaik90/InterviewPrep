package Graphs.GraphsStorage;

import java.util.*;

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

    public static Queue<Integer>[] convert2(int A, ArrayList<Integer> B, ArrayList<Integer> C) {

        Queue<Integer> arrList[] = new LinkedList[A+1];

        for (int i = 0; i < B.size(); i++) {

            int srcNode = B.get(i),
                    destNode = C.get(i);

            if(arrList[srcNode] != null) {
                arrList[srcNode].add(destNode);
            }
            else {
                Queue<Integer> connectedNodes = new LinkedList<>();
                connectedNodes.add(destNode);

                arrList[srcNode] = connectedNodes;
            }
        }
        return arrList;
    }

    public static PriorityQueue<GraphNode>[] convert3(int A, ArrayList<ArrayList<Integer>> list) {

        PriorityQueue<GraphNode> arrList[] = new PriorityQueue[A+1];

        for (int i = 0; i < list.size(); i++) {

            int srcNode = list.get(i).get(0),
                    destNode = list.get(i).get(1),
                    weight = list.get(i).get(2);

            GraphNode node = new GraphNode();
            node.val = destNode;
            node.cost = weight;

            if(arrList[srcNode] != null) {
                arrList[srcNode].add(node);
            }
            else {
                PriorityQueue<GraphNode> connectedNodes = new PriorityQueue<>(new GraphNodeComparator());
                connectedNodes.add(node);

                arrList[srcNode] = connectedNodes;
            }
        }
        return arrList;
    }

    public static HashMap<Integer, ArrayList<GraphNode>> convert4(int A, ArrayList<ArrayList<Integer>> list) {

        HashMap<Integer, ArrayList<GraphNode>> arrList = new HashMap<>();

        for (int i = 0; i < list.size(); i++) {

            int srcNode = list.get(i).get(0),
                    destNode = list.get(i).get(1),
                    weight = list.get(i).get(2);

            GraphNode node = new GraphNode();
            node.val = destNode;
            node.cost = weight;

            if(arrList.get(srcNode) != null) {
                arrList.get(srcNode).add(node);
            }
            else {
                ArrayList<GraphNode> connectedNodes = new ArrayList<>();
                connectedNodes.add(node);

                arrList.put(srcNode, connectedNodes);
            }

            node = new GraphNode();
            node.val = srcNode;
            node.cost = weight;
            if(arrList.get(destNode) != null) {
                arrList.get(destNode).add(node);
            }
            else {
                ArrayList<GraphNode> connectedNodes = new ArrayList<>();
                connectedNodes.add(node);

                arrList.put(destNode, connectedNodes);
            }
        }
        return arrList;
    }

    public static HashMap<Integer, ArrayList<GraphNode>> convert5(int A, ArrayList<ArrayList<Integer>> list) {

        HashMap<Integer, ArrayList<GraphNode>> arrList = new HashMap<>();

        for (int i = 0; i < list.size(); i++) {

            int srcNodeVal = list.get(i).get(0),
                    destNodeVal = list.get(i).get(1);

            GraphNode srcNode = new GraphNode();
            srcNode.val = srcNodeVal;

            GraphNode destNode = new GraphNode();
            destNode.val = destNodeVal;

            //Add the src-dest edge
            if(arrList.get(srcNodeVal) != null) {
                arrList.get(srcNodeVal).add(destNode);
            }
            else {
                ArrayList<GraphNode> connectedNodes = new ArrayList<>();
                connectedNodes.add(destNode);

                arrList.put(srcNodeVal, connectedNodes);
            }

            //Ads the dest-src edge
            if(arrList.get(destNodeVal) != null) {
                arrList.get(destNodeVal).add(srcNode);
            }
            else {
                ArrayList<GraphNode> connectedNodes = new ArrayList<>();
                connectedNodes.add(srcNode);

                arrList.put(destNodeVal, connectedNodes);
            }
        }
        return arrList;
    }

}