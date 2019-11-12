using SalesTaxesCalculator.Generator;
using SalesTaxesCalculator.Interface;
using System.Linq;
using System.Text;

namespace SalesTaxesCalculator.Invoice.Implementation
{
    public  class InvoiceCalculator : IInvoiceCalculator
    {
      
        public string PrintReceipt(IInvoice invoice)
        {
            StringBuilder items = new StringBuilder();
            foreach (IItem item in invoice.Items)
            {
                items.AppendLine(item.ToString());
            }
         
            items.AppendLine(string.Format(SalesTaxesCalculator.RessourceFile.Resource.InvoiceTotal, 
                                            invoice.TotalTax, 
                                            invoice.Total));
            return items.ToString();
        }

        public void CreateTaxes(IInvoice invoice)
        {
            IItemCalculator itemCalculator = new ItemCalculator();
            invoice.Items.ForEach(item => itemCalculator.BuildItemTaxes(item));

        }

        public void ApplyTaxes(IInvoice invoice)
        {
            IItemCalculator itemCalculator = new ItemCalculator();
            invoice.Items.ForEach(item => itemCalculator.ApplyItemTaxes(item));
            invoice.TotalTax = invoice.Items.Sum(x => x.TotalTaxes);
            invoice.TotalTax = Util.RoundTo2Decimal(invoice.TotalTax);
            invoice.Total = Util.RoundTo2Decimal(invoice.Items.Sum(x => x.Quantity * x.Price) + invoice.TotalTax);

        }

       
    }
}
