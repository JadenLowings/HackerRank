public static int simpleArraySum(List<int> ar)
{
    var sum = 0;
    for (var i = 0; i < ar.Count; i++)
    {
        sum += ar[i];
    }
    return sum;
}