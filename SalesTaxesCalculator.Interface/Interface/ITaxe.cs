namespace SalesTaxesCalculator.Interface
{
    public interface ITaxe
    {
        IDescription Description { get; set; }
        float Rates { get; }
    }
}