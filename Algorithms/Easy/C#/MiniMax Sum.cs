public static void miniMaxSum(List<int> arr)
{
    //LINQ
    // long totalSum = arr.Select(x => (long)x).Sum();
    // var min = arr.Min();
    // var max = arr.Max();

    // var minSum = totalSum - max;
    // var maxSum = totalSum - min; 
    // Console.WriteLine($"{minSum} {maxSum}");

    var min = int.MaxValue;
    var max = int.MinValue;
    var sum = 0L;

    for (var i = 0; i < arr.Count; i++)
    {
        sum += arr[i];
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];

    }
    Console.WriteLine($"{sum - max} {sum - min}");
}