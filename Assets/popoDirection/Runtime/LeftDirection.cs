using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class LeftDirection : IDirection4, IDirection8
    {
        public Vector2Int vector2Int => Vector2Int.left;
        public Vector2 vector2 => Vector2.left;
        public Vector3Int vector3Int => Vector3Int.left;
        public Vector3 vector3 => Vector3.left;
    }
}