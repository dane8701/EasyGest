using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EasyGest.BLL
{
    [Serializable]
    public class TypingException : Exception
    {
        public List<KeyValuePair<string, string>> Erros { get; private set; }
        public TypingException()
        {

        }

        public TypingException(List<KeyValuePair<string, string>> messages) : base("")
        {
            Erros = messages;
        }

        public TypingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TypingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
