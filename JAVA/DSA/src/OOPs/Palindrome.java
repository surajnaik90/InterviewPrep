package OOPs;

public class Palindrome {
    public static boolean isPalin(String s) {

        int i = 0, j = s.length() - 1;

        while(i <= j) {
            if(s.charAt(i++) == s.charAt(j--)) {
                continue;
            }
            else {
                return false;
            }
        }

        return true;
    }
}
