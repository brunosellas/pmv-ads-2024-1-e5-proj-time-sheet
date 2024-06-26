﻿namespace TimeSheet.Common.CQRS {
    public class InvalidCommandException : Exception {
        public InvalidCommandException() : base() { }
        public InvalidCommandException(string message) : base(message) { }
        public InvalidCommandException(string message, Exception innerException) : base(message, innerException) { }
    }
}
