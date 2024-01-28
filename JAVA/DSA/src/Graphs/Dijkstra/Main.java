package Graphs.Dijkstra;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        int A = 6;
        ArrayList<Integer> ans = null;
        //String input1 = "43,49,7],[22,25,2],[19,44,4],[3,25,9],[11,32,4],[8,40,1],[29,50,1],[1,25,1],[1,22,1],[15,17,5],[31,50,6],[29,48,2],[45,51,2],[12,30,9],[1,36,4],[10,43,4],[21,22,3],[30,39,1],[0,4,1],[12,43,10],[5,12,7],[22,36,6],[28,36,5],[7,42,8],[12,36,8],[29,35,10],[10,38,6],[10,41,2],[28,31,6],[27,31,3],[25,36,1],[27,44,2],[6,30,7],[14,45,2],[30,50,3],[14,18,5],[21,35,1],[5,46,8],[9,47,1],[18,26,10],[1,18,8],[10,39,8],[32,34,1],[7,37,4],[37,42,3],[2,35,4],[0,15,4],[21,31,1],[17,19,9],[30,42,4],[17,43,10],[4,32,7],[20,41,10],[16,28,6],[1,50,5],[11,18,4],[12,46,6],[17,37,6],[21,26,3],[14,20,1],[9,30,3],[15,19,7],[43,44,6],[1,10,7],[6,35,10],[7,46,6],[24,37,6],[9,35,8],[0,40,4],[4,48,5],[10,37,8],[31,39,1],[31,36,6],[16,44,10],[5,36,5],[1,9,8],[12,47,7],[2,25,6],[4,8,2],[42,49,9],[16,51,10],[1,41,3],[9,26,10],[23,36,1],[36,50,9],[9,28,7],[23,45,2],[37,45,6],[45,50,10],[13,43,3],[5,38,8],[30,34,3],[38,40,8],[1,14,8],[2,12,4],[15,26,5],[19,22,8],[15,27,9],[11,19,6],[2,3,7],[25,34,6],[11,49,10],[34,40,9],[20,29,8],[26,51,6],[1,44,2],[22,44,6],[13,50,5";
        //String input1 = "2,4,8],[4,5,3],[1,2,6],[1,5,8],[0,2,4],[3,4,5],[0,5,10],[2,3,10";
        String input1 = "65,71,7],[31,41,7],[39,91,7],[17,67,10],[59,82,4],[27,29,9],[22,43,3],[0,36,9],[49,62,1],[38,58,10],[81,93,5],[63,68,10],[59,81,7],[1,37,8],[5,14,8],[35,45,4],[75,83,2],[64,89,9],[9,53,10],[51,55,1],[38,92,2],[19,56,9],[22,56,8],[14,68,5],[50,88,10],[75,79,3],[5,70,9],[17,84,9],[23,71,4],[6,73,8],[66,67,6],[12,61,5],[19,52,1],[58,65,1],[16,60,5],[32,86,7],[5,58,5],[42,45,10],[8,62,8],[8,30,6],[47,90,10],[7,11,7],[54,66,8],[14,24,2],[71,90,7],[16,23,6],[52,87,1],[3,58,8],[29,54,1],[24,75,9],[16,20,5],[61,92,5],[61,83,7],[24,70,10],[6,51,7],[27,93,5],[24,46,6],[29,67,5],[53,58,8],[29,49,5],[43,66,2],[13,74,7],[15,78,3],[29,90,1],[58,92,2],[22,74,8],[77,88,6],[3,13,7],[17,41,7],[33,63,6],[31,64,5],[5,7,1],[11,61,6],[14,35,8],[11,40,10],[52,59,4],[68,80,8],[56,85,3],[31,86,4],[5,27,8],[4,16,9],[29,77,6],[6,54,6],[10,16,6],[52,60,7],[14,30,5],[51,88,8],[53,88,1],[51,75,8],[65,69,7],[59,87,8],[40,56,10],[67,92,3],[48,87,4],[10,70,8],[13,36,1],[8,77,4],[5,37,3],[64,82,9],[52,77,7],[12,87,5],[43,74,3],[37,93,1],[50,68,4],[52,68,4],[80,87,9";
        String parsedInput1 = input1.replace("],[" , ",");
        String[] numbers = parsedInput1.split(",");

        ArrayList<Integer> i11 = null; ArrayList<ArrayList<Integer>> i1 = new ArrayList<>();
        for (int i = 0; i < numbers.length; i++) {
            if(i%3==0){
                i11 = new ArrayList<>();
                i1.add(i11);
            }
            i11.add(Integer.valueOf(numbers[i]));
        }

        ans  = Solution.solve(94, i1, 25);

        System.out.println(ans);
    }
}