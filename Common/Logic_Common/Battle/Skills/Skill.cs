using System.Collections.Generic;

namespace Nova
{
    /// <summary>
    /// 角色技能
    /// </summary>
    public abstract class Skill
    {
        // 配置表 id
        public int Tid { get; set; }

        // 对给定目标是否可用
        public abstract bool Available(Actor a);

        // 筛选可施放的目标
        public virtual Actor[] AvailableActors(IEnumerable<Actor> candidates)
        {
            var actors = new List<Actor>();
            foreach (var a in candidates)
            {
                if (Available(a))
                    actors.Add(a);
            }

            return actors.ToArray();
        }
    }
}
