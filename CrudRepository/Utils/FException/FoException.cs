using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace CrudRepository.Utils.FException
{
    /// <summary>
    /// Classe permet de gérer les exceptions du module .MP
    /// </summary>
    [Serializable()]
    public class FoException : Exception
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public FoException()
        {
        }
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="message">Message</param>
        public FoException(string message) : base(message)
        {
            Msg.TraceError(message);
        }
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="exception">Exeption</param>
        public FoException(string message, Exception exception) : base(message)
        {
            Msg.TraceError(message, exception);
        }
        /// <summary>
        /// Constructeur sérialisable
        /// </summary>
        /// <param name="info">info</param>
        /// <param name="context">context</param>
        protected FoException(SerializationInfo info, StreamingContext context) :
       base(info, context)
        {
        }

    }
}
