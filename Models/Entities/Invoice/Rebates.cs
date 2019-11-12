namespace SalesTaxesCalculator.Models.Entities.Invoice
{
    public class Rebates
    {
        private RebatesType _rebatesType;
    }

    public enum RebatesType
    {
        Pourcentage,
        Fixed
    }
}
