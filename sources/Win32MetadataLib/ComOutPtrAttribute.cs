﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Windows.Sdk
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    public sealed class ComOutPtrAttribute : Attribute
    {
    }
}
