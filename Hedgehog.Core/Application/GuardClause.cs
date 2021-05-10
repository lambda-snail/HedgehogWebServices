using System;

namespace Hedgehog.Core.Application
{
    /// <summary>
    /// Provides a fluent API for checking certain conditions on objects, such as if the reference is null.
    /// 
    /// Usage:
    ///   GuardClause.Check.EnsureNotNull(myObject, "ErrorMsg")
    ///   GuardClause.Check.EnsureNotNull(myObject, "ErrorMsg").EnsureNotZero(myObject.IntProperty);
    /// 
    /// </summary>
    public class GuardClause
    {
        private static GuardClause _check = null;
        public static GuardClause Ensure
        {
            get => _check is null ? new GuardClause() : _check;
        }

        /// <summary>
        /// Ensures that the specified object is not null. If the object is null an ArgumentNullException
        /// will be thrown with the specified message.
        /// </summary>
        public GuardClause NotNull(object o, string errorMessage = "")
        {
            if (o is null)
            {
                throw new ArgumentNullException(errorMessage);
            }

            return this;
        }

        /// <summary>
        /// Ensures that the specified object is not 0. If the object is null an ArgumentNullException
        /// will be thrown with the specified message.
        /// </summary>
        public GuardClause NotZero(int i, string errorMessage = "")
        {
            if (i == 0)
            {
                throw new ArgumentNullException(errorMessage);
            }

            return this;
        }
    }
}
