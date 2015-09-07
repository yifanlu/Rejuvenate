using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Rejuvenate
{
    public delegate void LogLineHandler(object sender, EventArgs e);

    class LogWriter : TextWriter
    {
        public event LogLineHandler OnLogLine;
        private StringBuilder _str;

        class StringArgs : EventArgs
        {
            public string Line;

            public StringArgs(string line)
            {
                Line = line;
            }
        }

        public override Encoding Encoding
        {
            get
            {
                return Encoding.UTF8;
            }
        }

        public LogWriter(LogLineHandler handler)
        {
            OnLogLine += handler;
            _str = new StringBuilder();
        }

        public override void Write(char value)
        {
            if (value == '\r' || value == '\n')
            {
                StringArgs line;
                lock (_str)
                {
                    line = new StringArgs(_str.ToString());
                    _str.Clear();
                }
                if (OnLogLine != null)
                {
                    OnLogLine(this, line);
                }
            }
            else
            {
                lock (_str)
                {
                    _str.Append(value);
                }
            }
        }
    }

    class Rejuvenate
    {
        private LogWriter _msgwriter;
        private LogWriter _verbosewriter;
        private LogWriter _errwriter;

        public async Task StartVitaDefilerAsync()
        {

        }

        public async Task DisconnectVitaAsync()
        {

        }

        public async Task LaunchHomebrewAsync(string file)
        {

        }

        public async Task PushFile(string src, string dst)
        {

        }

        public async Task PullFile(string src, string dst)
        {

        }
    }
}
