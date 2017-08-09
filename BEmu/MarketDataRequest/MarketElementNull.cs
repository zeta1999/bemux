﻿//------------------------------------------------------------------------------
// <copyright project="BEmu_csh" file="MarketDataRequest/MarketElementNull.cs" company="Jordan Robinson">
//     Copyright (c) 2013 Jordan Robinson. All rights reserved.
//
//     The use of this software is governed by the Microsoft Public License
//     which is included with this distribution.
// </copyright>
//------------------------------------------------------------------------------

namespace Bloomberglp.Blpapi.MarketDataRequest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class MarketElementNull : Element
    {
        private readonly string _name;

        internal MarketElementNull(string name)
        {
            this._name = name;
        }

        public override Name Name { get { return new Name(this._name); } }
        public override int NumElements { get { return 0; } }
        public override int NumValues { get { return 0; } }
        public override bool IsArray { get { return true; } }
        public override bool IsComplexType { get { return false; } }
        public override bool IsNull { get { return true; } }

        internal override StringBuilder PrettyPrint(int tabIndent, bool surroundValueWithQuotes = false)
        {
            return new StringBuilder();
        }

    }
}
