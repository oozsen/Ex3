using Ex3.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]

namespace Ex3.UWP
{
    public class PhoneDialer : IDialer
    {
        public Task<bool> DialAsync(string number)
        {
            throw new NotImplementedException();
        }
    }
}
