namespace SalesTaxesCalculator.Interface
{
    public interface IItemCalculator
    {
        void BuildItemTaxes(IItem item);
        void ApplyItemTaxes(IItem item);
        double GetItemTaxes(IItem item);
    }
}