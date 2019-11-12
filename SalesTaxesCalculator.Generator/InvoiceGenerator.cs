using SalesTaxesCalculator.Interface;
using SalesTaxesCalculator.Models.Entities;
using System.Collections.Generic;

namespace SalesTaxesCalculator
{
    public static class InvoiceGenerator
    {

        #region Input1
        public static IInvoice GetInvoice1()
        {
            return new Models.Entities.Invoice.Invoice(1, GetItemsInput1());
        }

        private static List<IItem> GetItemsInput1()
        {
            return new List<IItem>
            {
                //· 1 book at 12.49
                new Models.Entities.Invoice.Item(
                         1,
                         new Description("Book", string.Empty),
                         12.49F,
                         1,
                         Enum.ItemCategories.Books,
                         false
                         ),
                //· 1 music CD at 14.99
                new Models.Entities.Invoice.Item(
                     2,
                     new Description("music CD", string.Empty),
                     14.99f,
                     1,
                     Enum.ItemCategories.Others,
                     false
                     ),
                //· 1 chocolate bar at 0.8
                new Models.Entities.Invoice.Item(
                     2,
                     new Description("chocolate bar", string.Empty),
                     0.85f,
                     1,
                     Enum.ItemCategories.Food,
                     false
                     )
            };
        }
        #endregion

        #region Input2
        public static IInvoice GetInvoice2()  {  
            return new Models.Entities.Invoice.Invoice(1, GetItemsInput2());
        }

        private static List<IItem> GetItemsInput2()
        {
            return new List<IItem>
            {
                //· 1 imported box of chocolates at 10.00 
                new Models.Entities.Invoice.Item(
                            1,
                            new Description("imported box of chocolates", string.Empty),
                            10.00F,
                            1,
                            Enum.ItemCategories.Food,
                            true
                            ),

                //- 1 imported bottle of perfume at 47.50 

                new Models.Entities.Invoice.Item(
                    1,
                    new Description("imported bottle of perfume", string.Empty),
                    47.50F,
                    1,
                    Enum.ItemCategories.Others,
                    true
                    )
            };
        }
        #endregion

        #region Input3
        public static IInvoice GetInvoice3()  {
               return new Models.Entities.Invoice.Invoice(1, GetItemsInput3());
        }

        private static List<IItem> GetItemsInput3()
        {
            return new List<IItem>
            {
                //· 1 imported bottle of perfume at 27.99
                new Models.Entities.Invoice.Item(
                      1,
                      new Description("imported bottle of perfume", string.Empty),
                      27.99F,
                      1,
                      Enum.ItemCategories.Others,
                      true
                      ),

                //· 1 bottle of perfume at 18.99
                new Models.Entities.Invoice.Item(
                     2,
                     new Description("bottle of perfume", string.Empty),
                    18.99f,
                     1,
                     Enum.ItemCategories.Others,
                     false
                     ),

                //· 1 packet of headache pills at 9.75
                new Models.Entities.Invoice.Item(
                     3,
                     new Description("packet of headache pills", string.Empty),
                     9.75F,
                     1,
                     Enum.ItemCategories.MedicalProduct,
                     false
                     ),

                //· 1 box of imported chocolates at 11.25
                new Models.Entities.Invoice.Item(
                     4,
                     new Description("imported box of chocolates", string.Empty),
                     11.25F,
                     1,
                     Enum.ItemCategories.Food,
                     true
                     )
            };
        }
        #endregion

 
    }
}
