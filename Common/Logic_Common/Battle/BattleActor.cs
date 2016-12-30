using System;
using System.Collections.Generic;
using System.Linq;

namespace Nova
{
    /// <summary>
    /// 角色状态，状态可以叠加
    /// </summary>
    public enum ActorState
    {
        Normal      = 0x0000, // 正常

        InCombat    = 0x0001, // 战斗中

        Dizz        = 0x0010, // 眩晕

        Dead        = 0x0100, // 死亡
        Faint       = 0x0200, // 昏迷倒地，但未死亡，相当于假死

        CanNotBeNormalAttacked = 0x1000, // 不可攻击
    }

    /// <summary>
    /// 角色性别
    /// </summary>
    public enum Gender
    {
        None, // 无性别(通常是非人物对象)
        Male, // 男
        Female, // 女
        FemaledMale, // 男变女
        MaledFemale, // 女变男
    }

    /// <summary>
    /// 游戏角色，包括玩家和 npc
    /// </summary>
    public class Actor
    {
        #region 属性

        // 角色状态
        ActorState state { get; set; }

        // 检查指定状态
        public bool CheckState(ActorState s)
        {
            if (s == ActorState.Normal)
                return state == ActorState.Normal;
            else
                return (state & s) > 0;
        }

        // 设置指定状态
        public void SetState(ActorState s)
        {
            if (s == ActorState.Normal)
                state = ActorState.Normal;
            else
                state |= s;
        }

        public int Hp { get; set; } // 红
        public int Mp { get; set; } // 蓝
        public Gender Gender { get; set; } // 性别

        long px = 0;
        public float Px // 坐标 x
        {
            get { return px / 100.0f; }
            set { px = (long)(value * 100); }
        }

        long py = 0;
        public float Py // 坐标 y
        {
            get { return py / 100.0f; }
            set { py = (long)(value * 100); }
        }

        long dx = 0;
        public float Dx // 方向 x
        {
            get { return dx / 100.0f; }
            set { dx = (long)(value * 100); }
        }

        long dy = 0;
        public float Dy // 方向 y
        {
            get { return dy / 100.0f; }
            set { dy = (long)(value * 100); }
        }

        long speed = 0;
        public float Speed // 移动速度，总是向当前方向移动
        {
            get { return speed / 100.0f; }
            set { speed = (long)(value * 100); }
        }

        #endregion

        #region 技能

        Dictionary<int, Skill> skills = new Dictionary<int, Skill>();

        // 获取第一个满足条件的技能
        public Skill GetSkill(Func<Skill, bool> filter)
        {
            var ss = GetSkills(filter);
            return ss.Length > 0 ? ss[0] : null;
        }

        // 获取满足条件的技能列表
        public Skill[] GetSkills(Func<Skill, bool> filter)
        {
            if (filter == null)
                return skills.Values.ToArray();
            else
            {
                var ss = new List<Skill>();
                foreach (var s in skills.Values)
                {
                    if (filter(s))
                        ss.Add(s);
                }

                return ss.ToArray();
            }
        }

        // 添加技能
        public void AddSkill(Skill s)
        {
            if (!skills.ContainsKey(s.Tid))
                skills[s.Tid] = s;
        }

        // 移除技能
        public Skill RemoveSkill(int tid)
        {
            Skill s = null;
            if (skills.ContainsKey(tid))
            {
                s = skills[tid];
                skills.Remove(tid);
            }

            return s;
        }

        #endregion

        #region AI

        List<AI> ais = new List<AI>();

        // 所有 AI 处理时间流逝
        public void OnTimeElapsed(int te)
        {
            foreach (var ai in ais)
                ai.OnTimeElapsed(te);
        }

        // 获取指定 AI
        public T GetAI<T>() where T : AI
        {
            foreach (var ai in ais)
            {
                if (ai is T)
                    return ai as T;
            }

            return null;
        }

        // 添加 AI
        public void AddAI<T>() where T : AI, new()
        {
            if (GetAI<T>() == null)
            {
                AI ai = new T();
                ai.Owner = this;
                ais.Add(ai);
            }
        }

        // 移除 AI
        public bool RemoveAI<T>() where T : AI
        {
            foreach (var ai in ais)
            {
                if (ai is T)
                {
                    ais.Remove(ai);
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
