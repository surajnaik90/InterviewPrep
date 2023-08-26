package BinarySearch;
import java.util.*;
public class RotatedSortedSearch {

    public static int search(final List<Integer> A, int B) {
        return compute(0,A.size()-1, A, B);
    }

    public static int compute(int start, int end, List<Integer> list, int B) {

        if(start == end || (Math.abs(start-end)) == 1) {
            if(list.get(start) == B) { return start; }

            else if(list.get(end) == B) { return end; }

            return -1;
        }

        int mid = (start + end) / 2;

        if(B > list.get(end)) {
            end = mid;
        }
        else if(B <= list.get(end) || B >= list.get(mid)) {
            start = mid;
        }

        return compute(start, end, list, B);
    }
}