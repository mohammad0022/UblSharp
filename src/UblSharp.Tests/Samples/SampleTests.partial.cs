// Generated by UblSharp.Tests.Generator
using System;
using Xunit;

namespace UblSharp.Tests
{
    public partial class SampleTests
    {
        [Fact]
        public void MyTransportationStatusTest()
        {
            bool areEqual = TestDocument("MyTransportationStatus.xml", Samples.MyTransportationStatus.Create);
        }


        [Fact]
        public void UBLCreditNote20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-CreditNote-2.0-Example.xml", Samples.UBLCreditNote20Example.Create);
            Assert.True(areEqual, "Written CreditNoteType differs from the one read");
        }


        [Fact]
        public void UBLCreditNote21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-CreditNote-2.1-Example.xml", Samples.UBLCreditNote21Example.Create);
            Assert.True(areEqual, "Written CreditNoteType differs from the one read");
        }


        [Fact]
        public void UBLDebitNote21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-DebitNote-2.1-Example.xml", Samples.UBLDebitNote21Example.Create);
            Assert.True(areEqual, "Written DebitNoteType differs from the one read");
        }


        [Fact]
        public void UBLDespatchAdvice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-DespatchAdvice-2.0-Example.xml", Samples.UBLDespatchAdvice20Example.Create);
            Assert.True(areEqual, "Written DespatchAdviceType differs from the one read");
        }


        [Fact]
        public void UBLExceptionCriteria21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ExceptionCriteria-2.1-Example.xml", Samples.UBLExceptionCriteria21Example.Create);
            Assert.True(areEqual, "Written ExceptionCriteriaType differs from the one read");
        }


        [Fact]
        public void UBLExceptionNotification21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ExceptionNotification-2.1-Example.xml", Samples.UBLExceptionNotification21Example.Create);
            Assert.True(areEqual, "Written ExceptionNotificationType differs from the one read");
        }


        [Fact]
        public void UBLForecast21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Forecast-2.1-Example.xml", Samples.UBLForecast21Example.Create);
            Assert.True(areEqual, "Written ForecastType differs from the one read");
        }


        [Fact]
        public void UBLForecastRevision21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ForecastRevision-2.1-Example.xml", Samples.UBLForecastRevision21Example.Create);
            Assert.True(areEqual, "Written ForecastRevisionType differs from the one read");
        }


        [Fact]
        public void UBLForwardingInstructions20ExampleInternationalTest()
        {
            bool areEqual = TestDocument("UBL-ForwardingInstructions-2.0-Example-International.xml", Samples.UBLForwardingInstructions20ExampleInternational.Create);
            Assert.True(areEqual, "Written ForwardingInstructionsType differs from the one read");
        }


        [Fact]
        public void UBLFreightInvoice21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-FreightInvoice-2.1-Example.xml", Samples.UBLFreightInvoice21Example.Create);
            Assert.True(areEqual, "Written FreightInvoiceType differs from the one read");
        }


        [Fact]
        public void UBLFulfilmentCancellation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-FulfilmentCancellation-2.1-Example.xml", Samples.UBLFulfilmentCancellation21Example.Create);
            Assert.True(areEqual, "Written FulfilmentCancellationType differs from the one read");
        }


        [Fact]
        public void UBLGoodsItemItinerary21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-GoodsItemItinerary-2.1-Example.xml", Samples.UBLGoodsItemItinerary21Example.Create);
            Assert.True(areEqual, "Written GoodsItemItineraryType differs from the one read");
        }


        [Fact]
        public void UBLInstructionForReturns21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-InstructionForReturns-2.1-Example.xml", Samples.UBLInstructionForReturns21Example.Create);
            Assert.True(areEqual, "Written InstructionForReturnsType differs from the one read");
        }


        [Fact]
        public void UBLInventoryReport21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-InventoryReport-2.1-Example.xml", Samples.UBLInventoryReport21Example.Create);
            Assert.True(areEqual, "Written InventoryReportType differs from the one read");
        }


        [Fact]
        public void UBLInvoice20DetachedTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Detached.xml", Samples.UBLInvoice20Detached.Create);
        }


        [Fact]
        public void UBLInvoice20EnvelopedTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Enveloped.xml", Samples.UBLInvoice20Enveloped.Create);
        }


        [Fact]
        public void UBLInvoice20ExampleNS1Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS1.xml", Samples.UBLInvoice20ExampleNS1.Create);
            Assert.True(areEqual, "Written InvoiceType differs from the one read");
        }


        [Fact]
        public void UBLInvoice20ExampleNS2Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS2.xml", Samples.UBLInvoice20ExampleNS2.Create);
            Assert.True(areEqual, "Written InvoiceType differs from the one read");
        }


        [Fact]
        public void UBLInvoice20ExampleNS3Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS3.xml", Samples.UBLInvoice20ExampleNS3.Create);
            Assert.True(areEqual, "Written InvoiceType differs from the one read");
        }


        [Fact]
        public void UBLInvoice20ExampleNS4Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS4.xml", Samples.UBLInvoice20ExampleNS4.Create);
            Assert.True(areEqual, "Written InvoiceType differs from the one read");
        }


        [Fact]
        public void UBLInvoice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example.xml", Samples.UBLInvoice20Example.Create);
            Assert.True(areEqual, "Written InvoiceType differs from the one read");
        }


        [Fact]
        public void UBLInvoice21ExampleTrivialTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.1-Example-Trivial.xml", Samples.UBLInvoice21ExampleTrivial.Create);
            Assert.True(areEqual, "Written InvoiceType differs from the one read");
        }


        [Fact]
        public void UBLInvoice21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.1-Example.xml", Samples.UBLInvoice21Example.Create);
            Assert.True(areEqual, "Written InvoiceType differs from the one read");
        }


        [Fact]
        public void UBLOrder20ExampleInternationalTest()
        {
            bool areEqual = TestDocument("UBL-Order-2.0-Example-International.xml", Samples.UBLOrder20ExampleInternational.Create);
            Assert.True(areEqual, "Written OrderType differs from the one read");
        }


        [Fact]
        public void UBLOrder20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Order-2.0-Example.xml", Samples.UBLOrder20Example.Create);
            Assert.True(areEqual, "Written OrderType differs from the one read");
        }


        [Fact]
        public void UBLOrder21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Order-2.1-Example.xml", Samples.UBLOrder21Example.Create);
            Assert.True(areEqual, "Written OrderType differs from the one read");
        }


        [Fact]
        public void UBLOrderCancellation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderCancellation-2.1-Example.xml", Samples.UBLOrderCancellation21Example.Create);
            Assert.True(areEqual, "Written OrderCancellationType differs from the one read");
        }


        [Fact]
        public void UBLOrderChange21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderChange-2.1-Example.xml", Samples.UBLOrderChange21Example.Create);
            Assert.True(areEqual, "Written OrderChangeType differs from the one read");
        }


        [Fact]
        public void UBLOrderResponse21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderResponse-2.1-Example.xml", Samples.UBLOrderResponse21Example.Create);
            Assert.True(areEqual, "Written OrderResponseType differs from the one read");
        }


        [Fact]
        public void UBLOrderResponseSimple20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderResponseSimple-2.0-Example.xml", Samples.UBLOrderResponseSimple20Example.Create);
            Assert.True(areEqual, "Written OrderResponseSimpleType differs from the one read");
        }


        [Fact]
        public void UBLOrderResponseSimple21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderResponseSimple-2.1-Example.xml", Samples.UBLOrderResponseSimple21Example.Create);
            Assert.True(areEqual, "Written OrderResponseSimpleType differs from the one read");
        }


        [Fact]
        public void UBLProductActivity21Example1Test()
        {
            bool areEqual = TestDocument("UBL-ProductActivity-2.1-Example-1.xml", Samples.UBLProductActivity21Example1.Create);
            Assert.True(areEqual, "Written ProductActivityType differs from the one read");
        }


        [Fact]
        public void UBLProductActivity21Example2Test()
        {
            bool areEqual = TestDocument("UBL-ProductActivity-2.1-Example-2.xml", Samples.UBLProductActivity21Example2.Create);
            Assert.True(areEqual, "Written ProductActivityType differs from the one read");
        }


        [Fact]
        public void UBLProductActivity21Example3Test()
        {
            bool areEqual = TestDocument("UBL-ProductActivity-2.1-Example-3.xml", Samples.UBLProductActivity21Example3.Create);
            Assert.True(areEqual, "Written ProductActivityType differs from the one read");
        }


        [Fact]
        public void UBLQuotation20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Quotation-2.0-Example.xml", Samples.UBLQuotation20Example.Create);
            Assert.True(areEqual, "Written QuotationType differs from the one read");
        }


        [Fact]
        public void UBLQuotation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Quotation-2.1-Example.xml", Samples.UBLQuotation21Example.Create);
            Assert.True(areEqual, "Written QuotationType differs from the one read");
        }


        [Fact]
        public void UBLReceiptAdvice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ReceiptAdvice-2.0-Example.xml", Samples.UBLReceiptAdvice20Example.Create);
            Assert.True(areEqual, "Written ReceiptAdviceType differs from the one read");
        }


        [Fact]
        public void UBLReminder21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Reminder-2.1-Example.xml", Samples.UBLReminder21Example.Create);
            Assert.True(areEqual, "Written ReminderType differs from the one read");
        }


        [Fact]
        public void UBLRemittanceAdvice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RemittanceAdvice-2.0-Example.xml", Samples.UBLRemittanceAdvice20Example.Create);
            Assert.True(areEqual, "Written RemittanceAdviceType differs from the one read");
        }


        [Fact]
        public void UBLRequestForQuotation20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RequestForQuotation-2.0-Example.xml", Samples.UBLRequestForQuotation20Example.Create);
            Assert.True(areEqual, "Written RequestForQuotationType differs from the one read");
        }


        [Fact]
        public void UBLRequestForQuotation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RequestForQuotation-2.1-Example.xml", Samples.UBLRequestForQuotation21Example.Create);
            Assert.True(areEqual, "Written RequestForQuotationType differs from the one read");
        }


        [Fact]
        public void UBLRetailEvent21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RetailEvent-2.1-Example.xml", Samples.UBLRetailEvent21Example.Create);
            Assert.True(areEqual, "Written RetailEventType differs from the one read");
        }


        [Fact]
        public void UBLSelfBilledCreditNote21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-SelfBilledCreditNote-2.1-Example.xml", Samples.UBLSelfBilledCreditNote21Example.Create);
            Assert.True(areEqual, "Written SelfBilledCreditNoteType differs from the one read");
        }


        [Fact]
        public void UBLStatement20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Statement-2.0-Example.xml", Samples.UBLStatement20Example.Create);
            Assert.True(areEqual, "Written StatementType differs from the one read");
        }


        [Fact]
        public void UBLStockAvailabilityReport21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-StockAvailabilityReport-2.1-Example.xml", Samples.UBLStockAvailabilityReport21Example.Create);
            Assert.True(areEqual, "Written StockAvailabilityReportType differs from the one read");
        }


        [Fact]
        public void UBLTradeItemLocationProfile21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TradeItemLocationProfile-2.1-Example.xml", Samples.UBLTradeItemLocationProfile21Example.Create);
            Assert.True(areEqual, "Written TradeItemLocationProfileType differs from the one read");
        }


        [Fact]
        public void UBLTransportationStatus21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportationStatus-2.1-Example.xml", Samples.UBLTransportationStatus21Example.Create);
            Assert.True(areEqual, "Written TransportationStatusType differs from the one read");
        }


        [Fact]
        public void UBLTransportationStatusRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportationStatusRequest-2.1-Example.xml", Samples.UBLTransportationStatusRequest21Example.Create);
            Assert.True(areEqual, "Written TransportationStatusRequestType differs from the one read");
        }


        [Fact]
        public void UBLTransportExecutionPlan21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportExecutionPlan-2.1-Example.xml", Samples.UBLTransportExecutionPlan21Example.Create);
            Assert.True(areEqual, "Written TransportExecutionPlanType differs from the one read");
        }


        [Fact]
        public void UBLTransportExecutionPlanRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportExecutionPlanRequest-2.1-Example.xml", Samples.UBLTransportExecutionPlanRequest21Example.Create);
            Assert.True(areEqual, "Written TransportExecutionPlanRequestType differs from the one read");
        }


        [Fact]
        public void UBLTransportProgressStatus21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportProgressStatus-2.1-Example.xml", Samples.UBLTransportProgressStatus21Example.Create);
            Assert.True(areEqual, "Written TransportProgressStatusType differs from the one read");
        }


        [Fact]
        public void UBLTransportProgressStatusRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportProgressStatusRequest-2.1-Example.xml", Samples.UBLTransportProgressStatusRequest21Example.Create);
            Assert.True(areEqual, "Written TransportProgressStatusRequestType differs from the one read");
        }


        [Fact]
        public void UBLTransportServiceDescription21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportServiceDescription-2.1-Example.xml", Samples.UBLTransportServiceDescription21Example.Create);
            Assert.True(areEqual, "Written TransportServiceDescriptionType differs from the one read");
        }


        [Fact]
        public void UBLTransportServiceDescriptionRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportServiceDescriptionRequest-2.1-Example.xml", Samples.UBLTransportServiceDescriptionRequest21Example.Create);
            Assert.True(areEqual, "Written TransportServiceDescriptionRequestType differs from the one read");
        }


        [Fact]
        public void UBLWaybill20ExampleInternationalTest()
        {
            bool areEqual = TestDocument("UBL-Waybill-2.0-Example-International.xml", Samples.UBLWaybill20ExampleInternational.Create);
            Assert.True(areEqual, "Written WaybillType differs from the one read");
        }



    }
}