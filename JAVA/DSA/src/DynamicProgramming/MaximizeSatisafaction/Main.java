package DynamicProgramming.MaximizeSatisafaction;

import java.util.ArrayList;
public class Main {

    public static void main(String[] args) {

        int ans = 0;

        ArrayList<Integer> i1 = new ArrayList<>();
        i1.add(10); i1.add(20); i1.add(15); i1.add(4); i1.add(14);

        ans = MS.solve(i1);

        System.out.println(ans);



        i1 = new ArrayList<>();
        i1.add(1); i1.add(18); i1.add(15); i1.add(16);
        i1.add(7); i1.add(127); i1.add(3); i1.add(83);
        i1.add(31); i1.add(23); i1.add(31);

        ans = MS.solve(i1);

        System.out.println(ans);


        i1 = new ArrayList<>();
        i1.add(255); i1.add(127); i1.add(31); i1.add(5);
        i1.add(24); i1.add(37); i1.add(15);

        ans = MS.solve(i1);
        //ans should be 24

        System.out.println(ans);
    }
}