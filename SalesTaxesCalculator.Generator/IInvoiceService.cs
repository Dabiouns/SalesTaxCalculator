using SalesTaxesCalculator.Interface;

namespace SalesTaxesCalculator
{
    public interface IInvoiceService
    {
        IInvoice CompileInvoice(IInvoice invoice);
        string PrintReceipt(IInvoice invoice);
    }
}