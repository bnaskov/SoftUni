using System;
using System.Collections.Generic;
using System.Text;

public static class StringBuilderExtensions
{
    public static string Substring(this StringBuilder strBuild, int startIndex, int length)
    {
        string str = strBuild.ToString();
        string subStr = str.Substring(startIndex, length);
        return subStr;
    }

    public static StringBuilder RemoveText(this StringBuilder str, string text)
    {
        var lenght = text.Length;
        var strAsString = str.ToString();

        while (true)
        {
            int textPosition = strAsString.IndexOf(text, StringComparison.CurrentCultureIgnoreCase);

            if (textPosition < 0)
            {
                break;
            }

            strAsString = strAsString.Remove(textPosition, lenght);
        }

        return str = new StringBuilder(strAsString);
    }

    public static StringBuilder AppendAll<T>(this StringBuilder strBuild, IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            string itemToString = item.ToString();
            strBuild.Append(itemToString);
        }

        return strBuild;
    }
}
