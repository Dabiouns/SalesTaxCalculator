using SalesTaxesCalculator.Interface;
using System;
using SalesTaxesCalculator.Invoice.Implementation;

namespace SalesTaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoice invoiceInput1 = InvoiceGenerator.GetInvoice1();
            InvoiceCalculator invoiceCalculator = new InvoiceCalculator();
            invoiceCalculator.CreateTaxes(invoiceInput1);
            invoiceCalculator.ApplyTaxes(invoiceInput1);
            Console.Write(invoiceCalculator.PrintReceipt(invoiceInput1));

            IInvoice invoiceInput2 = InvoiceGenerator.GetInvoice2();
            invoiceCalculator.CreateTaxes(invoiceInput2);
            invoiceCalculator.ApplyTaxes(invoiceInput2);
            Console.Write(invoiceCalculator.PrintReceipt(invoiceInput2));

            IInvoice invoiceInput3 = InvoiceGenerator.GetInvoice3();
            invoiceCalculator.CreateTaxes(invoiceInput3);
            invoiceCalculator.ApplyTaxes(invoiceInput3);
            Console.Write(invoiceCalculator.PrintReceipt(invoiceInput3));
        }
    }
}
