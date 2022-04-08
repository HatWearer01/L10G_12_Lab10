using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10G_12_Lab10
{
    public class LoginEventArgs : EventArgs
    {
        public string PersonName { get; }
        public bool Success { get; }
        public LoginEventArgs(string personName, bool success)
            : base()
        {
            PersonName = personName;
            Success = success;
        }
    }
}
