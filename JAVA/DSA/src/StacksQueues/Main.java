package StacksQueues;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {


        List<Integer> time = new ArrayList<>();
        time.add(0);
        time.add(0);
        time.add(1);
        time.add(5);

        List<Integer> direction = new ArrayList<>();
        direction.add(0);
        direction.add(1);
        direction.add(1);
        direction.add(0);

        List<Integer> time1 = new ArrayList<>();
        time1.add(0);
        time1.add(1);
        time1.add(1);
        time1.add(3);
        time1.add(3);

        List<Integer> direction1 = new ArrayList<>();
        direction1.add(0);
        direction1.add(1);
        direction1.add(0);
        direction1.add(0);
        direction1.add(1);

        List<Integer> ans = Turnstile.getTimes(time1,direction1);
        System.out.println(ans);
    }
}
