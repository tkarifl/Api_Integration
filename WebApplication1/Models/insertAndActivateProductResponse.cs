using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebApplication1.Models
{
    [XmlRoot(ElementName = "return")]
    public class Insert_Return
    {

        [XmlElement(ElementName = "error")]
        public Error error { get; set; }

        [XmlElement(ElementName = "ackCode")]
        public string AckCode { get; set; }

        [XmlElement(ElementName = "responseTime")]
        public string ResponseTime { get; set; }

        [XmlElement(ElementName = "timeElapsed")]
        public string TimeElapsed { get; set; }

        [XmlElement(ElementName = "productId")]
        public int ProductId { get; set; }

        [XmlElement(ElementName = "result")]
        public string Result { get; set; }
    }

    [XmlRoot(ElementName = "insertAndActivateProductResponse")]
    public class InsertAndActivateProductResponse
    {

        [XmlElement(ElementName = "return")]
        public Insert_Return Insert_Return { get; set; }

        [XmlAttribute(AttributeName = "prod")]
        public string Prod { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "error")]
    public class Error
    {

        [XmlElement(ElementName = "errorId")]
        public string errorId { get; set; }

        [XmlElement(ElementName = "errorCode")]
        public string errorCode { get; set; }

        [XmlElement(ElementName = "message")]
        public string message { get; set; }

        [XmlElement(ElementName = "viewMessage")]
        public string viewMessage { get; set; }
    }
}
