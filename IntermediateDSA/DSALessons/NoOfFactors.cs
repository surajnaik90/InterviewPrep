//Find all the number of factors of N
//Understanding code optimization
//Assumption: 10^8 iterations per second
public static class NoOfFactors
{
    //Approach 1:
    //For N, there would be N iterations
    //So for 10^18 there would be 10^10 seconds => 316 years
    public static int Operation1(int N)
    {
        int output = 0;

        for (int i = 1; i <= N; i++) {

            if (N % i == 0) { output++; }
        }

        return output;
    }

    //Approach 2:
    //For N, there would be sqrt N iterations; Say i*j = N
    // If i is a factor of N then i*j is also a factor of N
    // j can be written as j = N/i. So, i and N/i are factors of N
    // Do this for simple example for N=24. You'll get the logic.
    //So for 10^18 there would be 10^9/10^8 = 10 seconds == Awesome reduction from 316 years to just 10 seconds
    public static int Operation2(int N)
    {
        int output = 0;

        for (int i = 1; i*i <= N; i++)
        {
            if (N % i == 0) { 
            
                if(i==N/i) { output++; }

                else { output = output+2; }
            }
        }

        return output;
    }
}