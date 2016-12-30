
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
        float dx, dy;
        public void SetDes(float x, float y)
        {
            dx = x;
            dy = y;
            Enabled = !MathUtils.Dist(Owner.Px, Owner.Py, dx, dy).Almost0();
            MathUtils.Normalize(ref x, ref y);
            Owner.Dx = x;
            Owner.Dy = y;
        }

        // 根据时间移动位置
        public override void OnTimeElapsed(int te)
        {
            if (!Enabled)
                return;

            float d = Owner.Speed * te;
            float px, py;
            if (MathUtils.DistPt(Owner.Px, Owner.Py, dx, dy, d, out px, out py).Almost0())
                Enabled = false;

            Owner.Px = px;
            Owner.Py = py;
        }
    }
}
