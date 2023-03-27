using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public class DownDirection : Direction
    {
        public override Vector2Int vector2Int => Vector2Int.down;

        public override Vector2 vector2 => Vector2.down;

        public override Vector3Int vector3Int => Vector3Int.down;

        public override Vector3 vector3 => Vector3.down;

        public override int integer => -1;
    }
}