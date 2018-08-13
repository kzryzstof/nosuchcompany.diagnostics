﻿// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:15 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;

namespace NoSuchCompany.Diagnostics
{
    #region Class

    /// <summary>
    /// Provides checks for the <see cref="DateTime" /> type.
    /// </summary>
    public static partial class Fluent
    {
        #region Public Methods

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified in a local time zone.
        /// </exception>
        public static DateTime ThrowIfIsNotLocal(this DateTime inst, string instName)
        {
            Argument.ThrowIfIsNotLocal(inst, instName);

            return inst;
        }

        /// <param name="inst">Inst.</param>
        /// <param name="instName">Inst name.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if :
        /// <paramref name="inst" /> is not specified in the UTC time zone.
        /// </exception>
        public static DateTime ThrowIfIsNotUtc(this DateTime inst, string instName)
        {
            Argument.ThrowIfIsNotUtc(inst, instName);

            return inst;
        }

        #endregion
    }

    #endregion
}