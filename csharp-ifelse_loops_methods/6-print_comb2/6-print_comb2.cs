string result = "";
for (int i = 0; i < 10; i++)
{
    for (int j = i + 1; j < 10; j++)
    {
        if (result != "")
            result += ", ";
        result += $"{i}{j}";
    }
}
Console.WriteLine(result);