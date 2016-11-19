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
    /// A document used to update information about prices in an existing Catalogue.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Catalogue Pricing Update. Details
    /// <para />ObjectClass: Catalogue Pricing Update
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CataloguePricingUpdate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CataloguePricingUpdate-2")]
    [System.Xml.Serialization.XmlRootAttribute("CataloguePricingUpdate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CataloguePricingUpdate-2", IsNullable=false)]
    public partial class CataloguePricingUpdateType : BaseDocument
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType @__Name;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RevisionDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType @__RevisionDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RevisionTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType @__RevisionTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Description;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType @__VersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType @__LineCountNumeric;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<PeriodType> @__ValidityPeriod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RelatedCatalogueReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CatalogueReferenceType @__RelatedCatalogueReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedContract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<ContractType> @__ReferencedContract;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ProviderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType @__ContractorCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TradingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TradingTermsType @__TradingTerms;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DefaultLanguage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LanguageType @__DefaultLanguage;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CataloguePricingUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<CataloguePricingUpdateLineType> @__CataloguePricingUpdateLine;
        
        /// <summary>
        /// Text, assigned by the sender, that identifies this document to business users.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Name
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Name
        /// <para />RepresentationTerm: Name
        /// <para />DataType: Name. Type
        /// </summary>
        /// <example>Seasonal Promotion</example>
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
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Pricing Update
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
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
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
        /// The date, assigned by the seller, on which the Catalogue was revised.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Revision Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Revision Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType RevisionDate
        {
            get
            {
                if (__RevisionDate == null) { __RevisionDate = new DateType(); }
                return __RevisionDate;
            }
            set
            {
                __RevisionDate = value;
            }
        }

        /// <summary>
        /// The time, assigned by the seller, at which the Catalogue was revised.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Revision Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Revision Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType RevisionTime
        {
            get
            {
                if (__RevisionTime == null) { __RevisionTime = new TimeType(); }
                return __RevisionTime;
            }
            set
            {
                __RevisionTime = value;
            }
        }

        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Pricing Update
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
        /// Describes the Catalogue Revision.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Description. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Description
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        /// <example>adjustment of prices for Christmas trading period</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Description
        {
            get
            {
                if (__Description == null) { __Description = new System.Collections.Generic.List<TextType>(); }
                return __Description;
            }
            set
            {
                __Description = value;
            }
        }

        /// <summary>
        /// Indicates the current version of the catalogue.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>1.1</example>
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
        /// The number of lines in the document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Line Count. Numeric
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Line Count
        /// <para />RepresentationTerm: Numeric
        /// <para />DataType: Numeric. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public NumericType LineCountNumeric
        {
            get
            {
                if (__LineCountNumeric == null) { __LineCountNumeric = new NumericType(); }
                return __LineCountNumeric;
            }
            set
            {
                __LineCountNumeric = value;
            }
        }

        /// <summary>
        /// A period, assigned by the seller, during which the information in the Catalogue Revision is effective. This may be given as start and end dates or as a duration.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Validity_ Period. Period
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTermQualifier: Validity
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<PeriodType> ValidityPeriod
        {
            get
            {
                if (__ValidityPeriod == null) { __ValidityPeriod = new System.Collections.Generic.List<PeriodType>(); }
                return __ValidityPeriod;
            }
            set
            {
                __ValidityPeriod = value;
            }
        }

        /// <summary>
        /// A reference to the Catalogue being updated.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Related_ Catalogue Reference. Catalogue Reference
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTermQualifier: Related
        /// <para />PropertyTerm: Catalogue Reference
        /// <para />AssociatedObjectClass: Catalogue Reference
        /// <para />RepresentationTerm: Catalogue Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CatalogueReferenceType RelatedCatalogueReference
        {
            get
            {
                if (__RelatedCatalogueReference == null) { __RelatedCatalogueReference = new CatalogueReferenceType(); }
                return __RelatedCatalogueReference;
            }
            set
            {
                __RelatedCatalogueReference = value;
            }
        }

        /// <summary>
        /// A contract or framework agreement with which the Catalogue is associated.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Referenced_ Contract. Contract
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Contract
        /// <para />AssociatedObjectClass: Contract
        /// <para />RepresentationTerm: Contract
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ContractType> ReferencedContract
        {
            get
            {
                if (__ReferencedContract == null) { __ReferencedContract = new System.Collections.Generic.List<ContractType>(); }
                return __ReferencedContract;
            }
            set
            {
                __ReferencedContract = value;
            }
        }

        /// <summary>
        /// The party sending the Catalogue Pricing Update.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Provider_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTermQualifier: Provider
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ProviderParty
        {
            get
            {
                if (__ProviderParty == null) { __ProviderParty = new PartyType(); }
                return __ProviderParty;
            }
            set
            {
                __ProviderParty = value;
            }
        }

        /// <summary>
        /// The party receiving the Catalogue Pricing Update.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Receiver_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Pricing Update
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
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTermQualifier: Seller
        /// <para />PropertyTerm: Supplier Party
        /// <para />AssociatedObjectClass: Supplier Party
        /// <para />RepresentationTerm: Supplier Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
                return __SellerSupplierParty;
            }
            set
            {
                __SellerSupplierParty = value;
            }
        }

        /// <summary>
        /// The customer party responsible for the contracts with which the Catalogue is associated.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Contractor_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTermQualifier: Contractor
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                if (__ContractorCustomerParty == null) { __ContractorCustomerParty = new CustomerPartyType(); }
                return __ContractorCustomerParty;
            }
            set
            {
                __ContractorCustomerParty = value;
            }
        }

        /// <summary>
        /// The trading terms associated with the Catalogue.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Trading Terms
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Trading Terms
        /// <para />AssociatedObjectClass: Trading Terms
        /// <para />RepresentationTerm: Trading Terms
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TradingTermsType TradingTerms
        {
            get
            {
                if (__TradingTerms == null) { __TradingTerms = new TradingTermsType(); }
                return __TradingTerms;
            }
            set
            {
                __TradingTerms = value;
            }
        }

        /// <summary>
        /// The default language for the catalogue pricing update.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Default_ Language. Language
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTermQualifier: Default
        /// <para />PropertyTerm: Language
        /// <para />AssociatedObjectClass: Language
        /// <para />RepresentationTerm: Language
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public LanguageType DefaultLanguage
        {
            get
            {
                if (__DefaultLanguage == null) { __DefaultLanguage = new LanguageType(); }
                return __DefaultLanguage;
            }
            set
            {
                __DefaultLanguage = value;
            }
        }

        /// <summary>
        /// One or more lines in the Catalogue Pricing Update, each line updating a specific catalogue item.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Pricing Update. Catalogue Pricing Update Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Catalogue Pricing Update
        /// <para />PropertyTerm: Catalogue Pricing Update Line
        /// <para />AssociatedObjectClass: Catalogue Pricing Update Line
        /// <para />RepresentationTerm: Catalogue Pricing Update Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<CataloguePricingUpdateLineType> CataloguePricingUpdateLine
        {
            get
            {
                if (__CataloguePricingUpdateLine == null) { __CataloguePricingUpdateLine = new System.Collections.Generic.List<CataloguePricingUpdateLineType>(); }
                return __CataloguePricingUpdateLine;
            }
            set
            {
                __CataloguePricingUpdateLine = value;
            }
        }

    }
}
