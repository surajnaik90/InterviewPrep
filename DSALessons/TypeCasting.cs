/* Let's understand how typecasting works 

 */

public static class TypeCasting
{
    public static void solve()
    {
        // 0,000,000,002,147,483,647 - Int Max value (10 digits)
        // 9,223,372,036,854,775,807 - Long Max value (19 digits)

        long a = long.MaxValue;
        long b = 3;

        long res = checked(a + b);
        
    }
}