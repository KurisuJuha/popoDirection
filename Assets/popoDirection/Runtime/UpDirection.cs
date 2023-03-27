using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class UpDirection : IDirection2, IDirection4, IDirection8
    {
        public Vector2Int vector2Int => Vector2Int.up;
        public Vector2 vector2 => Vector2.up;
        public Vector3Int vector3Int => Vector3Int.up;
        public Vector3 vector3 => Vector3.up;
        public int integer => 1;
    }
}