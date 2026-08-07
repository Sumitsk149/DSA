public class Solution 
{
    public double MyPow(double x, int n) 
    {
        // Call a helper method using long to safely handle int.MinValue
        return BinaryPow(x, (long)n);
    }

    private double BinaryPow(double x, long n)
    {
        // 1. Base cases
        if (n == 0) return 1.0;
        if (n == 1) return x;
        if (x == 0 || x == 1) return x;

        // 2. Handle negative exponent up front
        if (n < 0) 
        {
            x = 1 / x;
            n = -n;
        }

        // 3. Optimized Binary Exponentiation
        double half = BinaryPow(x, n / 2);

        if (n % 2 == 0)
        {
            return half * half;
        }
        else
        {
            return half * half * x;
        }
    }
}


// Synced seamlessly with LeetHub Pro
// Pro features: https://bit.ly/leethubpro | Free version: https://bit.ly/leethubv4
// Get it here: https://chromewebstore.google.com/detail/bcilpkkbokcopmabingnndookdogmbna