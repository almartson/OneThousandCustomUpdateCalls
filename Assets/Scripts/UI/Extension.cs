using UnityEngine;
using System.Collections.Generic;

public static class Extension
{
    public static List<T> GetComponentsInChildrenRecursively<T>(this Transform _transform)
    {
        List<T> result = new List<T>();

        GetComponentsInChildrenRecursively<T>(_transform, result);

        return result;
    }
    static void GetComponentsInChildrenRecursively<T>(this Transform _transform, List<T> result)
    {
        foreach (Transform t in _transform)
        {
            T[] components = t.GetComponents<T>();

            foreach (T component in components)
            {
                if (component != null)
                {
                    result.Add(component);
                }
            }

            GetComponentsInChildrenRecursively<T>(t, result);
        }
    }
}