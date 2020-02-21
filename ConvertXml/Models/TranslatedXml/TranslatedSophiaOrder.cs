using System.Collections.Generic;
using System.Xml.Serialization;
using ConvertXml.Models.OriginalXml;

namespace ConvertXml.Models.TranslatedXml
{
    [XmlRoot(ElementName="SophiaOrder")]
    public class TranslatedSophiaOrder {
        [XmlElement(ElementName="Id")]
        public string Id { get; set; }
        [XmlElement(ElementName="Referentienummer")]
        public string Reference { get; set; }
        [XmlElement(ElementName="Beschrijving")]
        public string Description { get; set; }
        [XmlElement(ElementName="Besteldatum")]
        public string OrderDate { get; set; }
        [XmlElement(ElementName="Leverdatum")]
        public string DeliveryDate { get; set; }
        [XmlElement(ElementName="CertificatePrice")]
        public string CertificatePrice { get; set; }
        [XmlElement(ElementName="PackagingPrice")]
        public string PackagingPrice { get; set; }
        [XmlElement(ElementName="TransportPrice")]
        public string TransportPrice { get; set; }
        [XmlElement(ElementName="Totaleprijs")]
        public string TotalPrice { get; set; }
        [XmlElement(ElementName="Bestellingen")]
        public List<TranslatedOrderLine> OrderLines { get; set; }

        public TranslatedSophiaOrder(string id, string reference, string description, string orderDate, string deliveryDate, string certificatePrice, string packagingPrice, string transportPrice, string totalPrice, List<TranslatedOrderLine> orderLines)
        {
            Id = id;
            Reference = reference;
            Description = description;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            CertificatePrice = certificatePrice;
            PackagingPrice = packagingPrice;
            TransportPrice = transportPrice;
            TotalPrice = totalPrice;
            OrderLines = orderLines;
        }

        public TranslatedSophiaOrder()
        {
        }
    }
    
    [XmlRoot(ElementName="OrderLine")]
    public class TranslatedOrderLine {
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

        public TranslatedOrderLine(string reference, string description, string quantity, string unitPrice, string price)
        {
            Reference = reference;
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Price = price;
        }

        public TranslatedOrderLine()
        {
        }
    }
}