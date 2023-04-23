using System;

namespace Studying
{
    internal class MyStackOverflowException : SystemException
    {
        public MyStackOverflowException() { }

        public MyStackOverflowException(string message) : base(message) { }

        public MyStackOverflowException(string message, Exception inner) : base(message, inner) { }
    }
}
