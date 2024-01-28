package OOPs;

public class FirstOccurrence {
    public int solve(final String A, final int B) {

        for (int i = 0; i < A.length(); i++) {

            if((int)(A.charAt(i)) == B){
                return i;
            }
        }

        /* Or this way as well
        for (int i = 0; i < N;i++){
            // If ascii value of character at ith postion is equal to B
            if(A.charAt(i) == B){
                idx = i;
                break;
            }
        }
        */

        return -1;
    }
}
