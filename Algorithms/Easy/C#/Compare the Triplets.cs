public static List<int> compareTriplets(List<int> a, List<int> b)
{
    int aCount = 0;
    int bCount = 0;

    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > b[i])
            aCount++;
        else if (a[i] < b[i])
            bCount++;
    }

    return new List<int> { aCount, bCount };
}