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

        public static Direction ToDirection4(Vector2 vec, bool y = true)
        {
            if (vec == Vector2.zero) return noDirection;

            if (y)
            {
                if (vec.y > 0) return upDirection;
                else return downDirection;
            }
            else
            {
                if (vec.x > 0) return rightDirection;
                else return leftDirection;
            }
        }
    }
}