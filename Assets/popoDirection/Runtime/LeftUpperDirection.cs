using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class LeftUpperDirection : IDirection8
    {
        public Vector2Int vector2Int => _vector2Int;
        private readonly Vector2Int _vector2Int = new(-1, 1);
        public Vector2 vector2 => _vector2;
        private readonly Vector2 _vector2 = new(-1, 1);
        public Vector3Int vector3Int => _vector3Int;
        private readonly Vector3Int _vector3Int = new(-1, 1);
        public Vector3 vector3 => _vector3;
        private readonly Vector3 _vector3 = new(-1, 1);
    }
}