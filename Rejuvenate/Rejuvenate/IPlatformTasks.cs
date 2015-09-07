using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejuvenate
{
    public interface IPlatformTasks
    {
        string DownloadFile(string uri);
        void SendPsmPlus(string drmboot, string kconsole);
        void EmailLog(string log);
        List<string> ListFiles(string dir);
        void ReadFile(string path, out byte[] data);
        void WriteFile(string path, byte[] data);
        void DeleteFile(string path);
        string ShowEntryPopup(string msg);
        string BrowseDirectory();
    }
}
