package TestProject;

import java.util.ArrayList;
import java.util.HashSet;

public class Main {
    public static void main(String[] args) {

        System.out.println("Hello World");

        HashSet<ArrayList<Integer>> map = new HashSet<>();

        ArrayList<Integer> i1 = new ArrayList<>();
        i1.add(1); i1.add(2); i1.add(3);

        ArrayList<Integer> i2 = new ArrayList<>();
        i2.add(1); i2.add(2); i2.add(3);

        map.add(i1);

        if(map.contains(i2)){
            System.out.println("Not adding");
        }
        else {
            System.out.println("adding");
            map.add(i2);
        }



        System.out.println(map);
    }
}
