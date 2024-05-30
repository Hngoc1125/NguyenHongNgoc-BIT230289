public static int CountOccurrences(string inputString, string searchString)
{
    if (string.IsNullOrEmpty(searchString)){
        return 0;
    }
    int count = 0;
    int index = 0;
    while (index != -1){
        index = inputString.IndexOf(searchString, index);
        if (index != -1){
            count++;
            index += searchString.Length;
        }
    }

    return count;
}