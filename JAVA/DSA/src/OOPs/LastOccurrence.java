package OOPs;

public class LastOccurrence {
    public int solve(final String A, final int B) {

        for (int i = A.length() - 1; i >= 0; i--) {

            if(A.charAt(i) == B){
                return i;
            }
        }

        return -1;
    }
}
