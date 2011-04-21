﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace VBF.Compilers.Scanners
{
    [DebuggerDisplay("Token:{TokenIdentityIndex} {Value}")]
    public sealed class Lexeme
    {
        public int TokenIdentityIndex { get; private set; }
        public SourceSpan Span { get; private set; }
        public string Value { get; private set; }

        internal Lexeme(int tokenIdentityIndex, SourceSpan span, string value)
        {
            TokenIdentityIndex = tokenIdentityIndex;
            Span = span;
            Value = value;
        }
    }
}
