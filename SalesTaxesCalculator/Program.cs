using SalesTaxesCalculator.Interface;
using System;

namespace SalesTaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceService invoiceService = new InvoiceService();
            IInvoice invoiceInput1 = invoiceService.GetInput1();
     
            Console.Write(invoiceService.PrintReceipt(invoiceInput1));

         
            IInvoice invoiceInput2 = invoiceService.GetInput2();
            Console.Write(invoiceService.PrintReceipt(invoiceInput2));


            IInvoice invoiceInput3 = invoiceService.GetInput3();
           
            Console.Write(invoiceService.PrintReceipt(invoiceInput3));
        }
    }
}
