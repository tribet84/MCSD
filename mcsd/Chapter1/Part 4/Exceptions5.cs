using System;
using System.Runtime.Serialization;

namespace Chapter1
{
    [Serializable]
    class InvoiceProcessingException : Exception, ISerializable
    {
        public InvoiceProcessingException(int invoiceId)
        {
            InvoiceId = invoiceId;
            this.HelpLink = "http://www.mycompany.com/InvoiceExceptionInformation";
        }

        public InvoiceProcessingException(int invoiceId, string message)
            : base(message)
        {
            InvoiceId = invoiceId;
            this.HelpLink = "http://www.mycompany.com/InvoiceExceptionInformation";
        }

        public InvoiceProcessingException(int invoiceId, string message, Exception innerException)
            : base(message, innerException)
        {
            InvoiceId = invoiceId;
            this.HelpLink = "http://www.mycompany.com/InvoiceExceptionInformation";
        }

        protected InvoiceProcessingException(SerializationInfo info, StreamingContext context)
        {
            InvoiceId = (int)info.GetValue("InvoiceId", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("InvoiceId", InvoiceId, typeof(int));
        }

        public int InvoiceId { get; set; }
    }
}