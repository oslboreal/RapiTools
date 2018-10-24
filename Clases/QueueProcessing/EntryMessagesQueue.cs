using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapiTools.Clases.QueueProcessing
{
    internal class EntryMessagesQueue
    {
        // TCP Data.
        private string ip;
        private string port;

        // Messaging.
        private ConcurrentDictionary<int, string> receivedMessages;

        // Processing.
        private Task subProceso;

        /// <summary>
        /// Método encargado de escuchar en un puerto determinado aguardando que ingrese un mensaje para encolarlo.
        /// </summary>
        public void Listen()
        {
            // New sub process listening everytime.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método 
        /// </summary>
        /// <returns></returns>
        private bool Store()
        {
            throw new NotImplementedException();
        }
    }
}
