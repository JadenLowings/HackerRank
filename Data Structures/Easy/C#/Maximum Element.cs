public static List<int> getMax(List<string> operations)
{
    // 1 - push element to stack
    // 2 - delete element at the top of the stack
    // 3 - print the max element in the stack 

    var result = new List<int>();
    var stack = new Stack<int>();
    var maxStack = new Stack<int>();
    for (var i = 0; i < operations.Count; i++)
    {
        var splitRes = operations[i].Split(' ');
        switch (splitRes[0])
        {
            case "1":
                var item = int.Parse(splitRes[1]);
                stack.Push(item);
                if (maxStack.Count == 0 || item >= maxStack.Peek())
                {
                    maxStack.Push(item);
                }
                break;
            case "2":
                var itemPopped = stack.Pop();
                if (maxStack.Count > 0 && itemPopped == maxStack.Peek())
                {
                    var popMax = maxStack.Pop();
                };
                break;
            case "3":
                if (maxStack.Count > 0)
                {
                    result.Add(maxStack.Peek());
                }
                break;
        }
    }

    return result;

    // var altList = new List<int>();
    // for (var i = 0; i < operations.Count; i++) 
    // {
    //     var query = operations[i].Split(' ');
    //     var max = 0;
    //     switch(query[0])
    //     {
    //         case "1":
    //             var value = Convert.ToInt32(query[1]);
    //             if (max < value) max = value;
    //             // Console.WriteLine("Push");
    //             altList.Add(value);
    //             break;
    //         case "2":
    //             // Console.WriteLine("Delete");
    //             altList.RemoveAt(altList.Count - 1);
    //             break;
    //         case "3":
    //             Console.WriteLine(max);
    //             break;
    //     }
    // }
    // return altList;
}

}