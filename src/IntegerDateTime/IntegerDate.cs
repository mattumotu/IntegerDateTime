namespace IntegerDateTime
{
    using System;

    /// <summary>
    /// Gets the Year, Month and Day components, and DateTime,
    /// of a date string (YYYYMMDD)
    /// </summary>
    public sealed class IntegerDate
    {
        /// <summary>
        /// Holds the date string
        /// </summary>
        private readonly string origin;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IntegerDate" /> class.
        /// </summary>
        /// <param name="origin">The date string</param>
        public IntegerDate(string origin)
        {
            int.Parse(origin);

            if (origin.Length != 8)
            {
                throw new FormatException("Input string must have a length of 8");
            }

            this.origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IntegerDate" /> class.
        /// </summary>
        /// <param name="origin">The DateTime origin</param>
        public IntegerDate(DateTime origin)
            : this(origin.ToString("yyyyMMdd"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IntegerDate" /> class.
        /// </summary>
        /// <param name="origin">The integer origin</param>
        public IntegerDate(int origin)
            : this(origin.ToString())
        {
        }

        /// <summary>
        /// Gets the year component of this date
        /// </summary>
        public int Year
        {
            get
            {
                return int.Parse(this.origin.Substring(0, 4));
            }
        }

        /// <summary>
        /// Gets the month component of this date
        /// </summary>
        public int Month
        {
            get
            {
                return int.Parse(this.origin.Substring(4, 2));
            }
        }

        /// <summary>
        /// Gets the day component of this date
        /// </summary>
        public int Day
        {
            get
            {
                return int.Parse(this.origin.Substring(6, 2));
            }
        }

        /// <summary>
        /// Gets a DateTime representing this date
        /// </summary>
        public DateTime ToDateTime
        {
            get
            {
                return new DateTime(this.Year, this.Month, this.Day);
            }
        }

        /// <summary>
        /// Gets an integer representing this date
        /// </summary>
        public int ToInt32
        {
            get
            {
                return int.Parse(this.origin);
            }
        }

        /// <summary>
        /// Gets a string representing this date
        /// </summary>
        /// <returns>origin as string</returns>
        public override string ToString()
        {
            return this.origin;
        }
    }
}
