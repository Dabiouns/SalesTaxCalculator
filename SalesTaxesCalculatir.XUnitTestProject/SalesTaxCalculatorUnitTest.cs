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
            IInvoice invoiceInput1 = InvoiceGenerator.GetInvoice1();
            InvoiceCalculator invoiceCalculator = new InvoiceCalculator();
            invoiceCalculator.CreateTaxes(invoiceInput1);
            invoiceCalculator.ApplyTaxes(invoiceInput1);

            var expectedTaxTotal = 1.50;
            var expectedTotal = 29.83;


            var TaxTotal = invoiceInput1.TotalTax == expectedTaxTotal;
            var Total = invoiceInput1.Total == expectedTotal;
            Assert.True(TaxTotal & Total, "Test failed for input 1 ");
        }

        [Fact]
        public void TestInput2()
        {
            IInvoice invoiceInput2 = InvoiceGenerator.GetInvoice2();
            InvoiceCalculator invoiceCalculator = new InvoiceCalculator();
            invoiceCalculator.CreateTaxes(invoiceInput2);
            invoiceCalculator.ApplyTaxes(invoiceInput2);
            Console.Write(invoiceCalculator.PrintReceipt(invoiceInput2));

            var expectedTaxTotal =  7.65;
            var expectedTotal = 65.15;


            var TaxTotal = invoiceInput2.TotalTax == expectedTaxTotal;
            var Total = invoiceInput2.Total == expectedTotal;
            Assert.True(TaxTotal & Total, "Test failed for input 2 ");
        }

        [Fact]
        public void TestInput3()
        {

            IInvoice invoiceInput3 = InvoiceGenerator.GetInvoice3();
            InvoiceCalculator invoiceCalculator = new InvoiceCalculator();
            invoiceCalculator.CreateTaxes(invoiceInput3);
            invoiceCalculator.ApplyTaxes(invoiceInput3);
            Console.Write(invoiceCalculator.PrintReceipt(invoiceInput3));

            var expectedTaxTotal = 6.70;
            var expectedTotal = 74.68;


            var TaxTotal = invoiceInput3.TotalTax == expectedTaxTotal;
            var Total = invoiceInput3.Total == expectedTotal;
            Assert.True(TaxTotal & Total, "Test failed for input 3 ");
        }


     
    }
}
