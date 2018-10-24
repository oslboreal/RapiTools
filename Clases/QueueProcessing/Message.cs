using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapiTools.Clases.QueueProcessing
{
    internal class Message
    {
        private int uid { get; set; }
        private string body { get; set; } 

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="body"></param>
        public Message(int uid, string body)
        {
            this.uid = uid;
            this.body = body;
        }

    }
}
