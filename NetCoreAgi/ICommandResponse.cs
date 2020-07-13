using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAgi
{
    public interface ICommandResponse
    {
        int code { get; set; }
        string result { get; set; }
        string data { get; set; }
    }
}
