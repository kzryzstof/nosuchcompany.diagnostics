﻿// ==========================================================================
// Copyright (C) 2018 by NoSuch Company.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// 
// Last change: 13/08/2018 @ 5:19 PM
// Last author: Christophe Commeyne
// ==========================================================================

using System;
using Xunit;

namespace NoSuchCompany.Diagnostics.Tests
{
    #region Class

    public class FluentRefTypeTests
    {
        #region Public Methods

        [Fact]
        public void ThrowIfIsNull_InstIsNull_ArgumentNullExceptionThrown()
        {
            Exception exception = null;

            Assert.Throws<ArgumentNullException>(() => exception.ThrowIfIsNull("instName"));
        }

        #endregion
    }

    #endregion
}