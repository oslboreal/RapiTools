using System;
using System.IO;

namespace Tools
{
    /// <summary>
    /// This class bring a group of Methods that can be used to log differents events.
    /// </summary>
    public static class Logger
    {
        #region Properties and Fields.
        public static string DefaultPath { get; set; } = System.Reflection.Assembly.GetEntryAssembly().Location;

        public static string ErrorFile { get; } = "error.log";
        public static string InfoFile { get; } = "info.log";
        public static string FatalFile { get; } = "fatal.log";
        public static string DefaultFile { get; } = "default.log";
        public static string WarningFile { get; } = "warning.log";
        
        #endregion

        static Logger()
        {
            //Create Folder.
            //Create Files.
        }

        /// <summary>
        /// This method can be used to log an Error event.
        /// </summary>
        public static void Error()
        {

        }

        /// <summary>
        /// This method can be used to log an Info event.
        /// </summary>
        public static void Info()
        {

        }

        /// <summary>
        /// This method can be used to log a Fatal event.
        /// </summary>
        public static void Fatal()
        {

        }

        /// <summary>
        /// This method can be used to log a Default event.
        /// </summary>
        public static void Default()
        {

        }

        /// <summary>
        /// This method can be used to log a Warning event.
        /// </summary>
        public static void Warning()
        {

        }
    }
}
