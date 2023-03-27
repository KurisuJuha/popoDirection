using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public abstract class Direction
    {
        public abstract Vector2Int vector2Int { get; }
        public abstract Vector2 vector2 { get; }
        public abstract Vector3Int vector3Int { get; }
        public abstract Vector3 vector3 { get; }
        public abstract int integer { get; }

        public readonly static RightDirection rightDirection = new RightDirection();
        public readonly static LeftDirection leftDirection = new LeftDirection();
        public readonly static UpDirection upDirection = new UpDirection();
        public readonly static DownDirection downDirection = new DownDirection();
        public readonly static NoDirection noDirection = new NoDirection();
    }
}