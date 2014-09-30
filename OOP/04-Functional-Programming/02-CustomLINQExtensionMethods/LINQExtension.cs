using System;
using System.Collections.Generic;
using System.Linq;

public static class LINQExtension
{
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.Where(x => !predicate(x));
    }

    public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) 
    {
        for (int i = 0; i < count; i++)
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
    {
        foreach (string item in collection)
        {
            foreach (string suffix in suffixes)
            {
                if (item.EndsWith(suffix))
                {
                    yield return item;
                }
            }
        }
    }

    //public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
    //{
    //    IList<string> results = new List<string>();
    //    foreach (string item in collection)
    //    {
    //        foreach (string suffix in suffixes)
    //        {
    //            if (item.EndsWith(suffix))
    //            {
    //                results.Add(item);
    //            }
    //        }
    //    }

    //    return results as IEnumerable<string>;
    //}
}
