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
        private EntryMessagesQueue Cola = new EntryMessagesQueue();
        private Timer Clock;
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
            // Instance a new EntryMessagesQueue (Communication module)
            Cola.Listen();
            // Start a new subprocess that keep the queue clear.
            Clock = new Timer(CheckQueue, null, 0, Timeout.Infinite);
        }

        /// <summary>
        /// Periodically queue checking.
        /// </summary>
        /// <param name="state"></param>
        public void CheckQueue(object state)
        {
            try
            {
                // Stop timer.
                Clock.Change(Timeout.Infinite, Timeout.Infinite);

                // If the collection have content the Server starts a new Processing task calling the Processor instance and waiting for a return to response to the client.
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                // Restart clock (1000 Miliseconds).
                Clock.Change(1000, Timeout.Infinite);
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
