﻿using Optivem.Kata.Banking.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Kata.Banking.Core.Domain.Common.Guards
{
    public static class StringGuardExtensions
    {
        public static string GuardAgainstNullOrWhiteSpace(this string? value, string message)
        {
            Guard.Against(() => string.IsNullOrWhiteSpace(value), message);
            return value;
        }
    }
}
