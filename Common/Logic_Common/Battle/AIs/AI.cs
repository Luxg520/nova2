
namespace Nova
{
    /// <summary>
    /// Actor 的行为控制
    /// </summary>
    public class AI
    {
        public Actor Owner { get; set; } = null; // AI 所有者

        public bool Enabled { get; set; } = false; // 是否已启用

        public AI()
        {
            Owner = null;
        }

        public AI(Actor o)
        {
            Owner = o;
        }

        // 处理时间流逝
        public virtual void OnTimeElapsed(int te) { }
    }
}
