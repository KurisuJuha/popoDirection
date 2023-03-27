using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class UpDirection : Direction
    {
        public override Vector2Int vector2Int => Vector2Int.up;

        public override Vector2 vector2 => Vector2.up;

        public override Vector3Int vector3Int => Vector3Int.up;

        public override Vector3 vector3 => Vector3.up;

        public override int integer => 1;
    }
}