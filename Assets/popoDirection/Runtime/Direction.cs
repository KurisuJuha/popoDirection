using UnityEngine;

namespace JuhaKurisu.PopoTools.DirectionUtility
{
    public static class Direction
    {
        /// <summary>
        /// 右方向
        /// </summary>
        public readonly static RightDirection rightDirection = new();
        /// <summary>
        /// 左方向
        /// </summary>
        public readonly static LeftDirection leftDirection = new();
        /// <summary>
        /// 上方向
        /// </summary>
        public readonly static UpDirection upDirection = new();
        /// <summary>
        /// 下方向
        /// </summary>
        public readonly static DownDirection downDirection = new();
        /// <summary>
        /// 無方向
        /// </summary>
        public readonly static NoDirection noDirection = new();
        /// <summary>
        /// 右上方向
        /// </summary>
        public readonly static RightUpperDirection rightUpperDirection = new();
        /// <summary>
        /// 右下方向
        /// </summary>
        public readonly static RightLowerDirection rightLowerDirection = new();
        /// <summary>
        /// 左上方向
        /// </summary>
        public readonly static LeftUpperDirection leftUpperDirection = new();
        /// <summary>
        /// 左下方向
        /// </summary>
        public readonly static LeftLowerDirection leftLowerDirection = new();

        private static IDirection lastInputDirection;
        private static int lastInputDirectionRecordFrame;

        /// <summary>
        /// inputをもとにy軸を優先したdirection
        /// </summary>
        public static IDirection inputDirection4Y => GetInputDirection4(true);
        /// <summary>
        /// inputをもとにx軸を優先したdirection
        /// </summary>
        public static IDirection inputDirection4X => GetInputDirection4(false);

        /// <summary>
        /// InputをもとにDirectionを計算する
        /// </summary>
        /// <param name="y">y軸を優先するかどうか</param>
        /// <returns>inputをもとにしたDirection</returns>
        public static IDirection GetInputDirection4(bool y = true)
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
        public static IDirection ToDirection4(Vector2 vec, bool y = true)
            => y ? ToDirection4Y(vec) : ToDirection4X(vec);

        /// <summary>
        /// vector2をもとにy軸を優先したDirectionを計算する
        /// </summary>
        /// <param name="vec">もとにするVector2</param>
        /// <returns>vector2をもとにy軸を優先したDirection</returns>
        public static IDirection ToDirection4Y(Vector2 vec)
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
        public static IDirection ToDirection4X(Vector2 vec)
        {
            if (vec.x > 0) return rightDirection;
            if (vec.x < 0) return leftDirection;
            if (vec.y > 0) return upDirection;
            if (vec.y < 0) return downDirection;

            return noDirection;
        }
    }
}