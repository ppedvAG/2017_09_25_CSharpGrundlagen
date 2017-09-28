using System;

namespace Exceptions
{
    internal class MustNotBeTodayException : Exception
    {
        public MustNotBeTodayException(int forbiddenNumber, string message) : base(message)
        {
            ForbiddenNumber = forbiddenNumber;
        }

        public int ForbiddenNumber { get; }

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
    }
}
