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

        public static string ErrorFile { get; set; } = "error.log";
        public static string InfoFile { get; set; } = "info.log";
        public static string FatalFile { get; set; } = "fatal.log";
        public static string DefaultFile { get; set; } = "default.log";
        public static string WarningFile { get; set; } = "warning.log";

        #endregion

        static Logger()
        { }

        /// <summary>
        /// This method can be used to log an Error event.
        /// </summary>
        public static void Error(string message)
        {
            if (!File.Exists(ErrorFile))
                File.Create(ErrorFile);

            if(!string.IsNullOrEmpty(message) && !string.IsNullOrWhiteSpace(message))
            {
                using (StreamWriter writer = new StreamWriter(ErrorFile))
                {
                    writer.WriteLine($"[{DateTime.Now} | Error] - {message}");
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// This method can be used to log an Info event.
        /// </summary>
        public static void Info(string message)
        {
            if (!File.Exists(InfoFile))
                File.Create(InfoFile);

            if (!string.IsNullOrEmpty(message) && !string.IsNullOrWhiteSpace(message))
            {
                using (StreamWriter writer = new StreamWriter(InfoFile))
                {
                    writer.WriteLine($"[{DateTime.Now} | Info] - {message}");
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// This method can be used to log a Fatal event.
        /// </summary>
        public static void Fatal(string message)
        {
            if (!File.Exists(FatalFile))
                File.Create(FatalFile);

            if (!string.IsNullOrEmpty(message) && !string.IsNullOrWhiteSpace(message))
            {
                using (StreamWriter writer = new StreamWriter(FatalFile))
                {
                    writer.WriteLine($"[{DateTime.Now} | Fatal] - {message}");
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// This method can be used to log a Default event.
        /// </summary>
        public static void Default(string message)
        {
            if (!File.Exists(DefaultFile))
                File.Create(DefaultFile);

            if (!string.IsNullOrEmpty(message) && !string.IsNullOrWhiteSpace(message))
            {
                using (StreamWriter writer = new StreamWriter(DefaultFile))
                {
                    writer.WriteLine($"[{DateTime.Now} | Default] - {message}");
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// This method can be used to log a Warning event.
        /// </summary>
        public static void Warning(string message)
        {
            if (!File.Exists(WarningFile))
                File.Create(WarningFile);

            if (!string.IsNullOrEmpty(message) && !string.IsNullOrWhiteSpace(message))
            {
                using (StreamWriter writer = new StreamWriter(WarningFile))
                {
                    writer.WriteLine($"[{DateTime.Now} | Warning] - {message}");
                    writer.Close();
                }
            }
        }
    }
}
