public static long aVeryBigSum(List<long> ar)
{
    // return ar.Sum();
    var sum = 0L;
    for (var i = 0; i < ar.Count; i++)
    {
        sum += ar[i];
    }
    return sum;
}