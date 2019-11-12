namespace SalesTaxesCalculator.Interface
{
    public interface IInvoiceCalculator
    {
        void CreateTaxes(IInvoice invoice);
        void ApplyTaxes(IInvoice invoice);
        string PrintReceipt(IInvoice invoice);
    }
}