package OOPs.AbstractClass;

import OOPs.*;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        ArrayList<Integer> list = new ArrayList<>();

        list.add(1);
        list.add(2);
        list.add(2);
        list.add(3);
        list.add(4);
        list.add(4);
        list.add(5);

        String arr = "51,6,10,8,22,61,56,48,88,85,21,98,81,76,71,68,18,6,14,23,72,18,56,30,97,100,81,5,99,2,85,67,46,32,66,51,76,53,36,31,81,56,26,75,69,54,54,54,83,41,86,48,7,32,85,23,47,23,18,45,79,95,73,15,55,16,66,73,13,85,14,80,39,92,66,20,22,25,34,14,51,14,17,10,100,35,9,83,31,60,24,37,69,62";
        String[] arrStr = arr.split(",");
        ArrayList<Integer> arrList = new ArrayList<>();
        for (int i = 0; i < arrStr.length; i++) {
            arrList.add(Integer.parseInt(arrStr[i]));
        }
        int ans = UniqueElements.solve(arrList);
        System.out.println(ans);
    }
}
