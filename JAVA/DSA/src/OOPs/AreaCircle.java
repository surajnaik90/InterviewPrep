package OOPs;

/*You are given a positive integer A denoting the radius of a circle. You have to calculate the area of the circle.

Note :

The formula for the area of a circle is Area = πr², where r is the radius of the circle.
You can use the value of PI as 3.1416
Round up the final answer up to 2 decimal places. You can use round(area, 2) it for rounding area to 2 decimal places


Problem Constraints

1 <= A <= 1000



Input Format

First and only argument is an integer A.



Output Format

Return a single integer denoting the ceil value of area of the circle.



Example Input

Input 1:
8

Input 2:
15



Example Output

Output 1:
201.06

Output 2:
706.86*/
public class AreaCircle {

    public static double solve(int A) {

        double area = Math.pow(A,2) * (Math.PI);

        double ans = (double) Math.round(area * 100) / 100;

        return ans;
    }
}
