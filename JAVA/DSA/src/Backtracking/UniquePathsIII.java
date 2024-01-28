package Backtracking;

import java.util.ArrayList;

import java.util.*;
public class UniquePathsIII {
    public static int solve(ArrayList<ArrayList<Integer>> A) {

        int res = 0, count = 0, row = 0, column = 0;

        int[][] matrix = new int[A.size()][A.get(0).size()];

        for (int i = 0; i < A.size(); i++) {
            for (int j = 0; j < A.get(i).size(); j++) {

                if(A.get(i).get(j) == 0) { count++; }

                if(A.get(i).get(j) == 1) {
                    row = i; column = j;
                }

                matrix[i][j] = A.get(i).get(j);
            }
        }

        return compute(row,column,count, matrix);
    }

    public static int compute(int row, int column, int count, int[][] A) {

        if(row < 0 || column < 0 || row > A.length - 1 || column > A[0].length - 1 ) { return 0; }

        if(A[row][column] == -1) { return 0; }

        if(A[row][column] == 2 && count < 0) { return 1; }

        int left = 0, right = 0, top = 0, down = 0;

        //Previous state of the cell
        int prevState = A[row][column];

        //Set the cell as visited
        A[row][column] = -1;

        //Traverse left
        left = compute(row, column - 1, count - 1, A);

        //Traverse right
        right = compute(row, column + 1, count - 1, A);

        //Traverse top
        top = compute(row - 1, column, count - 1, A);

        //Traverse down
        down = compute(row + 1, column, count - 1, A);

        if(prevState != 1){
            A[row][column] = prevState;
        }

        return left + right + top + down;
    }
}