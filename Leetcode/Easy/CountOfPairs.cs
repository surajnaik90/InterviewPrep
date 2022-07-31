/*
 You are given two non-empty linked lists representing two non-negative integers.
 The digits are stored in reverse order, and each of their nodes contains a single digit. 
 Add the two numbers and return the sum as a linked list.

 You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 Input: l1 = [2,4,3], l2 = [5,6,4]
 Output: [7,0,8]
 Explanation: 342 + 465 = 807.
*/
public static class CountOfPairs
{
    public static int Operation1(List<int> a, int b)
    {
        int count = 0;

        for (int i = 0; i < a.Count; i++)
        {
            for (int j = i+1; j < a.Count; j++)
            {
                if (a[i] + a[j] == b) { count++;}
            }
        }

        return count;
    }

    public static int Operation2(int A, int B, int C)
    {
        int result = 0, powRes = 1, modRes = 0;
        
        if(A==0 && B==0) { powRes = 0; }

        for (int i = 0; i < B; i++) {
            powRes = A * powRes;
        }

        if(powRes < 0) {

            int temp;

            if ((-1 * powRes) > C) {
                temp = (-1 * (powRes)) / C;
                modRes = temp - C;

                return modRes;
            }
            else { 
                modRes = C - (-powRes);
                return modRes;
            }
        }

        modRes = powRes / C;

        return modRes;
    }

    public static int Operation3(List<int> A)
    {
        int result = 0, even = 0, odd = 0, temp =0, element =0;
        bool isoddSet = false;

        for (int i = 0; i < A.Count; i++)
        {
            element = A[i];

            if (element < 0) { element = -(element); }

            temp = element % 2;
            
            if(temp==0) {

                if (A[i] <0 && A[i] <=even) { even = A[i]; }

                if (A[i] >= even) { even = A[i]; }
            }
            else {

                if(!isoddSet) {
                    odd = A[i]; isoddSet = true;
                }

                if (A[i] <= odd) { odd = A[i]; }
            }
        }

        result = even - odd; 

        return result;
    }
}