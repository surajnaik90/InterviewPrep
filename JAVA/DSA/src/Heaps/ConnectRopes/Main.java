package Heaps.ConnectRopes;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        int ans = 0;

        ArrayList<Integer> i1 = new ArrayList<>();
        i1.add(1); i1.add(2); i1.add(3); i1.add(4); i1.add(5);
        ans = ConnectRopes.solve(i1);
        System.out.println(ans);

        i1 = new ArrayList<>();
        i1.add(5); i1.add(17); i1.add(100); i1.add(11);
        ans = ConnectRopes.solve(i1);
        System.out.println(ans);
    }
}
