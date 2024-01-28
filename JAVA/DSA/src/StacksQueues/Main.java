package StacksQueues;

import Heaps.AthLargestElement;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {


        ArrayList<Integer> arrayList = new ArrayList<>();

        arrayList.add(1);
        arrayList.add(2);
        arrayList.add(3);
        arrayList.add(4);
        arrayList.add(5);
        arrayList.add(6);

        ArrayList<Integer> arrayList1 = new ArrayList<>();

        arrayList1.add(5);
        arrayList1.add(1);
        arrayList1.add(5);
        arrayList1.add(7);
        arrayList1.add(3);
        arrayList1.add(4);
        arrayList1.add(6);
        arrayList1.add(11);


        ArrayList<Integer> tempList = AthLargestElement.solve(3, arrayList1);

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
