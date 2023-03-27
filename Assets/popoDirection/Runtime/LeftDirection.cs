using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class LeftDirection : Direction
    {
        public override Vector2Int vector2Int => Vector2Int.left;

        public override Vector2 vector2 => Vector2.left;

        public override Vector3Int vector3Int => Vector3Int.left;

        public override Vector3 vector3 => Vector3.left;

        public override int integer => -1;
    }
}