// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UnqualifiedDataTypes;
    using CommonAggregateComponents;
    using CommonExtensionComponents;
    
    
    /// <summary>
    /// A document providing details relating to a transport service, such as transport movement, identification of equipment and goods, subcontracted service providers, etc.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Goods Item Itinerary. Details
    /// <para />ObjectClass: Goods Item Itinerary
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GoodsItemItinerary", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2")]
    [System.Xml.Serialization.XmlRootAttribute("GoodsItemItinerary", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2", IsNullable=false)]
    public partial class GoodsItemItineraryType : BaseDocument
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType @__VersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TransportExecutionPlanReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType @__TransportExecutionPlanReferenceID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<ConsignmentType> @__ReferencedConsignment;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<TransportEquipmentType> @__ReferencedTransportEquipment;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<PackageType> @__ReferencedPackage;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<GoodsItemType> @__ReferencedGoodsItem;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<TransportationSegmentType> @__TransportationSegment;
        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Issue Time. Time
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get
            {
                if (__Note == null) { __Note = new System.Collections.Generic.List<TextType>(); }
                return __Note;
            }
            set
            {
                __Note = value;
            }
        }

        /// <summary>
        /// Identifies a version of a Goods Item Itinerary in order to distinguish updates.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Version. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType VersionID
        {
            get
            {
                if (__VersionID == null) { __VersionID = new IdentifierType(); }
                return __VersionID;
            }
            set
            {
                __VersionID = value;
            }
        }

        /// <summary>
        /// The Transport Execution Plan associated with this Goods Item Itinerary.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Transport Execution Plan Reference. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Transport Execution Plan Reference
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType TransportExecutionPlanReferenceID
        {
            get
            {
                if (__TransportExecutionPlanReferenceID == null) { __TransportExecutionPlanReferenceID = new IdentifierType(); }
                return __TransportExecutionPlanReferenceID;
            }
            set
            {
                __TransportExecutionPlanReferenceID = value;
            }
        }

        /// <summary>
        /// The sender of this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Sender_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Sender
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SenderParty
        {
            get
            {
                if (__SenderParty == null) { __SenderParty = new PartyType(); }
                return __SenderParty;
            }
            set
            {
                __SenderParty = value;
            }
        }

        /// <summary>
        /// The receiver of this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Receiver_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        /// <summary>
        /// A consignment being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Consignment. Consignment
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Consignment
        /// <para />AssociatedObjectClass: Consignment
        /// <para />RepresentationTerm: Consignment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ConsignmentType> ReferencedConsignment
        {
            get
            {
                if (__ReferencedConsignment == null) { __ReferencedConsignment = new System.Collections.Generic.List<ConsignmentType>(); }
                return __ReferencedConsignment;
            }
            set
            {
                __ReferencedConsignment = value;
            }
        }

        /// <summary>
        /// Transport equipment being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Transport Equipment. Transport Equipment
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Transport Equipment
        /// <para />AssociatedObjectClass: Transport Equipment
        /// <para />RepresentationTerm: Transport Equipment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TransportEquipmentType> ReferencedTransportEquipment
        {
            get
            {
                if (__ReferencedTransportEquipment == null) { __ReferencedTransportEquipment = new System.Collections.Generic.List<TransportEquipmentType>(); }
                return __ReferencedTransportEquipment;
            }
            set
            {
                __ReferencedTransportEquipment = value;
            }
        }

        /// <summary>
        /// A package being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Package. Package
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Package
        /// <para />AssociatedObjectClass: Package
        /// <para />RepresentationTerm: Package
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<PackageType> ReferencedPackage
        {
            get
            {
                if (__ReferencedPackage == null) { __ReferencedPackage = new System.Collections.Generic.List<PackageType>(); }
                return __ReferencedPackage;
            }
            set
            {
                __ReferencedPackage = value;
            }
        }

        /// <summary>
        /// An item of goods being transported in the transport service associated with this Goods Item Itinerary.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Referenced_ Goods Item. Goods Item
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Goods Item
        /// <para />AssociatedObjectClass: Goods Item
        /// <para />RepresentationTerm: Goods Item
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<GoodsItemType> ReferencedGoodsItem
        {
            get
            {
                if (__ReferencedGoodsItem == null) { __ReferencedGoodsItem = new System.Collections.Generic.List<GoodsItemType>(); }
                return __ReferencedGoodsItem;
            }
            set
            {
                __ReferencedGoodsItem = value;
            }
        }

        /// <summary>
        /// A part of a transport service that has its own Transport Execution Plan. A Transportation Segment may cover services other than transport, such as terminal handling, document management, customs procedures, etc.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Goods Item Itinerary. Transportation Segment
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Goods Item Itinerary
        /// <para />PropertyTerm: Transportation Segment
        /// <para />AssociatedObjectClass: Transportation Segment
        /// <para />RepresentationTerm: Transportation Segment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TransportationSegmentType> TransportationSegment
        {
            get
            {
                if (__TransportationSegment == null) { __TransportationSegment = new System.Collections.Generic.List<TransportationSegmentType>(); }
                return __TransportationSegment;
            }
            set
            {
                __TransportationSegment = value;
            }
        }

    }
}
