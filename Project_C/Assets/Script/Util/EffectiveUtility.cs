﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EffectiveUtility
{
    public static Vector3 VectorMultiple(Vector3 l, Vector3 r)
    {
        return new Vector3(l.x * r.x, l.y * r.y, l.z * r.z);
    }

    public static Vector3Int IsoPositionToIndex(Vector3 isoPos)
    {
        return new Vector3Int((int)Mathf.Round(isoPos.x / Isometric.IsometricTileSize.x),
            (int)Mathf.Round(isoPos.y / Isometric.IsometricTileSize.y),
            (int)Mathf.Round(isoPos.z / Isometric.IsometricTileSize.z));
    }

    public static Vector3 RoundPixelPerfect(Vector3 worldPos)
    {
        return new Vector3(Mathf.Round(worldPos.x * 100f) * 0.01f,
            Mathf.Round(worldPos.y * 100f) * 0.01f,
            Mathf.Round(worldPos.z * 100f) * 0.01f);
    }

    public static Vector3Int Min(Vector3Int a, Vector3Int b)
    {
        return new Vector3Int(Mathf.Min(a.x, b.x), Mathf.Min(a.y, b.y), Mathf.Min(a.z, b.z));
    }

    public static Vector3Int Max(Vector3Int a, Vector3Int b)
    {
        return new Vector3Int(Mathf.Max(a.x, b.x), Mathf.Max(a.y, b.y), Mathf.Max(a.z, b.z));
    }
}
