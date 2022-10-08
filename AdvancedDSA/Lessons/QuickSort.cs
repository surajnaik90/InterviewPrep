/*
Given an integer array A, sort the array using QuickSort.

Problem Constraints

1 <= |A| <= 105

1 <= A[i] <= 109

Input Format

First argument is an integer array A.

Output Format

Return the sorted array.

Example Input

Input 1:

 A = [1, 4, 10, 2, 1, 5]
Input 2:

 A = [3, 7, 1]


Example Output

Output 1:

 [1, 1, 2, 4, 5, 10]
Output 2:

 [1, 3, 7]


Example Explanation

Explanation 1:

 Return the sorted array.
 */

using System.Linq;

public static class QuickSort
{
    public static List<int> solve(List<int> A)
    {
       return quickSort(A, 0, A.Count - 1);
    }

    private static List<int> quickSort(List<int> A, int l, int r) 
    {
        if(l>=r) { return A; }

        int index = rearrange(A, l, r);
        A = quickSort(A, l, index-1);
        A = quickSort(A, index+1, r);

        return A;
    }

    private static int rearrange(List<int> arr, int l, int r)
    {
        int left = l + 1, right = r, temp;

        while (left <= right) {

            if (arr[left] <= arr[l]) {
                left++;
            }
            else if (arr[right] > arr[l]) {
                right--;
            }
            else {
                temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
        }

        temp = arr[l];
        arr[l] = arr[right];
        arr[right] = temp;

        return right;
    }
}