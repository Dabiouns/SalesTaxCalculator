using SalesTaxesCalculator.Generator;
using SalesTaxesCalculator.Interface;
using SalesTaxesCalculator.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SalesTaxesCalculator.Invoice.Implementation
{
    class ItemCalculator : IItemCalculator
    {
        int BasicTaxeRate = 10;
        int ImportedTaxesRate = 5;

        public void BuildItemTaxes(IItem item)
        {
            List<ITaxe> ApplicableTaxes = new List<ITaxe>();

            if (item.IsImported) {
                ApplicableTaxes.Add(
                    new Taxe(1, new Description("ImportTaxe", "Taxe for imported product"),
                            ImportedTaxesRate));
            }

            if (item.ItemCategories == Enum.ItemCategories.Others)
            {
                ApplicableTaxes.Add(
                      new Taxe(1, new Description("BaseSaleTaxe", "Base Taxe "),
                              BasicTaxeRate));
            }

            item.ApplicableTaxes = ApplicableTaxes;
        }

        public void ApplyItemTaxes(IItem item)
        {
            if (!item.ApplicableTaxes.Any())
                return; 

            float totalRates = 0;

            item.ApplicableTaxes.ForEach(x => totalRates += x.Rates);
            
            item.TotalTaxes = (item.Quantity * item.Price) * (totalRates / 100);
            item.TotalTaxes = Util.Round(item.TotalTaxes);
        }        

        public double GetItemTaxes(IItem item)
        {
            return item.TotalTaxes;
        }
    }
}
