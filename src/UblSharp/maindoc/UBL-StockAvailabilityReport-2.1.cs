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
    /// A report on the quantities of each item that are, or will be, in stock. This document is sent by a Seller (for example a producer) to a Buyer (for example a retailer).
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Stock Availability Report. Details
    /// <para />ObjectClass: Stock Availability Report
    /// <para />AlternativeBusinessTerms: Storage status report.
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("StockAvailabilityReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:StockAvailabilityReport-2")]
    [System.Xml.Serialization.XmlRootAttribute("StockAvailabilityReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:StockAvailabilityReport-2", IsNullable=false)]
    public partial class StockAvailabilityReportType : BaseDocument
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType @__DocumentCurrencyCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("InventoryPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType @__InventoryPeriod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<DocumentReferenceType> @__DocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RetailerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType @__RetailerCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("InventoryReportingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__InventoryReportingParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("StockAvailabilityReportLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<StockAvailabilityReportLineType> @__StockAvailabilityReportLine;
        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Stock Availability Report
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
        /// <para />DictionaryEntryName: Stock Availability Report. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Stock Availability Report
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
        /// <para />DictionaryEntryName: Stock Availability Report. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Stock Availability Report
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
        /// <para />DictionaryEntryName: Stock Availability Report. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Stock Availability Report
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
        /// A code signifying the default currency for this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Document_ Currency Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Stock Availability Report
        /// <para />PropertyTermQualifier: Document
        /// <para />PropertyTerm: Currency Code
        /// <para />RepresentationTerm: Code
        /// <para />DataTypeQualifier: Currency
        /// <para />DataType: Currency_ Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType DocumentCurrencyCode
        {
            get
            {
                if (__DocumentCurrencyCode == null) { __DocumentCurrencyCode = new CodeType(); }
                return __DocumentCurrencyCode;
            }
            set
            {
                __DocumentCurrencyCode = value;
            }
        }

        /// <summary>
        /// The inventory period covered by the Report.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Inventory_ Period. Period
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Stock Availability Report
        /// <para />PropertyTermQualifier: Inventory
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PeriodType InventoryPeriod
        {
            get
            {
                if (__InventoryPeriod == null) { __InventoryPeriod = new PeriodType(); }
                return __InventoryPeriod;
            }
            set
            {
                __InventoryPeriod = value;
            }
        }

        /// <summary>
        /// A reference to another document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Stock Availability Report
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
        {
            get
            {
                if (__DocumentReference == null) { __DocumentReference = new System.Collections.Generic.List<DocumentReferenceType>(); }
                return __DocumentReference;
            }
            set
            {
                __DocumentReference = value;
            }
        }

        /// <summary>
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Stock Availability Report
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
        /// The retailer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Retailer_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Stock Availability Report
        /// <para />PropertyTermQualifier: Retailer
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType RetailerCustomerParty
        {
            get
            {
                if (__RetailerCustomerParty == null) { __RetailerCustomerParty = new CustomerPartyType(); }
                return __RetailerCustomerParty;
            }
            set
            {
                __RetailerCustomerParty = value;
            }
        }

        /// <summary>
        /// The party that will receive and use the Stock Availability Report (normally the branch for which the stock is reported).
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Inventory Reporting_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Stock Availability Report
        /// <para />PropertyTermQualifier: Inventory Reporting
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType InventoryReportingParty
        {
            get
            {
                if (__InventoryReportingParty == null) { __InventoryReportingParty = new PartyType(); }
                return __InventoryReportingParty;
            }
            set
            {
                __InventoryReportingParty = value;
            }
        }

        /// <summary>
        /// A line representing a particular item of sale and associated with a line in the Catalogue.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Stock Availability Report. Stock Availability Report Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Stock Availability Report
        /// <para />PropertyTerm: Stock Availability Report Line
        /// <para />AssociatedObjectClass: Stock Availability Report Line
        /// <para />RepresentationTerm: Stock Availability Report Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<StockAvailabilityReportLineType> StockAvailabilityReportLine
        {
            get
            {
                if (__StockAvailabilityReportLine == null) { __StockAvailabilityReportLine = new System.Collections.Generic.List<StockAvailabilityReportLineType>(); }
                return __StockAvailabilityReportLine;
            }
            set
            {
                __StockAvailabilityReportLine = value;
            }
        }

    }
}
