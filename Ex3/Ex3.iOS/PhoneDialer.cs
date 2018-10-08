using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]

namespace Ex3.iOS
{
    public class PhoneDialer : IDialer
    {
        public Task<bool> DialAsync(string number)
        {
            return Task.FromResult(UIApplication.SharedApplication.OpenUrl(new NSUrl("tel:" + number)));
        }
    }
}