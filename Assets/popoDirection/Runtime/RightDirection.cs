using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class RightDirection : Direction
    {
        public override Vector2Int vector2Int => Vector2Int.right;

        public override Vector2 vector2 => Vector2.right;

        public override Vector3Int vector3Int => Vector3Int.right;

        public override Vector3 vector3 => Vector3.right;

        public override int integer => 1;
    }
}