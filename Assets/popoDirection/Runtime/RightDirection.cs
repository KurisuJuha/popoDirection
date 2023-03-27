using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class RightDirection : IDirection2, IDirection4, IDirection8
    {
        public Vector2Int vector2Int => Vector2Int.right;
        public Vector2 vector2 => Vector2.right;
        public Vector3Int vector3Int => Vector3Int.right;
        public Vector3 vector3 => Vector3.right;
        public int integer => 1;
    }
}