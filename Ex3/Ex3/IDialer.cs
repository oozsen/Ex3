using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public interface IDialer
    {
        Task<bool> DialAsync(string number);
    }
}
