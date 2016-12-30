namespace Nova
{
    /// <summary>
    /// 普通攻击
    /// </summary>
    public class NormalAttack : Skill
    {
        // 对给定目标是否可用
        public override bool Available(Actor a)
        {
            return !a.CheckState(ActorState.Dead) 
                && !a.CheckState(ActorState.Faint)
                && !a.CheckState(ActorState.CanNotBeNormalAttacked);
        }
    }
}
