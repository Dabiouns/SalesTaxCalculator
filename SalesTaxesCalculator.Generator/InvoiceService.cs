using SalesTaxesCalculator.Interface;
using SalesTaxesCalculator.Invoice.Implementation;
using System.Collections.Generic;

namespace SalesTaxesCalculator
{
    public class InvoiceService : IInvoiceService
    {
        public IInvoice CompileInvoice(IInvoice invoice)
        {
            InvoiceCalculator invoiceCalculator = new InvoiceCalculator();
            invoiceCalculator.CreateTaxes(invoice);
            invoiceCalculator.ApplyTaxes(invoice);
            return invoice;
        }

        public string PrintReceipt(IInvoice invoice)
        {
            return new InvoiceCalculator().PrintReceipt(invoice);
        }


      

        public IInvoice GetInput1()
        {
            IInvoice invoiceInput1 = InvoiceGenerator.GetInvoice1();
            CompileInvoice(invoiceInput1);

            return invoiceInput1;
        }

        public IInvoice GetInput2()
        {
            IInvoice invoiceInput2 = InvoiceGenerator.GetInvoice2();
            CompileInvoice(invoiceInput2);

            return invoiceInput2;

        }

        public IInvoice GetInput3()
        {
            IInvoice invoiceInput3 = InvoiceGenerator.GetInvoice3();
            CompileInvoice(invoiceInput3);

            return invoiceInput3;

        }



    }
}
