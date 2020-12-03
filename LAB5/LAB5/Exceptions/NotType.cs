using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LAB5.Exceptions
{
    public class NotType : Exception
    {
        public int Type { get; set; }
        public NotType(string message, int value) : base(message) { Type = value; }

        public override string ToString()
        {
            return $"{Message} {Type} |{GetType().Name}|";
        }

    }
}
