using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LAB5.Exceptions
{
    public class NotCreate : NullReferenceException
    {
        public NotCreate(string str) : base(str) { }
    }
}
