public static List<int> rotateLeft(int d, List<int> arr)
{
    for (var i = 0; i < d; i++)
    {
        var first = arr[0];
        arr.RemoveAt(0);
        arr.Add(first);
    }
    return arr;
}