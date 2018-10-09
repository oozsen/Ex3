using Ex3.UWP;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]

namespace Ex3.UWP
{
    public class PhoneDialer : IDialer
    {
        public Task<bool> DialAsync(string number)
        {
            //throw new NotImplementedException();
            if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.Calls.CallsPhoneContract",1,0))
            {
                Windows.ApplicationModel.Calls.PhoneCallManager.ShowPhoneCallUI(number, "Phoneword");
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
