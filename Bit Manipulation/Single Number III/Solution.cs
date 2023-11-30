class Solution
{
    public List<int> solve(List<int> A)
    {
        //xor all elements to get xor of two unique elements
        int xor = 0;
        for (int i = 0; i < A.Count; i++)
        {
            xor ^= A[i];
        }

        //get position of set bit from xor 
        int pos = 0;
        for (int i = 0; i < 32; i++)
        {
            if (isSetBit(xor, i))
            {
                pos = i;
                break;
            }
        }

        //Divide number in two parts, one with set on given position and one with not set
        //so that one unique element in one part & another in second part 
        int xor1 = 0;
        int xor2 = 0;
        for (int i = 0; i < A.Count; i++)
        {
            if (isSetBit(A[i], pos))
                xor1 ^= A[i];
            else
                xor2 ^= A[i];
        }

        if (xor1 > xor2)
            return new List<int> { xor2, xor1 };
        return new List<int> { xor1, xor2 };
    }

    public bool isSetBit(int num, int pos)
    {
        if ((num & (1 << pos)) > 0)
            return true;
        return false;
    }

}
