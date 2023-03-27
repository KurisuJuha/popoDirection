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

        private static Direction lastInputDirection;
        private static int lastInputDirectionRecordFrame;

        public static Direction inputDirection4Y => GetInputDirection4(true);
        public static Direction inputDirection4X => GetInputDirection4(false);

        public static Direction GetInputDirection4(bool y = true)
        {
            if (lastInputDirectionRecordFrame == Time.frameCount) return lastInputDirection;

            lastInputDirection = ToDirection4(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), y);
            return lastInputDirection;
        }

        public static Direction ToDirection4(Vector2 vec, bool y = true)
            => y ? ToDirection4Y(vec) : ToDirection4X(vec);

        public static Direction ToDirection4Y(Vector2 vec)
        {
            if (vec.y > 0) return upDirection;
            if (vec.y < 0) return downDirection;
            if (vec.x > 0) return rightDirection;
            if (vec.x < 0) return leftDirection;

            return noDirection;
        }

        public static Direction ToDirection4X(Vector2 vec)
        {
            if (vec.x > 0) return rightDirection;
            if (vec.x < 0) return leftDirection;
            if (vec.y > 0) return upDirection;
            if (vec.y < 0) return downDirection;

            return noDirection;
        }
    }
}