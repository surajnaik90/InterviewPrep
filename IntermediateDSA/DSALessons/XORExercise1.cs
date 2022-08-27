/* In ana array every element is repeating twice.Find the unique element
 * 
 * A = [6,9,6,10,9]
 * 
 * output = 10
 */
public static class XORExercise1
{   

    //Awesome XOR programming example to find the unique element.
    public static int Operation1(List<int> A)
    {
        int output = 0;

        for (int i = 0; i < A.Count; i++)
        {
            output ^= A[i];
        }

        return output;
    }
}