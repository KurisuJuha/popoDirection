using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class DownDirection : IDirection2, IDirection4, IDirection8
    {
        public Vector2Int vector2Int => Vector2Int.down;
        public Vector2 vector2 => Vector2.down;
        public Vector3Int vector3Int => Vector3Int.down;
        public Vector3 vector3 => Vector3.down;
        public int integer => -1;
    }
}