public static int nextMultiple(int i)
{
    int nextMultipleOfFive = ((i / 5) + 1) * 5;
    return nextMultipleOfFive - i < 3 ? nextMultipleOfFive : i;
}
public static List<int> gradingStudents(List<int> grades)
{
    for (var i = 0; i < grades.Count; i++)
    {
        if (grades[i] < 38) continue;
        var nextUp = nextMultiple(grades[i]);
        grades[i] = nextUp;
    }
    return grades;
}