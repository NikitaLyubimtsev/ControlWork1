using static System.Console;
Clear();

string[] strings = {"MVC", "DRY", "Stack", "GIT", "Android", "ios", "Lunix", "Windows", ":-)", ":-)0"};
int maxLengthElement = 3;

string[] FindElementInArray(string[] strings, int maxLengthElement)
{
    string[] resArray = Array.Empty<string>();

    for (int i = 0; i < strings.Length; i++)
    {
        if (!(strings[i] is string)) {
            WriteLine($"Элемент номер {i+1} - {strings[i]} не является строкой!");
            Environment.Exit(0);
        }
        if (strings[i].Length <= maxLengthElement) {
            Array.Resize(ref resArray, resArray.Length + 1);
            resArray[resArray.Length - 1] = strings[i];
        }
    }
    return resArray;
}

WriteLine(string.Join(", ", FindElementInArray(strings, maxLengthElement)));