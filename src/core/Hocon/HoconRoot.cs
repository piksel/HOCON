﻿//-----------------------------------------------------------------------
// <copyright file="HoconRoot.cs" company="Hocon Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/hocon>
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace Hocon
{
    /// <summary>
    /// This class represents the root element in a HOCON (Human-Optimized Config Object Notation)
    /// configuration string.
    /// </summary>
    public class HoconRoot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoconRoot"/> class.
        /// </summary>
        protected HoconRoot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HoconRoot"/> class.
        /// </summary>
        /// <param name="value">The value to associate with this element.</param>
        /// <param name="substitutions">An enumeration of substitutions to associate with this element.</param>
        public HoconRoot(HoconValue value, IEnumerable<HoconSubstitution> substitutions)
        {
            Value = value;
            Substitutions = substitutions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HoconRoot"/> class.
        /// </summary>
        /// <param name="value">The value to associate with this element.</param>
        public HoconRoot(HoconValue value)
        {
            Value = value;
            Substitutions = Enumerable.Empty<HoconSubstitution>();
        }

        /// <summary>
        /// Retrieves the value associated with this element.
        /// </summary>
        public HoconValue Value { get; private set; }
        /// <summary>
        /// Retrieves an enumeration of substitutions associated with this element.
        /// </summary>
        public IEnumerable<HoconSubstitution> Substitutions { get; private set; }
    }
}

