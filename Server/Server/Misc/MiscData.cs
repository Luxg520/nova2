using System;
using System.Collections.Generic;
using Nova;
using Swift;

namespace Server
{
    public class MiscData : DataItem<int>//, ISerializable
    {
        public MiscData(MiscDataType id)
            : base((int)id)
        {
        }

        public byte[] Info
        {
            get;
            set;
        }

        public object GetObj()
        {
            RingBuffer data = new RingBuffer();
            data.Write(Info);
            MiscDataType miscType = (MiscDataType)ID;
            switch (miscType)
            {
                // 答题指挥官Tid
                case MiscDataType.QuestionCommanderTid:
                    {
                        int[] commanderTid = data.ReadIntArr();
                        return (object)commanderTid;
                    }
                // 答题上一次指挥官Tid                    
                case MiscDataType.QuestionLastCommanderTid:
                    {
                        int last = data.ReadInt();
                        return (object)last;
                    }
                // 开服时间
                case MiscDataType.OpenServerTime:
                    {
                        ulong time = data.ReadULong();
                        return time;
                    }
                // 成长计划购买人数
                case MiscDataType.DevelopBuyCount:
                    {
                        int count = data.ReadInt();
                        return count;
                    }
                // 上次军团战开始时间
                case MiscDataType.LastArmyGroupBattleTime:
                    {
                        ulong time = data.ReadULong();
                        return time;
                    }
            }
            return null;
        }

        public void SetObj(object obj)
        {
            WriteBuffer buff = new WriteBuffer();
            MiscDataType miscType = (MiscDataType)ID;
            switch (miscType)
            {
                // 答题指挥官Tid
                case MiscDataType.QuestionCommanderTid:
                    {
                        int[] commanderTid = (int[])obj;
                        buff.Write(commanderTid);
                    } break;
                // 答题上一次指挥官Tid                    
                case MiscDataType.QuestionLastCommanderTid:
                    {
                        buff.Write((int)obj);
                    }break;
                // 开服时间
                case MiscDataType.OpenServerTime:
                    {
                        buff.Write((ulong)obj);
                    }break;
                // 成长计划购买人数
                case MiscDataType.DevelopBuyCount:
                    {
                        buff.Write((int)obj);
                    }break;
                case MiscDataType.LastArmyGroupBattleTime:
                    {
                        buff.Write((ulong)obj);
                    }break;
            }
            byte[] info = new byte[buff.Available];
            Array.Copy(buff.Data, 0, info, 0, buff.Available);
            Info = info;
        }

        public void Serialize(IWriteableBuffer w)
        {
            if (Info != null)
            {
                w.Write(Info.Length);
                w.Write(Info);
            }
            else
                w.Write(0);
        }

        public void Deserialize(IReadableBuffer r)
        {
            int len = r.ReadInt();
            if (len == 0)
                Info = null;
            else
                Info = r.ReadBytes(len);
        }
    }

    public enum MiscDataType
    {
        QuestionCommanderTid,       // 答题指挥官Tid                
        QuestionLastCommanderTid,   // 答题上一次指挥官Tid
        OpenServerTime,             // 首次开服时间
        DevelopBuyCount,            // 成长计划购买人数
        LastArmyGroupBattleTime,    // 上次开军团战的时间

        Count,
    }

    public static class MiscDataUtils
    {
        // 获取答题全服统一指挥官
        public static int[] GetQuestionCommanderTid(this MiscData data)
        {
            if ((MiscDataType)data.ID != MiscDataType.QuestionCommanderTid)
                return null;
            return (int[])data.GetObj();
        }
    }
}
