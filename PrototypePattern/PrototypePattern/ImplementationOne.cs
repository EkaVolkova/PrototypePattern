﻿using System;

namespace PrototypePattern
{
    internal class ImplementationOne : BaseClass
    {
        public ImplementationOne(int id) : base(id)
        {
        }

        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }

    }
}