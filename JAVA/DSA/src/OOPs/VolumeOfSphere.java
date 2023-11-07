package OOPs;

public class VolumeOfSphere {
    public static int calculate(final int n){

        double r3 = (((double) Math.pow(n,3)) * 4) / 3;

        double div = r3 * (Math.PI);

        double val = (double) Math.ceil(div);

        int finalV = (int) val;

        return finalV;
    }
}
