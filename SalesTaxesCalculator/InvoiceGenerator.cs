using SalesTaxesCalculator.Interface;
using SalesTaxesCalculator.Invoice.Implementation;
using SalesTaxesCalculator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxesCalculator
{
    public static class InvoiceGenerator
    {
        public static IInvoice GetInvoice1()
        {
            #region Input1
            //Input 1:

            List<IItem> item1 = new List<IItem>();
            //· 1 book at 12.49
            item1.Add(
                    new Models.Entities.Invoice.Item(
                         1,
                         new Description("Book", string.Empty),
                         12.49F,
                         1,
                         Enum.ItemCategories.Books,
                         false
                         ));
            //· 1 music CD at 14.99
            item1.Add(
                new Models.Entities.Invoice.Item(
                     2,
                     new Description("music CD", string.Empty),
                     14.99f,
                     1,
                     Enum.ItemCategories.Others,
                     false
                     ));
            //· 1 chocolate bar at 0.8
            item1.Add(
                new Models.Entities.Invoice.Item(
                     2,
                     new Description("chocolate bar", string.Empty),
                     0.8f,
                     1,
                     Enum.ItemCategories.Food,
                     false
                     ));
            #endregion
         
            List<IItem> items = new List<IItem>();

            items.AddRange(item1);

            IInvoice invoice = new Models.Entities.Invoice.Invoice(1, items );

            IInvoiceCalculator invoiceCalculator = new InvoiceCalculator();

            return invoice;
        }

        #region Input2
        public static IInvoice GetInvoice2()
        {
            List<IItem> item2 = new List<IItem>();
            //· 1 imported box of chocolates at 10.00 
            item2.Add(
                        new Models.Entities.Invoice.Item(
                            1,
                            new Description("imported box of chocolates", string.Empty),
                            10.00F,
                            1,
                            Enum.ItemCategories.Food,
                            true
                            ));

            //- 1 imported bottle of perfume at 47.50 

            item2.Add(
                new Models.Entities.Invoice.Item(
                    1,
                    new Description("imported bottle of perfume", string.Empty),
                    10.00F,
                    1,
                    Enum.ItemCategories.Others,
                    true
                    ));

            List<IItem> items = new List<IItem>();

            items.AddRange(item2);

            IInvoice invoice = new Models.Entities.Invoice.Invoice(1, items);

            IInvoiceCalculator invoiceCalculator = new InvoiceCalculator();

            return invoice;
        }
        #endregion


        #region Input3
        public static IInvoice GetInvoice3()
        {  
            List<IItem> item3 = new List<IItem>();

            //· 1 imported bottle of perfume at 27.99
            item3.Add(
                  new Models.Entities.Invoice.Item(
                      1,
                      new Description("imported bottle of perfume", string.Empty),
                      27.99F,
                      1,
                      Enum.ItemCategories.Others,
                      true
                      ));
            //· 1 bottle of perfume at 18.99
            item3.Add(
             new Models.Entities.Invoice.Item(
                 2,
                 new Description("bottle of perfume", string.Empty),
                 18.99f,
                 1,
                 Enum.ItemCategories.Others,
                 true
                 ));
            //· 1 packet of headache pills at 9.75
            item3.Add(
             new Models.Entities.Invoice.Item(
                 3,
                 new Description("packet of headache pills", string.Empty),
                 9.75F,
                 1,
                 Enum.ItemCategories.MedicalProduct,
                 false
                 ));
            //· 1 box of imported chocolates at 11.25
            item3.Add(
             new Models.Entities.Invoice.Item(
                 4,
                 new Description("imported box of chocolates", string.Empty),
                 11.25F,
                 1,
                 Enum.ItemCategories.Food,
                 true
                 ));
            #endregion


            List<IItem> items = new List<IItem>();

            items.AddRange(item3);



            IInvoice invoice = new Models.Entities.Invoice.Invoice(1, items);

            IInvoiceCalculator invoiceCalculator = new InvoiceCalculator();

            return invoice;
        }
    }
}
