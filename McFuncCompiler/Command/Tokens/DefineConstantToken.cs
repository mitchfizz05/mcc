﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McFuncCompiler.Command.Tokens
{
    public class DefineConstantToken : IToken
    {
        public string Name { get; set; }
        public Argument Value { get; set; }

        public DefineConstantToken(string name, Argument value)
        {
            Name = name;
            Value = value;
        }

        public string Compile(BuildEnvironment env)
        {
            env.Constants[Name] = Value.Compile(env);
            return null;
        }
    }
}
