using ExceptionProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CustomExceptionproblem
{
    [Serializable]
    public class CustomException : Exception

    {
        private readonly ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELD, NO_SUCH_CLASS, NO_SUCH_METHOD,
            NO_SUCH_PARAMETER, OBJECT_CREATION_ISSUE

        }
        public CustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
        

        }
    }

 
