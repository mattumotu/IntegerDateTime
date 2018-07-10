namespace IntegerDateTime
{
    using System;

    /// <summary>
    /// Gets the Hour, Minute and Second components, and TimeSpan,
    /// of a time string (HHMMSS or HMMSS)
    /// </summary>
    public sealed class IntegerTime
    {
        /// <summary>
        /// Holds the origin time string
        /// </summary>
        private readonly string origin;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IntegerTime" /> class.
        /// </summary>
        /// <param name="origin">The time string, HHMMSS or HMMSS</param>
        public IntegerTime(string origin)
        {
            int.Parse(origin);

            this.origin = origin.PadLeft(6, '0');
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IntegerTime" /> class.
        /// </summary>
        /// <param name="origin">The DateTime origin</param>
        public IntegerTime(DateTime origin)
            : this(origin.ToString("HHmmss"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IntegerTime" /> class.
        /// </summary>
        /// <param name="origin">The integer origin</param>
        public IntegerTime(int origin)
            : this(origin.ToString())
        {
        }

        /// <summary>
        /// Gets the hour component of this time
        /// </summary>
        public int Hour
        {
            get
            {
                return int.Parse(this.origin.Substring(0, 2));
            }
        }

        /// <summary>
        /// Gets the minute component of this time
        /// </summary>
        public int Minute
        {
            get
            {
                return int.Parse(this.origin.Substring(2, 2));
            }
        }

        /// <summary>
        /// Gets the second component of this time
        /// </summary>
        public int Second
        {
            get
            {
                return int.Parse(this.origin.Substring(4, 2));
            }
        }

        /// <summary>
        /// Gets a TimeSpan representing this time
        /// </summary>
        public TimeSpan ToTimeSpan
        {
            get
            {
                return new TimeSpan(this.Hour, this.Minute, this.Second);
            }
        }

        /// <summary>
        /// Gets an integer representing this time
        /// </summary>
        public int ToInt
        {
            get
            {
                return int.Parse(this.origin);
            }
        }

        /// <summary>
        /// Gets a string representing this time
        /// </summary>
        /// <returns>origin as string</returns>
        public override string ToString()
        {
            return int.Parse(this.origin).ToString();
        }
    }
}
