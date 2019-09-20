using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable
    {
        /// <summary>
        /// Blends the fruit
        /// </summary>
        /// <returns>A string describing the blended fruit</returns>
        public abstract string Blend();
    }
}
