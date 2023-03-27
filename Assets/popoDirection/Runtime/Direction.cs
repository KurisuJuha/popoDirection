using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public abstract class Direction
    {
        /// <summary>
        /// vector2intにした値
        /// </summary>
        public abstract Vector2Int vector2Int { get; }
        /// <summary>
        /// vector2にした値
        /// </summary>
        public abstract Vector2 vector2 { get; }
        /// <summary>
        /// vector3intにした値
        /// </summary>
        public abstract Vector3Int vector3Int { get; }
        /// <summary>
        /// vector3にした値
        /// </summary>
        public abstract Vector3 vector3 { get; }
        /// <summary>
        /// 軸を一つにした場合の向き
        /// </summary>
        public abstract int integer { get; }

        /// <summary>
        /// 右方向
        /// </summary>
        public readonly static RightDirection rightDirection = new RightDirection();
        /// <summary>
        /// 左方向
        /// </summary>
        public readonly static LeftDirection leftDirection = new LeftDirection();
        /// <summary>
        /// 上方向
        /// </summary>
        public readonly static UpDirection upDirection = new UpDirection();
        /// <summary>
        /// 下方向
        /// </summary>
        public readonly static DownDirection downDirection = new DownDirection();
        /// <summary>
        /// 無方向
        /// </summary>
        public readonly static NoDirection noDirection = new NoDirection();

        private static Direction lastInputDirection;
        private static int lastInputDirectionRecordFrame;

        /// <summary>
        /// inputをもとにy軸を優先したdirection
        /// </summary>
        public static Direction inputDirection4Y => GetInputDirection4(true);
        /// <summary>
        /// inputをもとにx軸を優先したdirection
        /// </summary>
        public static Direction inputDirection4X => GetInputDirection4(false);

        /// <summary>
        /// InputをもとにDirectionを計算する
        /// </summary>
        /// <param name="y">y軸を優先するかどうか</param>
        /// <returns>inputをもとにしたDirection</returns>
        public static Direction GetInputDirection4(bool y = true)
        {
            if (lastInputDirectionRecordFrame == Time.frameCount) return lastInputDirection;

            lastInputDirection = ToDirection4(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), y);
            return lastInputDirection;
        }

        /// <summary>
        /// Vector2をもとにDirectionを計算する
        /// </summary>
        /// <param name="vec">基にするVector2</param>
        /// <param name="y">y軸を優先するかどうか</param>
        /// <returns></returns>
        public static Direction ToDirection4(Vector2 vec, bool y = true)
            => y ? ToDirection4Y(vec) : ToDirection4X(vec);

        /// <summary>
        /// vector2をもとにy軸を優先したDirectionを計算する
        /// </summary>
        /// <param name="vec">もとにするVector2</param>
        /// <returns>vector2をもとにy軸を優先したDirection</returns>
        public static Direction ToDirection4Y(Vector2 vec)
        {
            if (vec.y > 0) return upDirection;
            if (vec.y < 0) return downDirection;
            if (vec.x > 0) return rightDirection;
            if (vec.x < 0) return leftDirection;

            return noDirection;
        }

        /// <summary>
        /// vector2をもとにx軸を優先したDirectionを計算する
        /// </summary>
        /// <param name="vec">もとにするVector2</param>
        /// <returns>vector2をもとにx軸を優先したDirection</returns>
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