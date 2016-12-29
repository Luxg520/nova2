using System;
using System.Diagnostics;
using System.Collections.Generic;
using Swift;

namespace Nova
{
    public class Utils : Utils2
    {
        public static Action<bool, string> BattleAssert = null;
        static Utils()
        {
            // BattleAssert = (bool exp, string msg) => Debug.Assert(exp, msg);
            BattleAssert = ((bool exp, string msg) =>
            {
                if (!exp)
                    throw new Exception(msg);
            });
        }
    }
}
