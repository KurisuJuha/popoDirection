using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class NoDirection : Direction
    {
        public override Vector2Int vector2Int => Vector2Int.zero;

        public override Vector2 vector2 => Vector2.zero;

        public override Vector3Int vector3Int => Vector3Int.zero;

        public override Vector3 vector3 => Vector3.zero;

        public override int integer => 0;
    }
}