using System.Globalization;
using System.Threading;
using Xamarin.Forms;

[assembly: Dependency(typeof(UsingResxLocalization.WinPhone.Localize))]

namespace UsingResxLocalization.WinPhone
{
    public class Localize : ILocalize
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }
    }
}
