using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    public static void AddToDictionary<TKey, TValue>
        (IDictionary<TKey, TValue> target, TKey[] keys, TValue[] values)
    {
        for (int i = 0; i < keys.Length; i++)
        {
            target.Add(keys[i], values[i]);
        }
    }

    public static void AddToList<T>(List<T> list, params T[] items)
    {
        list.AddRange(items);
    }
}
