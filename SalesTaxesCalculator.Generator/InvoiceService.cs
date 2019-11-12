using SalesTaxesCalculator.Interface;
using SalesTaxesCalculator.Invoice.Implementation;

namespace SalesTaxesCalculator
{
    public class InvoiceService : IInvoiceService
    {
        public IInvoice CompileInvoice(IInvoice invoice)
        {
            new InvoiceCalculator().ApplyTaxes(invoice);
            return invoice;
        }

        public string PrintReceipt(IInvoice invoice)
        {
            return new InvoiceCalculator().PrintReceipt(invoice);
        }

    }
}
