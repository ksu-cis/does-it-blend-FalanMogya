﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A class representing a cell phone
    /// </summary>
    /// <summary>
    public class CellPhone : IBlendable
    {
        /// <summary>
        /// Blends the cell phone
        /// </summary>
        /// <returns>The result of blending the cell phone</returns>
        public string Blend()
        {
            return "Jagged chunks of plastic, glass, and electronics";
        }
    }
}
