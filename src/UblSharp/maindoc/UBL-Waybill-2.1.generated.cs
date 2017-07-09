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
    /// A transport document describing a shipment It is issued by the party who undertakes to provide transportation services, or undertakes to arrange for their provision, to the party who gives instructions for the transportation services (shipper, consignor, etc.). It states the instructions for the beneficiary and may contain the details of the transportation, charges, and terms and conditions under which the transportation service is provided.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Waybill. Details
    /// <para />ObjectClass: Waybill
    /// <para />AlternativeBusinessTerms: Consignment Note
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Waybill", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Waybill-2")]
    [System.Xml.Serialization.XmlRootAttribute("Waybill", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Waybill-2", IsNullable=false)]
    public partial class WaybillType : BaseDocument, IBaseDocument
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CarrierAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IdentifierType @__CarrierAssignedID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public NameType @__Name;
        
        private System.Collections.Generic.List<TextType> _description;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public TextType[] @__Description
        {
            get
            {
                return _description?.ToArray();
            }
            set
            {
                _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public TextType[] @__Note
        {
            get
            {
                return _note?.ToArray();
            }
            set
            {
                _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ShippingOrderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public IdentifierType @__ShippingOrderID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AdValoremIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public IndicatorType @__AdValoremIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DeclaredCarriageValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
        public AmountType @__DeclaredCarriageValueAmount;
        
        private System.Collections.Generic.List<TextType> _otherInstruction;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OtherInstruction", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
        public TextType[] @__OtherInstruction
        {
            get
            {
                return _otherInstruction?.ToArray();
            }
            set
            {
                _otherInstruction = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ConsignorParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public PartyType @__ConsignorParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CarrierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public PartyType @__CarrierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("FreightForwarderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public PartyType @__FreightForwarderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public ShipmentType @__Shipment;
        
        private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public DocumentReferenceType[] @__DocumentReference
        {
            get
            {
                return _documentReference?.ToArray();
            }
            set
            {
                _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
            }
        }
        
        private System.Collections.Generic.List<ExchangeRateType> _exchangeRate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public ExchangeRateType[] @__ExchangeRate
        {
            get
            {
                return _exchangeRate?.ToArray();
            }
            set
            {
                _exchangeRate = value == null ? null : new System.Collections.Generic.List<ExchangeRateType>(value);
            }
        }
        
        private System.Collections.Generic.List<DocumentDistributionType> _documentDistribution;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public DocumentDistributionType[] @__DocumentDistribution
        {
            get
            {
                return _documentDistribution?.ToArray();
            }
            set
            {
                _documentDistribution = value == null ? null : new System.Collections.Generic.List<DocumentDistributionType>(value);
            }
        }
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=24)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// Text describing the contents of the Waybill.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Description. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Description
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Description
        {
            get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
            set { _description = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// Other free-text instructions related to the shipment to the forwarders or carriers. This should only be used where such information cannot be represented in other structured information entities within the document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Other_ Instruction. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTermQualifier: Other
        /// <para />PropertyTerm: Instruction
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> OtherInstruction
        {
            get { return _otherInstruction ?? (_otherInstruction = new System.Collections.Generic.List<TextType>()); }
            set { _otherInstruction = value; }
        }

        
        /// <summary>
        /// A reference to another document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
        {
            get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
            set { _documentReference = value; }
        }

        
        /// <summary>
        /// Information about the rate of exchange (conversion) between two currencies.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Exchange Rate
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Exchange Rate
        /// <para />AssociatedObjectClass: Exchange Rate
        /// <para />RepresentationTerm: Exchange Rate
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ExchangeRateType> ExchangeRate
        {
            get { return _exchangeRate ?? (_exchangeRate = new System.Collections.Generic.List<ExchangeRateType>()); }
            set { _exchangeRate = value; }
        }

        
        /// <summary>
        /// A list of interested parties to whom this document is distributed.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Document Distribution
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Document Distribution
        /// <para />AssociatedObjectClass: Document Distribution
        /// <para />RepresentationTerm: Document Distribution
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentDistributionType> DocumentDistribution
        {
            get { return _documentDistribution ?? (_documentDistribution = new System.Collections.Generic.List<DocumentDistributionType>()); }
            set { _documentDistribution = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0.5</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>NES</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BasicProcurementProcess</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BPP-1001</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// <para />AlternativeBusinessTerms: Master Waybill Number
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// An identifier (in the form of a reference number) assigned by a carrier or its agent to identify a specific shipment.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Carrier Assigned_ Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTermQualifier: Carrier Assigned
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType CarrierAssignedID
        {
            get
            {
                if (__CarrierAssignedID == null) { __CarrierAssignedID = new IdentifierType(); }
                return __CarrierAssignedID;
            }
            set
            {
                __CarrierAssignedID = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Issue Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
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
        /// <para />DictionaryEntryName: Waybill. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
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
        /// Text, assigned by the sender, that identifies this document to business users.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Name
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Name
        /// <para />RepresentationTerm: Name
        /// <para />DataType: Name. Type
        /// </summary>
        /// <example>Air Waybill , House Waybill</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public NameType Name
        {
            get
            {
                if (__Name == null) { __Name = new NameType(); }
                return __Name;
            }
            set
            {
                __Name = value;
            }
        }

        
        /// <summary>
        /// An identifier (in the form of a reference number) of the Shipping Order or Forwarding Instruction associated with this shipment.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Shipping Order Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Shipping Order Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ShippingOrderID
        {
            get
            {
                if (__ShippingOrderID == null) { __ShippingOrderID = new IdentifierType(); }
                return __ShippingOrderID;
            }
            set
            {
                __ShippingOrderID = value;
            }
        }

        
        /// <summary>
        /// A term used in commerce in reference to certain duties, called ad valorem duties, which are levied on commodities at certain rates per centum on their value.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Ad Valorem_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTermQualifier: Ad Valorem
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType AdValoremIndicator
        {
            get
            {
                if (__AdValoremIndicator == null) { __AdValoremIndicator = new IndicatorType(); }
                return __AdValoremIndicator;
            }
            set
            {
                __AdValoremIndicator = value;
            }
        }

        
        /// <summary>
        /// Value declared by the shipper or his agent solely for the purpose of varying the carrier&apos;s level of liability from that provided in the contract of carriage in case of loss or damage to goods or delayed delivery.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Waybill. Declared Carriage_ Value. Amount
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTermQualifier: Declared Carriage
        /// <para />PropertyTerm: Value
        /// <para />RepresentationTerm: Amount
        /// <para />DataType: Amount. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public AmountType DeclaredCarriageValueAmount
        {
            get
            {
                if (__DeclaredCarriageValueAmount == null) { __DeclaredCarriageValueAmount = new AmountType(); }
                return __DeclaredCarriageValueAmount;
            }
            set
            {
                __DeclaredCarriageValueAmount = value;
            }
        }

        
        /// <summary>
        /// The party consigning goods, as stipulated in the transport contract by the party ordering transport.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Consignor_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTermQualifier: Consignor
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// <para />AlternativeBusinessTerms: Consignor (WCO ID 71 and 72)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ConsignorParty
        {
            get
            {
                if (__ConsignorParty == null) { __ConsignorParty = new PartyType(); }
                return __ConsignorParty;
            }
            set
            {
                __ConsignorParty = value;
            }
        }

        
        /// <summary>
        /// The party providing the transport of goods between named points.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Carrier_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTermQualifier: Carrier
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// <para />AlternativeBusinessTerms: Transport Company, Shipping Line, NVOCC, Airline, Haulier, Courier, Carrier (WCO ID 49 and 50)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType CarrierParty
        {
            get
            {
                if (__CarrierParty == null) { __CarrierParty = new PartyType(); }
                return __CarrierParty;
            }
            set
            {
                __CarrierParty = value;
            }
        }

        
        /// <summary>
        /// A party combining individual smaller consignments into a single larger shipment (a so-called consolidated consignment or shipment) that is sent to a counterpart who mirrors the consolidator&apos;s activity by dividing the consolidated consignment into its original components.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Freight Forwarder_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTermQualifier: Freight Forwarder
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// <para />AlternativeBusinessTerms: Consolidator (WCO ID 192 AND 193)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType FreightForwarderParty
        {
            get
            {
                if (__FreightForwarderParty == null) { __FreightForwarderParty = new PartyType(); }
                return __FreightForwarderParty;
            }
            set
            {
                __FreightForwarderParty = value;
            }
        }

        
        /// <summary>
        /// A description of the shipment.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Waybill. Shipment
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Waybill
        /// <para />PropertyTerm: Shipment
        /// <para />AssociatedObjectClass: Shipment
        /// <para />RepresentationTerm: Shipment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ShipmentType Shipment
        {
            get
            {
                if (__Shipment == null) { __Shipment = new ShipmentType(); }
                return __Shipment;
            }
            set
            {
                __Shipment = value;
            }
        }

    }
}
