

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        String A = "bebdeeedaddecebbbbbabebedc";
        String B = "abaaddaabbedeedeacbcdcaaed";

        int ans = LongestCommonSubsequence.solve(A,B);

        System.out.println(ans);
    }
}