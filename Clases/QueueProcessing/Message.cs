using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapiTools.Clases.QueueProcessing
{
    internal class Message
    {
        private Guid id { get; set; }
        private string body { get; set; } 
        public DateTime SendTime { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="body"></param>
        public Message(Guid uid, string body)
        {
            this.id = uid;
            this.body = body;
        }

    }
}