using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class NoDirection : IDirection2, IDirection4, IDirection8
    {
        public Vector2Int vector2Int => Vector2Int.zero;
        public Vector2 vector2 => Vector2.zero;
        public Vector3Int vector3Int => Vector3Int.zero;
        public Vector3 vector3 => Vector3.zero;
        public int integer => 0;
    }
}