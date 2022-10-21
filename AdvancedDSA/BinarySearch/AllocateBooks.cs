/*
Given an array of integers A of size N and an integer B.

The College library has N books. The ith book has A[i] number of pages.

You have to allocate books to B number of students so that the maximum number of pages allocated to a student is minimum.

A book will be allocated to exactly one student.
Each student has to be allocated at least one book.
Allotment should be in contiguous order, for example: A student cannot be allocated book 1 and book 3, skipping book 2.
Calculate and return that minimum possible number.

NOTE: Return -1 if a valid assignment is not possible.

Problem Constraints
1 <= N <= 105
1 <= A[i], B <= 105

Input Format
The first argument given is the integer array A.
The second argument given is the integer B.

Output Format
Return that minimum possible number.

Example Input
A = [12, 34, 67, 90]
B = 2

Example Output
113

Example Explanation
There are two students. Books can be distributed in following fashion : 

1)  [12] and [34, 67, 90]
    Max number of pages is allocated to student 2 with 34 + 67 + 90 = 191 pages
2)  [12, 34] and [67, 90]
    Max number of pages is allocated to student 2 with 67 + 90 = 157 pages 
3)  [12, 34, 67] and [90]
    Max number of pages is allocated to student 1 with 12 + 34 + 67 = 113 pages
    Of the 3 cases, Option 3 has the minimum pages = 113.
 */

public static class AllocateBooks
{
    public static int solve(List<int> A, int B)
    {
        A.Sort();
        long totalPages = 0; int minMaxPages = int.MinValue;

        for (int i = 0; i < A.Count; i++) {
            totalPages += (long)A[i];
        }

        long l = 1, r = totalPages, mid;

        while (l <= r) {

            mid = (l + r) / 2;

            int ans = allocate(A, mid, B, totalPages);
            minMaxPages = Math.Max(minMaxPages, ans);

            if (ans == -1) {
                l = mid + 1;
            }
            else {
                r = mid - 1;
            }
        }

        if (minMaxPages == int.MaxValue) {
            return -1;
        }

        return (int)minMaxPages;
    }
    
    //minPages - is the minimum number of pages to allocate per student
    private static int allocate(List<int> A, long minPages, int students, long totalPages)
    {
        long minPagesPerStudent = 0, allocatedsofar = 0;
        long maxPages = long.MinValue;

        for (int i = 0; i < A.Count; i++) {

            long val = minPagesPerStudent + (long)A[i];

            if(val <= minPages) {
                minPagesPerStudent += (long)A[i];
            }
            else {
                students--;
                allocatedsofar += minPagesPerStudent;
                maxPages = Math.Max(maxPages, minPagesPerStudent);
                minPagesPerStudent = A[i];
            }
        }

        if (minPagesPerStudent <= minPages && students > 0) {
            students--;
            allocatedsofar += minPagesPerStudent;
        }

        //Allocated atleast one book
        if(students <= 0 && allocatedsofar==totalPages) {
            return (int)maxPages;
        }
        else {
            return -1;
        }
    }
}