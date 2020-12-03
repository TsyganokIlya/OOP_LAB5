using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LAB5.Exceptions
{
    public class CastException : InvalidCastException
    {
        public int n { get; set; }
        public CastException(string message, int value) : base(message) { n = value;  }
        public override string ToString()
        {
            return $"{Message} {n} |{GetType().Name}|";
        }

    }
}
