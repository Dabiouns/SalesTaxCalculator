using System.Collections.Generic;

namespace SalesTaxesCalculator.Interface
{
    public interface IInvoice
    {
        List<IItem> Items { get; set; }
         double Total { get; set; }
         double TotalTax { get; set; }
    }
}