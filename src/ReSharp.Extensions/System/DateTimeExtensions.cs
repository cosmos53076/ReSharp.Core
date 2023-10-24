﻿// Copyright (c) Jerry Lee. All rights reserved. Licensed under the MIT License.
// See LICENSE in the project root for license information.

using System;

namespace ReSharp.Extensions
{
    /// <summary>
    /// Extension methods collection of <see cref="System.DateTime"/>.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// The start <see cref="System.DateTime"/> of UTC timestamp.
        /// </summary>
        public static readonly DateTime UtcTimestampStartTime = new DateTime(1970, 1, 1);

        /// <summary>
        /// Converts the value of the current <see cref="System.DateTime"/> object to a local timestamp.
        /// </summary>
        /// <param name="dateTime">The current <see cref="System.DateTime"/> object.</param>
        /// <returns>
        /// The value of the current <see cref="System.DateTime"/> object expressed as a local timestamp.
        /// </returns>
        public static long ToTimestamp(this DateTime dateTime)
        {
            var timeSpan = dateTime.ToLocalTime() - UtcTimestampStartTime.ToLocalTime();
            return Convert.ToInt64(timeSpan.TotalSeconds);
        }

        /// <summary>
        /// Converts the value of the current <see cref="System.DateTime"/> object to a local timestamp in milliseconds.
        /// </summary>
        /// <param name="dateTime">The current <see cref="System.DateTime"/> object.</param>
        /// <returns>
        /// The value of the current <see cref="System.DateTime"/> object expressed as a local timestamp in milliseconds.
        /// </returns>
        public static long ToTimestampInMilliseconds(this DateTime dateTime)
        {
            var timeSpan = dateTime.ToLocalTime() - UtcTimestampStartTime.ToLocalTime();
            return Convert.ToInt64(timeSpan.TotalMilliseconds);
        }

        /// <summary>
        /// Converts the value of the current <see cref="System.DateTime"/> object to an UTC timestamp.
        /// </summary>
        /// <param name="dateTime">The current <see cref="System.DateTime"/> object.</param>
        /// <returns>
        /// The value of the current <see cref="System.DateTime"/> object expressed as an UTC timestamp.
        /// </returns>
        public static long ToUtcTimestamp(this DateTime dateTime)
        {
            var timeSpan = dateTime.ToUniversalTime() - UtcTimestampStartTime;
            return Convert.ToInt64(timeSpan.TotalSeconds);
        }

        /// <summary>
        /// Converts the value of the current <see cref="System.DateTime"/> object to an UTC timestamp in milliseconds.
        /// </summary>
        /// <param name="dateTime">The current <see cref="System.DateTime"/> object.</param>
        /// <returns>
        /// The value of the current <see cref="System.DateTime"/> object expressed as an UTC timestamp in milliseconds.
        /// </returns>
        public static long ToUtcTimestampInMilliseconds(this DateTime dateTime)
        {
            var timeSpan = dateTime.ToUniversalTime() - UtcTimestampStartTime;
            return Convert.ToInt64(timeSpan.TotalMilliseconds);
        }
    }
}