public static void staircase(int n)
{
    for (var i = 1; i <= n; i++)
    {
        var spacing = new string(' ', n - i);
        var stair = new string('#', i);
        Console.WriteLine(spacing + stair);
    }
}