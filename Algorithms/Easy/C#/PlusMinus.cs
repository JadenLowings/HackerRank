public static void plusMinus(List<int> arr)
{
    // LINQ
    // var count = arr.Count;
    // writeMe(arr.Count(x => x > 0), count);
    // writeMe(arr.Count(x => x < 0), count);
    // writeMe(arr.Count(x => x == 0), count);

    var pos = 0.0;
    var neg = 0.0;
    var zero = 0.0;
    var count = arr.Count;
    for (var i = 0; i < count; i++)
    {
        if (arr[i] == 0) zero++;
        else if (arr[i] > 0) pos++;
        else neg++;
    }
    writeMe(pos, count);
    writeMe(neg, count);
    writeMe(zero, count);
}

public static void writeMe(double input, int count)
{
    Console.WriteLine((input / count).ToString("F6"));
}