package BinarySearch;

import java.util.ArrayList;
import java.util.List;
public class Main {
    public static void main(String[] args){

        int ans = 0; List<Integer> i1;

        i1 = new ArrayList<>();
        i1.add(4); i1.add(5); i1.add(6); i1.add(7);
        i1.add(0); i1.add(1); i1.add(2); i1.add(3);

        ans = RotatedSortedSearch.search(i1, 6);

        System.out.println(ans);

        i1 = new ArrayList<>();
        i1.add(9); i1.add(10); i1.add(3); i1.add(5);
        i1.add(6); i1.add(8);

        ans = RotatedSortedSearch.search(i1, 5);

        System.out.println(ans);

    }
}
