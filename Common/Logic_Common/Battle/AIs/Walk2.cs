using System.Collections.Generic;

namespace Nova
{
    /// <summary>
    /// 行走到指定地点
    /// </summary>
    public class Walk2 : AI
    {
        public Walk2() : base() { }
        public Walk2(Actor o) : base(o) { }

        // 设置指定行走目标点，角色会立刻朝向指定方向
        List<float[]> pts = new List<float[]>();
        float cx, cy, cd;
        public void SetPath(IEnumerable<float[]> ps)
        {
            pts.Clear();
            var lastPx = Owner.Px;
            var lastPy = Owner.Py;
            pts.Add(new float[] { Owner.Px, Owner.Py, 0 });
            foreach (var p in ps)
            {
                var x = p[0];
                var y = p[1];
                var d = MathUtils.Dist(lastPx, lastPy, x, y);
                if (d.Almost0())
                    continue;

                pts.Add(new float[] { x, y, d });
            }

            Enabled = pts.Count > 1;
            cx = pts[0][0];
            cy = pts[0][1];
            cd = pts[0][2];
        }

        // 停止行走
        public void Stop()
        {
            Owner.Px = cx;
            Owner.Py = cy;
            pts.Clear();
            Enabled = false;
        }

        // 根据时间移动位置
        public override void OnTimeElapsed(int te)
        {
            if (!Enabled)
                return;

            // 直接丢弃在指定步长内越过的点
            var d = Owner.Speed * te;
            while (d >= cd && pts.Count > 0)
            {
                d -= cd;
                Owner.Py = pts[0][0];
                Owner.Py = pts[0][1];
                pts.RemoveAt(0);
            }

            // 到终点就结束
            if (pts.Count == 0)
            {
                Stop();
                return;
            }

            // 计算下一目标点
            cx = pts[0][0];
            cy = pts[0][1];
            cd = pts[0][2];
            float x, y;
            MathUtils.DistPt(Owner.Px, Owner.Py, cx, cy, cd, out x, out y);
            cd -= d;

            // 更新位置
            Owner.Px = x;
            Owner.Py = y;
        }
    }
}
