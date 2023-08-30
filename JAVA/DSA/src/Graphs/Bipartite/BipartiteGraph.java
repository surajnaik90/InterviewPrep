package Graphs.Bipartite;
import java.util.*;
public class BipartiteGraph {

    public static int ans;
    public static int[] visited;
    public static int[] colouredNodes;

    public static int solve(int A, ArrayList<ArrayList<Integer>> B) {

        ans = 0;
        visited = new int[A+1];
        colouredNodes = new int[A+1];
        ArrayList<Integer>[] list = new ArrayList[A+1];

        for (int i = 0; i < B.size(); i++) {

            int srcNode = B.get(i).get(0),
                    destNode = B.get(i).get(1);

            if(list[srcNode] != null) {
                list[srcNode].add(destNode);
            }
            else {
                ArrayList<Integer> i1 = new ArrayList<>();
                i1.add(destNode);
                list[srcNode] = i1;
            }
        }

        visited[0] = 1;
        return checkBipartite(0, list);
    }

    public static int checkBipartite(int srcNode, ArrayList<Integer>[] list){

        if(list[srcNode] == null) { return 0; }

        int ans = 1;
        //0 means not visited, 1 means coloured 1 and 2 means coloured 2

        //Iterate all over the connected edges of node
        for (int i = 0; i < list[srcNode].size(); i++) {

            int destNode = list[srcNode].get(i);

            //If not visited
            if(visited[destNode] == 0) {

                //Make the node visited
                visited[destNode] = 1;

                //Color the graph with code 1
                colouredNodes[destNode] = 1 - colouredNodes[srcNode];
            }
            else {

                //Get the colour code of the dest node
                int destColorCode = colouredNodes[destNode];

                //Get the colour code of the src node
                int srColourCode = colouredNodes[srcNode];

                //Adjacent nodes are coloured same
                if(srColourCode == destColorCode) {
                    return 0;
                }
            }

            ans = checkBipartite(destNode, list);

            if(ans == 0) { break; }
        }

        return ans;
    }
}