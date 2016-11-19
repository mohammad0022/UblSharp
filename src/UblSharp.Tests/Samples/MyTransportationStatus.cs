// Generated by UblSharp.Tests.Generator
using System;
using System.Collections.Generic;
using System.Xml;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using UblSharp.XmlDigitalSignature;

namespace UblSharp.Tests.Samples
{
    internal class MyTransportationStatus
    {
        public static TransportationStatusType Create()
        {
            var doc = new TransportationStatusType
            {
                UBLExtensions = new List<UBLExtensionType>()
                {
                    new UBLExtensionType
                    {
                    }
                },
                UBLVersionID = "2.1",
                CustomizationID = "urn:X-demo:TransportShipments",
                ProfileID = "urn:X-demo:CoreElement",
                ID = "1234",
                IssueDate = "2010-08-13",
                IssueTime = "15:30:00.0Z",
                Description = new List<TextType>()
                {
                    new TextType
                    {
                        Value = "En route"
                    }
                },
                Consignment = new List<ConsignmentType>()
                {
                    new ConsignmentType
                    {
                        ID = "XYZ987",
                        SummaryDescription = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Electronic components"
                            }
                        },
                    }
                },
                TransportEvent = new List<TransportEventType>()
                {
                    new TransportEventType
                    {
                        CurrentStatus = new List<StatusType>()
                        {
                            new StatusType
                            {
                                ConditionCode = "31",
                                Description = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "En route"
                                    }
                                },
                            }
                        },
                        Contact = new List<ContactType>()
                        {
                            new ContactType
                            {
                                Name = "John Smith",
                                ElectronicMail = "jsmith@example.com"
                            }
                        },
                    }
                },
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                new XmlQualifiedName("ext","urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"),
            });
            return doc;
        }
    }
}
