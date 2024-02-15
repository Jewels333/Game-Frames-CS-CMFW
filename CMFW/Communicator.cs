using System.Collections.Generic;

namespace Framework
{
    internal class Communicator
    {
        private static List<Communicator> network = new();
        internal object Host;

        internal Communicator(object host)
        {
            network.Append(this);
            Host = host;
        }
    }
}