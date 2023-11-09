package OOPs;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Scanner;

public class SearchElement {
    public static void print(){

        Scanner sc = new Scanner(System.in);

        int t = Integer.parseInt(sc.nextLine().trim());
        ArrayList<Integer> outArr = new ArrayList<>();

        for (int i = 0; i < t; i++) {

            int n = Integer.parseInt(sc.nextLine().trim());

            String str = sc.nextLine().trim();
            String[] arrStr = str.split(" ");

            HashSet<Integer> hashSet = new HashSet<>();
            for (int j = 0; j < arrStr.length; j++) {

                int element = Integer.parseInt(arrStr[j]);
                hashSet.add(element);
            }

            int b = Integer.parseInt(sc.nextLine().trim());

            if(hashSet.contains(b)){
                outArr.add(1);
            }
            else {
                outArr.add(0);
            }
        }

        for (int i = 0; i < outArr.size(); i++) {
            System.out.println(outArr.get(i));
        }
    }
}
