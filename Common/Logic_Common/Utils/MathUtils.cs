using System;
using System.Collections;
using System.Collections.Generic;
using Swift;

namespace Nova
{
    /// <summary>
    /// 数学工具类
    /// </summary>
    public static class MathUtils
    {
        // 给定浮点数是否可以认为是 0
        public static bool Almost0(this float f)
        {
            return Math.Abs(f) < 0.01f;
        }

        // 求两点距离
        public static float Dist(float x1, float y1, float x2, float y2)
        {
            var dx = x1 - x2;
            var dy = y1 - y2;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        // 求起点开始，往终点方向的指定距离位置
        public static float DistPt(float x1, float y1, float x2, float y2, float dist, out float px, out float py)
        {
            var dx = x1 - x2;
            var dy = y1 - y2;
            var d = (float)Math.Sqrt(dx * dx + dy * dy);
            if (d.Almost0())
            {
                px = x2;
                py = y2;
            }
            else
            {
                px = x1 + dist * dx / d;
                py = y1 + dist * dy / d;
            }

            return d;
        }

        // 正规化指定向量
        public static float Normalize(ref float x, ref float y)
        {
            var d = (float)Math.Sqrt(x * x + y * y);
            if (!d.Almost0())
            {
                x /= d;
                y /= d;
            }

            return d;
        }

        // 判断给定数是否在某个范围内
        static bool IsInner(this float f, float a, float b)
        {
            if (a >= b)
                return f >= b && f <= a;
            else
                return f >= a && f <= b;
        }

        // 规范化向量与弧度的对应表
        static float[][] ArcTb = new float[][]
        {
            new float[] { 1f, 0f, 0f },          // 0/32 Pi
            new float[] { 0.9807853f, 0.1950903f, 0.1963495f },          // 1/32 Pi
            new float[] { 0.9238795f, 0.3826835f, 0.3926991f },          // 2/32 Pi
            new float[] { 0.8314696f, 0.5555702f, 0.5890486f },          // 3/32 Pi
            new float[] { 0.7071068f, 0.7071068f, 0.7853982f },          // 4/32 Pi
            new float[] { 0.5555702f, 0.8314696f, 0.9817477f },          // 5/32 Pi
            new float[] { 0.3826834f, 0.9238795f, 1.178097f },          // 6/32 Pi
            new float[] { 0.1950904f, 0.9807853f, 1.374447f },          // 7/32 Pi
            new float[] { -4.371139E-08f, 1f, 1.570796f },          // 8/32 Pi
            new float[] { -0.1950903f, 0.9807853f, 1.767146f },          // 9/32 Pi
            new float[] { -0.3826834f, 0.9238796f, 1.963495f },          // 10/32 Pi
            new float[] { -0.5555702f, 0.8314697f, 2.159845f },          // 11/32 Pi
            new float[] { -0.7071068f, 0.7071068f, 2.356194f },          // 12/32 Pi
            new float[] { -0.8314697f, 0.5555702f, 2.552544f },          // 13/32 Pi
            new float[] { -0.9238795f, 0.3826835f, 2.748893f },          // 14/32 Pi
            new float[] { -0.9807853f, 0.1950903f, 2.945243f },          // 15/32 Pi
            new float[] { -1f, -8.742278E-08f, 3.141593f },          // 16/32 Pi
            new float[] { -0.9807853f, -0.1950902f, 3.337942f },          // 17/32 Pi
            new float[] { -0.9238795f, -0.3826834f, 3.534292f },          // 18/32 Pi
            new float[] { -0.8314695f, -0.5555703f, 3.730641f },          // 19/32 Pi
            new float[] { -0.7071068f, -0.7071067f, 3.926991f },          // 20/32 Pi
            new float[] { -0.5555704f, -0.8314695f, 4.12334f },          // 21/32 Pi
            new float[] { -0.3826836f, -0.9238795f, 4.31969f },          // 22/32 Pi
            new float[] { -0.1950904f, -0.9807853f, 4.516039f },          // 23/32 Pi
            new float[] { 1.192488E-08f, -1f, 4.712389f },          // 24/32 Pi
            new float[] { 0.1950904f, -0.9807853f, 4.908739f },          // 25/32 Pi
            new float[] { 0.3826836f, -0.9238794f, 5.105088f },          // 26/32 Pi
            new float[] { 0.5555701f, -0.8314697f, 5.301437f },          // 27/32 Pi
            new float[] { 0.7071066f, -0.7071069f, 5.497787f },          // 28/32 Pi
            new float[] { 0.8314696f, -0.5555703f, 5.694137f },          // 29/32 Pi
            new float[] { 0.9238796f, -0.3826834f, 5.890486f },          // 30/32 Pi
            new float[] { 0.9807853f, -0.1950902f, 6.086836f },          // 31/32 Pi
            new float[] { 1f, 0f, 6.283185f },          // 32/32 Pi
        };

        // 查表求向量的方向距离（弧度）
        public static float Arc(float vx, float vy)
        {
            if (Normalize(ref vx, ref vy).Almost0())
                return 0;

            for (int i = 1; i < ArcTb.Length; i++)
            {
                var a1 = ArcTb[i - 1];
                var a2 = ArcTb[i];
                if (vx.IsInner(a1[0], a2[0]) && vy.IsInner(a1[1], a2[1]))
                {
                    var divx = (vx - a1[0]) / (a2[0] - a1[0]);
                    var divy = (vy - a1[1]) / (a2[1] - a1[1]);
                    var div = (divx + divy) / 2;
                    var arc = (a2[2] - a1[2]) * div + a1[2];
                    return arc;
                }
            }

            throw new Exception($"CalcVectorArc overflow: {vx}, {vy}");
        }
    }
}
