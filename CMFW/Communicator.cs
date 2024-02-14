namespace Framework
{
    internal class Communicator
    {
        private bool _isConnected = false;

        /// <summary>
        /// True if the communicator is connected to the network.
        /// </summary>
        internal bool IsConnected { get { return _isConnected} set { _isConnected = value; } }
        
        /// <summary>
        /// Next <see cref="Communicator"/> in the network.
        /// </summary>
        internal ref Communicator? Next;
        /// <summary>
        /// The <see cref="Communicator"/> behind this in the network.
        /// </summary>
        internal ref Communicator? Behind;
    
        internal void Connect(Communicator other, bool Next)
        {
            if (Next) { 
                Next = other; 
            }
            else { 
                Behind = other; 
            }
        }

        internal void Fire(object data)
    }
}