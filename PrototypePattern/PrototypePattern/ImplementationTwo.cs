﻿using System;

namespace PrototypePattern
{
    internal class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id)
        {
            
        }

        public override BaseClass Clone()
        {
            return new ImplementationTwo(Id);
        }

    }
}