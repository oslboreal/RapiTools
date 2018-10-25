using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RapiTools.Clases.QueueProcessing
{
    internal class Server
    {
        private ConcurrentBag<Task> Processes { get; set; }
        IStrategy ProcessorInstance;
        private bool readyToStart = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Server()
        {
            
        }

        public bool SetPrcessorInstance(IStrategy instance)
        {
            if (instance != null)
            {
                ProcessorInstance = instance;
                readyToStart = true;
            }
            return readyToStart;
        }

        /// <summary>
        /// Start working.
        /// </summary>
        public void Start()
        {
            // Start a new subprocess that keep the queue clear.
        }

        /// <summary>
        /// Periodically queue checking.
        /// </summary>
        /// <param name="state"></param>
        public void CheckIncomingQueue(object state)
        {
            try
            {
                // Stop timer.

                // If the collection have content the Server starts a new Processing task calling the Processor instance and waiting for a new return to response to the client.
            }
            catch (Exception)
            {
                // log
                throw;
            }
            finally
            {
                // Restart clock (1000 Miliseconds).
            }
        }

        /// <summary>
        /// Process a message and take action.
        /// </summary>
        /// <param name="recvMessage"></param>
        public void Process(Message recvMessage)
        {
            // StateMachine. 
        }

        private bool Send()
        {
            throw new NotImplementedException();
        }
    }
}
