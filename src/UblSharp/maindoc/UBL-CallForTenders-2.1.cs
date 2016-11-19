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
    /// A document used by a Contracting Party to define a procurement project to buy goods, services, or works during a specified period.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Call For Tenders. Details
    /// <para />ObjectClass: Call For Tenders
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CallForTenders", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2")]
    [System.Xml.Serialization.XmlRootAttribute("CallForTenders", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2", IsNullable=false)]
    public partial class CallForTendersType : BaseDocument
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractFolderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType @__ContractFolderID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ApprovalDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType @__ApprovalDate;
        
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
        [System.Xml.Serialization.XmlElementAttribute("PreviousVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType @__PreviousVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("LegalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType @__LegalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TechnicalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType @__TechnicalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<DocumentReferenceType> @__AdditionalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractingPartyType @__ContractingParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<CustomerPartyType> @__OriginatorCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TenderingTermsType @__TenderingTerms;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TenderingProcessType @__TenderingProcess;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ProcurementProjectType @__ProcurementProject;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<ProcurementProjectLotType> @__ProcurementProjectLot;
        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
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
        /// An identifier, assigned by the sender, for the process file (i.e., record) to which this document belongs.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Contract Folder Identifier. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Contract Folder Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ContractFolderID
        {
            get
            {
                if (__ContractFolderID == null) { __ContractFolderID = new IdentifierType(); }
                return __ContractFolderID;
            }
            set
            {
                __ContractFolderID = value;
            }
        }

        /// <summary>
        /// The date, assigned by the contracting party, on which the Call For Tenders was approved.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Approval Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Approval Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType ApprovalDate
        {
            get
            {
                if (__ApprovalDate == null) { __ApprovalDate = new DateType(); }
                return __ApprovalDate;
            }
            set
            {
                __ApprovalDate = value;
            }
        }

        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
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
        /// <para />DictionaryEntryName: Call For Tenders. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
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
        /// <para />DictionaryEntryName: Call For Tenders. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
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
        /// Indicates the current version of the Call for Tenders.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
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
        /// Identifies the previous version of the Call for Tenders which is superceded by this version.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Previous_ Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Previous
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>1.0</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType PreviousVersionID
        {
            get
            {
                if (__PreviousVersionID == null) { __PreviousVersionID = new IdentifierType(); }
                return __PreviousVersionID;
            }
            set
            {
                __PreviousVersionID = value;
            }
        }

        /// <summary>
        /// A reference to a legal document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Legal_ Document Reference. Document Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Legal
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType LegalDocumentReference
        {
            get
            {
                if (__LegalDocumentReference == null) { __LegalDocumentReference = new DocumentReferenceType(); }
                return __LegalDocumentReference;
            }
            set
            {
                __LegalDocumentReference = value;
            }
        }

        /// <summary>
        /// A reference to a technical document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Technical_ Document Reference. Document Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Technical
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType TechnicalDocumentReference
        {
            get
            {
                if (__TechnicalDocumentReference == null) { __TechnicalDocumentReference = new DocumentReferenceType(); }
                return __TechnicalDocumentReference;
            }
            set
            {
                __TechnicalDocumentReference = value;
            }
        }

        /// <summary>
        /// A reference to an additional document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Additional_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Additional
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> AdditionalDocumentReference
        {
            get
            {
                if (__AdditionalDocumentReference == null) { __AdditionalDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>(); }
                return __AdditionalDocumentReference;
            }
            set
            {
                __AdditionalDocumentReference = value;
            }
        }

        /// <summary>
        /// The contracting party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Contracting Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Contracting Party
        /// <para />AssociatedObjectClass: Contracting Party
        /// <para />RepresentationTerm: Contracting Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ContractingPartyType ContractingParty
        {
            get
            {
                if (__ContractingParty == null) { __ContractingParty = new ContractingPartyType(); }
                return __ContractingParty;
            }
            set
            {
                __ContractingParty = value;
            }
        }

        /// <summary>
        /// The party who originated Order.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Originator_ Customer Party. Customer Party
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Originator
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<CustomerPartyType> OriginatorCustomerParty
        {
            get
            {
                if (__OriginatorCustomerParty == null) { __OriginatorCustomerParty = new System.Collections.Generic.List<CustomerPartyType>(); }
                return __OriginatorCustomerParty;
            }
            set
            {
                __OriginatorCustomerParty = value;
            }
        }

        /// <summary>
        /// The party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Receiver_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
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
        /// The tendering terms associated with this tendering process.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Tendering Terms
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Tendering Terms
        /// <para />AssociatedObjectClass: Tendering Terms
        /// <para />RepresentationTerm: Tendering Terms
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TenderingTermsType TenderingTerms
        {
            get
            {
                if (__TenderingTerms == null) { __TenderingTerms = new TenderingTermsType(); }
                return __TenderingTerms;
            }
            set
            {
                __TenderingTerms = value;
            }
        }

        /// <summary>
        /// A description of the tendering process itself.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Tendering Process
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Tendering Process
        /// <para />AssociatedObjectClass: Tendering Process
        /// <para />RepresentationTerm: Tendering Process
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TenderingProcessType TenderingProcess
        {
            get
            {
                if (__TenderingProcess == null) { __TenderingProcess = new TenderingProcessType(); }
                return __TenderingProcess;
            }
            set
            {
                __TenderingProcess = value;
            }
        }

        /// <summary>
        /// An overall definition of this procurement project.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Procurement Project
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Procurement Project
        /// <para />AssociatedObjectClass: Procurement Project
        /// <para />RepresentationTerm: Procurement Project
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ProcurementProjectType ProcurementProject
        {
            get
            {
                if (__ProcurementProject == null) { __ProcurementProject = new ProcurementProjectType(); }
                return __ProcurementProject;
            }
            set
            {
                __ProcurementProject = value;
            }
        }

        /// <summary>
        /// One of the procurement project lots into which this contract can be split.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Procurement Project Lot
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Procurement Project Lot
        /// <para />AssociatedObjectClass: Procurement Project Lot
        /// <para />RepresentationTerm: Procurement Project Lot
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ProcurementProjectLotType> ProcurementProjectLot
        {
            get
            {
                if (__ProcurementProjectLot == null) { __ProcurementProjectLot = new System.Collections.Generic.List<ProcurementProjectLotType>(); }
                return __ProcurementProjectLot;
            }
            set
            {
                __ProcurementProjectLot = value;
            }
        }

    }
}
