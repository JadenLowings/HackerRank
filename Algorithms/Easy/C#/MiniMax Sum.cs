public static void miniMaxSum(List<int> arr)
{
    //LINQ
    // arr.Sort();
    // var min = arr.Where(x => x != arr.Last()).Sum();
    // var max = arr.Where(x => x != arr.First()).Sum();
    // Console.WriteLine(min + " " + max);

    var min = int.MaxValue;
    var max = int.MinValue;
    var sum = 0L;

    for (var i = 0; i < arr.Count; i++)
    {
        sum += arr[i];
        if (arr[i] < min) min = arr[i];
        else if (arr[i] > max) max = arr[i];

    }
    Console.WriteLine((sum - max) + " " + (sum - min));
}