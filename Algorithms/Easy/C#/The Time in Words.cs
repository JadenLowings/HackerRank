public static string theWord(int i)
{
    var numberWords = new[]
    {
            "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine", "ten", "eleven",
            "twelve", "thirteen", "fourteen", "fifteen",
            "sixteen", "seventeen", "eighteen", "nineteen",
            "twenty", "twenty one", "twenty two", "twenty three",
            "twenty four", "twenty five", "twenty six",
            "twenty seven", "twenty eight", "twenty nine", "thirty"
        };
    if (i < 0 || i > 30) return "invalid number";
    return numberWords[i];
}

public static string isAdditional(string input)
{
    var additionalWords = new Dictionary<string, string>
        {
            { "fifteen", "quarter" },
            { "thirty", "half" }
        };
    return additionalWords.ContainsKey(input) ? additionalWords[input] : input;
}

public static string timeInWords(int h, int m)
{
    var hours = m > 30 ? theWord(h + 1) : theWord(h);
    if (m == 0)
    {
        return $"{hours} o' clock";
    }
    else if (m <= 30)
    {
        var minutes = isAdditional(theWord(m));
        if (minutes.Contains("quarter") || minutes.Contains("half"))
        {
            return $"{minutes} past {hours}";
        }
        else
        {
            var isMinute = m == 1 ? "minute" : "minutes";
            return $"{minutes} {isMinute} past {hours}";
        }
    }
    else if (m > 30)
    {
        var diff = 60 - m;
        Console.WriteLine(diff);
        var minutes = isAdditional(theWord(diff));
        if (minutes.Contains("quarter")) return $"{minutes} to {hours}";
        return $"{minutes} minutes to {hours}";
    }
    else return "I'm not planning for this. :)";
}