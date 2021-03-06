﻿using UnityEngine;

public static class TransformExtensions
{
    public static Transform DestroyAllChildren(this Transform transform)
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        return transform;
    }
}
