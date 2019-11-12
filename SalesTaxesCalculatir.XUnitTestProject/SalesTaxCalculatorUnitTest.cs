using SalesTaxesCalculator;
using SalesTaxesCalculator.Interface;
using SalesTaxesCalculator.Invoice.Implementation;
using System;
using Xunit;

namespace SalesTaxesCalculatir.XUnitTestProject
{
    public class SalesTaxCalculatorUnitTest
    {
        [Fact]
        public void TestInput1()
        {
            IInvoice invoiceInput1 = new InvoiceService().GetInput1();
            
            var expectedTaxTotal = 1.50;
            var expectedTotal = 29.83;


            var TaxTotal = invoiceInput1.TotalTax == expectedTaxTotal;
            var Total = invoiceInput1.Total == expectedTotal;
            Assert.True(TaxTotal & Total, "Test failed for input 1 ");
        }

        [Fact]
        public void TestInput2()
        {
            IInvoice invoiceInput2 = new InvoiceService().GetInput2();

            var expectedTaxTotal =  7.65;
            var expectedTotal = 65.15;


            var TaxTotal = invoiceInput2.TotalTax == expectedTaxTotal;
            var Total = invoiceInput2.Total == expectedTotal;
            Assert.True(TaxTotal & Total, "Test failed for input 2 ");
        }

        [Fact]
        public void TestInput3()
        {
            IInvoice invoiceInput3 = new InvoiceService().GetInput3();

            var expectedTaxTotal = 6.70;
            var expectedTotal = 74.68;


            var TaxTotal = invoiceInput3.TotalTax == expectedTaxTotal;
            var Total = invoiceInput3.Total == expectedTotal;
            Assert.True(TaxTotal & Total, "Test failed for input 3 ");
        }


     
    }
}
