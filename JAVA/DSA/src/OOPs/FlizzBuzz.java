package OOPs;

import java.util.Scanner;

public class FlizzBuzz {

    public static void print() {

        Scanner sc = new Scanner(System.in);

        int a = Integer.parseInt(sc.nextLine().trim());

        if(a%3 == 0 && a%5 ==0){
            System.out.println("FizzBuzz");
        }
        else if(a%3==0) {
            System.out.println("Fizz");
        }
        else if(a%5==0){
            System.out.println("Buzz");
        }
        else {

        }
    }
}
