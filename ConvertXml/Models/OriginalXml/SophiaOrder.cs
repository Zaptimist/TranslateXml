using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConvertXml.Models.OriginalXml
{
    [XmlRoot(ElementName="OrderLine")]
    public class OrderLine {
        [XmlElement(ElementName="Reference")]
        public string Reference { get; set; }
        [XmlElement(ElementName="Description")]
        public string Description { get; set; }
        [XmlElement(ElementName="Quantity")]
        public string Quantity { get; set; }
        [XmlElement(ElementName="UnitPrice")]
        public string UnitPrice { get; set; }
        [XmlElement(ElementName="Price")]
        public string Price { get; set; }
    }

    [XmlRoot(ElementName="SophiaOrder")]
    public class SophiaOrder {
        [XmlElement(ElementName="Id")]
        public string Id { get; set; }
        [XmlElement(ElementName="Reference")]
        public string Reference { get; set; }
        [XmlElement(ElementName="Description")]
        public string Description { get; set; }
        [XmlElement(ElementName="OrderDate")]
        public string OrderDate { get; set; }
        [XmlElement(ElementName="DeliveryDate")]
        public string DeliveryDate { get; set; }
        [XmlElement(ElementName="OrderLine")]
        public List<OrderLine> OrderLine { get; set; }
        [XmlElement(ElementName="CertificatePrice")]
        public string CertificatePrice { get; set; }
        [XmlElement(ElementName="PackagingPrice")]
        public string PackagingPrice { get; set; }
        [XmlElement(ElementName="TransportPrice")]
        public string TransportPrice { get; set; }
        [XmlElement(ElementName="TotalPrice")]
        public string TotalPrice { get; set; }
    }
}