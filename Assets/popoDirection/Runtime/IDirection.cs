using UnityEngine;

public interface IDirection
{
    public Vector2Int vector2Int { get; }
    public Vector2 vector2 { get; }
    public Vector3Int vector3Int { get; }
    public Vector3 vector3 { get; }
}