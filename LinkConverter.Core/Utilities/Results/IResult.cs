﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkConverter.Core.Utilities.Results
{
    public interface IResult 
    {
        bool Success { get; }
        string Message { get; }
    }
}
