using UnityEngine;
using System.Collections;

namespace Swift
{
    public class Agent_Logic : Component_Logic
    {
        public PortAgent A { get { return agent; } }
        PortAgent agent = new PortAgent();
    }
}
