using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class CustomeException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION, INVALID_ENTRY_EXCEPTION, NULL_FIELD_EXCEPTION
        }
        public CustomeException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
