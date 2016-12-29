using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swift;
using Nova;

namespace Server
{
    public class DebugObjContainer : Component
    {
        public static ConcurrentDictionary<string, object> c = new ConcurrentDictionary<string, object>();
    }
}
