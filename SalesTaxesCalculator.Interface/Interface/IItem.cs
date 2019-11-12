using SalesTaxesCalculator.Enum;
using System.Collections.Generic;

namespace SalesTaxesCalculator.Interface
{
    public interface IItem
    {
        List<ITaxe> ApplicableTaxes { get; set; }
        bool IsImported { get; set; }
        bool TaxesExemption { get;  }
        double TotalTaxes { get; set; }
        float Price { get; set; }
        int Quantity { get; set; }
        ItemCategories ItemCategories { get; set; }

    }
}