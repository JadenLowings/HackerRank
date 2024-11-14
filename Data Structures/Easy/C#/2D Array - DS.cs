public static int hourglassSum(List<List<int>> arr)
{
    var sum = int.MinValue;
    for (var i = 0; i < arr.Count - 2; i++)
    {
        for (var x = 0; x < arr[i].Count - 2; x++)
        {
            var rowOne = arr[i][x] + arr[i][x + 1] + arr[i][x + 2];
            var rowTwo = arr[i + 1][x + 1];
            var rowThree = arr[i + 2][x] + arr[i + 2][x + 1] + arr[i + 2][x + 2];

            sum = Math.Max(sum, (rowOne + rowTwo + rowThree));
        }
    }
    return sum;
}