package OOPs;

import java.util.Scanner;

public class ConfusionInElectricity {
    public static void print() {

        Scanner sc = new Scanner(System.in);

        int units = Integer.parseInt(sc.nextLine().trim());

        double bill = 0;

        double remUnits = units - 50;
        if(remUnits >= 0) {
            bill += 50 * (0.5);
        }
        else {
            bill += units * (0.5);
            bill+=  (bill) * (0.2);
            System.out.println((int)bill);
            return;
        }

        if((remUnits - 100)>= 0) {
            bill += 100 * (0.75);
            remUnits = remUnits - 100;
        }
        else {
            bill += remUnits * (0.75);
            bill+=  (bill) * (0.2);
            System.out.println((int)bill);
            return;
        }

        if((remUnits - 100) >= 0) {
            bill += 100 * (1.2);
            remUnits = remUnits - 100;
        }
        else {
            bill += remUnits * (1.2);
            bill+=  (bill) * (0.2);
            System.out.println((int)bill);
            return;
        }

        if(remUnits >= 0) {
            bill += remUnits * (1.5);
        }
        bill+=  (bill) * (0.2);
        System.out.println((int)bill);
    }
}
