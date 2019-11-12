using SalesTaxesCalculator.Models.Enum;

namespace SalesTaxesCalculator.Models.Entities
{
    public interface ITaxe
    {
        Description Description { get; set; }
        float Rates { get; }
        TaxeType TaxeType { get; }
    }
}