using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Git
{
    public class BrokenCarException : Exception
    {
        public BrokenCarException()
        {
        }

        public BrokenCarException(string message) : base(message)
        {
        }

        public BrokenCarException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BrokenCarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
