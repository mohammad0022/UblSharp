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
    /// A document used to cancel an entire Catalogue.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Catalogue Deletion. Details
    /// <para />ObjectClass: Catalogue Deletion
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CatalogueDeletion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueDeletion-2")]
    [System.Xml.Serialization.XmlRootAttribute("CatalogueDeletion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueDeletion-2", IsNullable=false)]
    public partial class CatalogueDeletionType : BaseDocument
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
        [System.Xml.Serialization.XmlElementAttribute("EffectiveDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType @__EffectiveDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType @__EffectiveTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType @__VersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Description;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<PeriodType> @__ValidityPeriod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DeletedCatalogueReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CatalogueReferenceType @__DeletedCatalogueReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedContract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<ContractType> @__ReferencedContract;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ProviderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType @__ContractorCustomerParty;
        
        /// <summary>
        /// Text, assigned by the sender, that identifies this document to business users.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Name
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Deletion
        /// <para />PropertyTerm: Name
        /// <para />RepresentationTerm: Name
        /// <para />DataType: Name. Type
        /// </summary>
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
        /// <para />DictionaryEntryName: Catalogue Deletion. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Deletion
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
        /// <para />DictionaryEntryName: Catalogue Deletion. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Deletion
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
        /// The effective date, assigned by the seller, on which the Catalogue expires.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Effective Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Deletion
        /// <para />PropertyTerm: Effective Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType EffectiveDate
        {
            get
            {
                if (__EffectiveDate == null) { __EffectiveDate = new DateType(); }
                return __EffectiveDate;
            }
            set
            {
                __EffectiveDate = value;
            }
        }

        /// <summary>
        /// The effective time, assigned by the seller, at which the Catalogue expires.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Effective Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Deletion
        /// <para />PropertyTerm: Effective Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType EffectiveTime
        {
            get
            {
                if (__EffectiveTime == null) { __EffectiveTime = new TimeType(); }
                return __EffectiveTime;
            }
            set
            {
                __EffectiveTime = value;
            }
        }

        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Deletion
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
        /// Identifies the current version of the Catalogue.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Deletion
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
        /// Textual description of the document instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Description. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Deletion
        /// <para />PropertyTerm: Description
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        /// <example>stock no longer provided</example>
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
        /// The period during which the Deletion of the catalogue becomes effective. This may be given as start (after date) and end dates (before date).
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Validity_ Period. Period
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Deletion
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
        /// A reference to the Catalogue being deleted.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Deleted_ Catalogue Reference. Catalogue Reference
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Deletion
        /// <para />PropertyTermQualifier: Deleted
        /// <para />PropertyTerm: Catalogue Reference
        /// <para />AssociatedObjectClass: Catalogue Reference
        /// <para />RepresentationTerm: Catalogue Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CatalogueReferenceType DeletedCatalogueReference
        {
            get
            {
                if (__DeletedCatalogueReference == null) { __DeletedCatalogueReference = new CatalogueReferenceType(); }
                return __DeletedCatalogueReference;
            }
            set
            {
                __DeletedCatalogueReference = value;
            }
        }

        /// <summary>
        /// A contract or framework agreement with which the Catalogue was associated.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Referenced_ Contract. Contract
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue Deletion
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
        /// The party receiving the Catalogue Deletion.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Receiver_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Deletion
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
        /// The party sending the Catalogue Deletion.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Provider_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue Deletion
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
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Deletion
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
        /// The customer party responsible for the contracts with which the Catalogue was associated.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue Deletion. Contractor_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue Deletion
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

    }
}
